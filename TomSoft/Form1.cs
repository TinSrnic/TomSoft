using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TomSoft
{
    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://apidemo.luceed.hr/datasnap/rest/");
            var byteArray = new UTF8Encoding().GetBytes("luceed_mb:7e5y2Uza");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

    private async void button1_Click(object sender, EventArgs e) 
        {
            string searchTerm = txtArticleName.Text;
            HttpResponseMessage response = client.GetAsync(String.Format("artikli/naziv/{0}", searchTerm)).Result; 
            if (response.IsSuccessStatusCode) {
                var articlesJson = await response.Content.ReadAsStringAsync();
                var articles = JObject.Parse(articlesJson).SelectToken("result").First.SelectToken("artikli");
                List<Article> articleList = new List<Article>();
                foreach (var articleJson in articles)
                {
                    int id = Int32.Parse(articleJson["id"].ToString());
                    string name = articleJson["naziv"].ToString();
                    articleList.Add(new Article(id, name));
                }

                articleList = articleList.OrderBy(o => o.id).ToList();
                dataArticles.DataSource = articleList;
            } else
            {
                dataArticles.DataSource = null;
            }
        }

        private async void btnSearchPayment_Click(object sender, EventArgs e)
        {
            string paymentId = txtPaymentId.Text;
            string fromDate = dateFromPayment.Value.Date.ToString("dd.MM.yyyy");
            string toDate = dateToPayment.Value.Date.ToString("dd.MM.yyyy");
            HttpResponseMessage response;
            if (checkPaymentToDate.Checked)
            {
                response = client.GetAsync(String.Format("mpobracun/placanja/{0}/{1}/{2}", paymentId, fromDate, toDate)).Result;
            } else
            {
                response = client.GetAsync(String.Format("mpobracun/placanja/{0}/{1}", paymentId, fromDate, toDate)).Result;
            }
            
            if (response.IsSuccessStatusCode)
            {
                var paymentsJson = await response.Content.ReadAsStringAsync();
                var payments = JObject.Parse(paymentsJson).SelectToken("result").First.SelectToken("obracun_placanja");
                List<Payment> paymentList = new List<Payment>();
                foreach (var paymentJson in payments)
                {
                    string id = paymentJson["vrste_placanja_uid"].ToString();
                    string name = paymentJson["naziv"].ToString();
                    double amount = Double.Parse(paymentJson["iznos"].ToString());
                    paymentList.Add(new Payment(id, name, amount));
                }

                paymentList = paymentList.OrderBy(o => o.paymentTypeId).ToList();
                dataPayment.DataSource = paymentList;
            }
            else
            {
                dataPayment.DataSource = null;
            }
        }

        private void checkPaymentToDate_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPaymentToDate.Checked)
            {
                dateToPayment.Enabled = true;
            } else
            {
                dateToPayment.Enabled = false;
            }
            
        }

        private void checkDateFromArticle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDateFromArticle.Checked)
            {
                dateToArticle.Enabled = true;
            }
            else
            {
                dateToArticle.Enabled = false;
            }
        }

        private async void btnSearchPaymentArticle_Click(object sender, EventArgs e)
        {
            string pjId = txtPjUidArticle.Text;
            string fromDate = dateFromArticle.Value.Date.ToString("dd.MM.yyyy");
            string toDate = dateToArticle.Value.Date.ToString("dd.MM.yyyy");
            HttpResponseMessage response;
            if (checkPaymentToDate.Checked)
            {
                response = client.GetAsync(String.Format("mpobracun/artikli/{0}/{1}/{2}", pjId, fromDate, toDate)).Result;
            }
            else
            {
                response = client.GetAsync(String.Format("mpobracun/artikli/{0}/{1}", pjId, fromDate, toDate)).Result;
            }

            if (response.IsSuccessStatusCode)
            {
                var articlePaymentsJson = await response.Content.ReadAsStringAsync();
                var articlePayments = JObject.Parse(articlePaymentsJson).SelectToken("result").First.SelectToken("obracun_artikli");
                if(articlePayments is null)
                {
                    dataPaymentArticle.DataSource = null;
                    return;
                }
                List<ArticlePayment> paymentArticleList = new List<ArticlePayment>();
                foreach (var articlePayment in articlePayments)
                {
                    string id = tryJsonRead<string>(articlePayment, "artikl_uid", ToString, "");
                    string name = tryJsonRead<string>(articlePayment, "naziv", ToString, "");
                    int quantity = tryJsonRead<int>(articlePayment, "kolicina", int.Parse, 0);
                    double amount = tryJsonRead<double>(articlePayment, "iznos", double.Parse, 0.0);
                    char service = tryJsonRead<char>(articlePayment, "usluga", char.Parse, 'D');

                    paymentArticleList.Add(new ArticlePayment(id, name, quantity, amount, service));
                }

                paymentArticleList = paymentArticleList.OrderBy(o => o.articleId).ToList();
                dataPaymentArticle.DataSource = paymentArticleList;
            }
            else
            {
                dataPaymentArticle.DataSource = null;
            }
        }

        public string ToString(string input)
        {
            return input;
        }

        public T tryJsonRead<T>(JToken json, string key, Func<string, T> converter, T defaultValue)
        {
            if(json[key] is null)
            {
                return defaultValue;
            } else
            {
                return converter(json[key].ToString());
            }
        }
    }
}
