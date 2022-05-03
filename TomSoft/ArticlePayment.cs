using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomSoft
{
    class ArticlePayment
    {
        public string articleId { get; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }
        public char service { get; set; }

        public ArticlePayment(string articleId, string name, int quantity, double amount, char service)
        {
            this.articleId = articleId;
            this.name = name;
            this.quantity = quantity;
            this.amount = amount;
            this.service = service;
        }
    }
}
