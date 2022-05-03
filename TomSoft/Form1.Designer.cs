
namespace TomSoft
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArticleNameSearch = new System.Windows.Forms.Button();
            this.dataArticles = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateToPayment = new System.Windows.Forms.DateTimePicker();
            this.dateFromPayment = new System.Windows.Forms.DateTimePicker();
            this.dataPayment = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageArticles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtArticleName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchPayment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkPaymentToDate = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dataPaymentArticle = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchPaymentArticle = new System.Windows.Forms.Button();
            this.dateFromArticle = new System.Windows.Forms.DateTimePicker();
            this.dateToArticle = new System.Windows.Forms.DateTimePicker();
            this.txtPjUidArticle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkDateFromArticle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageArticles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentArticle)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArticleNameSearch
            // 
            this.btnArticleNameSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticleNameSearch.Location = new System.Drawing.Point(3, 20);
            this.btnArticleNameSearch.Name = "btnArticleNameSearch";
            this.btnArticleNameSearch.Size = new System.Drawing.Size(129, 59);
            this.btnArticleNameSearch.TabIndex = 0;
            this.btnArticleNameSearch.Text = "Pretraži";
            this.btnArticleNameSearch.UseVisualStyleBackColor = true;
            this.btnArticleNameSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataArticles
            // 
            this.dataArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArticles.Location = new System.Drawing.Point(3, 109);
            this.dataArticles.Name = "dataArticles";
            this.dataArticles.RowHeadersWidth = 82;
            this.dataArticles.RowTemplate.Height = 33;
            this.dataArticles.Size = new System.Drawing.Size(1102, 510);
            this.dataArticles.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateToPayment
            // 
            this.dateToPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateToPayment.Enabled = false;
            this.dateToPayment.Location = new System.Drawing.Point(780, 59);
            this.dateToPayment.Name = "dateToPayment";
            this.dateToPayment.Size = new System.Drawing.Size(319, 31);
            this.dateToPayment.TabIndex = 3;
            // 
            // dateFromPayment
            // 
            this.dateFromPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFromPayment.Location = new System.Drawing.Point(456, 59);
            this.dateFromPayment.Name = "dateFromPayment";
            this.dateFromPayment.Size = new System.Drawing.Size(318, 31);
            this.dateFromPayment.TabIndex = 4;
            // 
            // dataPayment
            // 
            this.dataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPayment.Location = new System.Drawing.Point(3, 109);
            this.dataPayment.Name = "dataPayment";
            this.dataPayment.RowHeadersWidth = 82;
            this.dataPayment.RowTemplate.Height = 33;
            this.dataPayment.Size = new System.Drawing.Size(1102, 510);
            this.dataPayment.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageArticles);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1130, 675);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageArticles
            // 
            this.tabPageArticles.Controls.Add(this.tableLayoutPanel1);
            this.tabPageArticles.Location = new System.Drawing.Point(8, 39);
            this.tabPageArticles.Name = "tabPageArticles";
            this.tabPageArticles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArticles.Size = new System.Drawing.Size(1114, 628);
            this.tabPageArticles.TabIndex = 0;
            this.tabPageArticles.Text = "Artikli";
            this.tabPageArticles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataArticles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 622);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnArticleNameSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtArticleName, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1102, 100);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtArticleName
            // 
            this.txtArticleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtArticleName.Location = new System.Drawing.Point(138, 34);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.Size = new System.Drawing.Size(439, 31);
            this.txtArticleName.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plaćanja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchPayment
            // 
            this.btnSearchPayment.Location = new System.Drawing.Point(3, 3);
            this.btnSearchPayment.Name = "btnSearchPayment";
            this.btnSearchPayment.Size = new System.Drawing.Size(123, 44);
            this.btnSearchPayment.TabIndex = 7;
            this.btnSearchPayment.Text = "Pretraži";
            this.btnSearchPayment.UseVisualStyleBackColor = true;
            this.btnSearchPayment.Click += new System.EventHandler(this.btnSearchPayment_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1114, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Obračun artikli";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataPayment, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1108, 622);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSearchPayment, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateFromPayment, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.dateToPayment, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtPaymentId, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblPaymentId, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1102, 100);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentId.Location = new System.Drawing.Point(132, 59);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(318, 31);
            this.txtPaymentId.TabIndex = 8;
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Location = new System.Drawing.Point(132, 25);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(136, 25);
            this.lblPaymentId.TabIndex = 9;
            this.lblPaymentId.Text = "Plaćanje UID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Od datuma";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Do datuma";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkPaymentToDate, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(780, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(319, 44);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // checkPaymentToDate
            // 
            this.checkPaymentToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkPaymentToDate.AutoSize = true;
            this.checkPaymentToDate.Location = new System.Drawing.Point(162, 12);
            this.checkPaymentToDate.Name = "checkPaymentToDate";
            this.checkPaymentToDate.Size = new System.Drawing.Size(154, 29);
            this.checkPaymentToDate.TabIndex = 12;
            this.checkPaymentToDate.Text = "Uključi u pretragu";
            this.checkPaymentToDate.UseVisualStyleBackColor = true;
            this.checkPaymentToDate.CheckedChanged += new System.EventHandler(this.checkPaymentToDate_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.dataPaymentArticle, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1114, 628);
            this.tableLayoutPanel7.TabIndex = 10;
            // 
            // dataPaymentArticle
            // 
            this.dataPaymentArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPaymentArticle.Location = new System.Drawing.Point(3, 109);
            this.dataPaymentArticle.Name = "dataPaymentArticle";
            this.dataPaymentArticle.RowHeadersWidth = 82;
            this.dataPaymentArticle.RowTemplate.Height = 33;
            this.dataPaymentArticle.Size = new System.Drawing.Size(1108, 516);
            this.dataPaymentArticle.TabIndex = 6;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnSearchPaymentArticle, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.dateFromArticle, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.dateToArticle, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.txtPjUidArticle, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1108, 100);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Od datuma";
            // 
            // btnSearchPaymentArticle
            // 
            this.btnSearchPaymentArticle.Location = new System.Drawing.Point(3, 3);
            this.btnSearchPaymentArticle.Name = "btnSearchPaymentArticle";
            this.btnSearchPaymentArticle.Size = new System.Drawing.Size(123, 44);
            this.btnSearchPaymentArticle.TabIndex = 7;
            this.btnSearchPaymentArticle.Text = "Pretraži";
            this.btnSearchPaymentArticle.UseVisualStyleBackColor = true;
            this.btnSearchPaymentArticle.Click += new System.EventHandler(this.btnSearchPaymentArticle_Click);
            // 
            // dateFromArticle
            // 
            this.dateFromArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFromArticle.Location = new System.Drawing.Point(458, 59);
            this.dateFromArticle.Name = "dateFromArticle";
            this.dateFromArticle.Size = new System.Drawing.Size(320, 31);
            this.dateFromArticle.TabIndex = 4;
            // 
            // dateToArticle
            // 
            this.dateToArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateToArticle.Enabled = false;
            this.dateToArticle.Location = new System.Drawing.Point(784, 59);
            this.dateToArticle.Name = "dateToArticle";
            this.dateToArticle.Size = new System.Drawing.Size(321, 31);
            this.dateToArticle.TabIndex = 3;
            // 
            // txtPjUidArticle
            // 
            this.txtPjUidArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPjUidArticle.Location = new System.Drawing.Point(132, 59);
            this.txtPjUidArticle.Name = "txtPjUidArticle";
            this.txtPjUidArticle.Size = new System.Drawing.Size(320, 31);
            this.txtPjUidArticle.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pj UID";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.checkDateFromArticle, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(784, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(321, 44);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Do datuma";
            // 
            // checkDateFromArticle
            // 
            this.checkDateFromArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkDateFromArticle.AutoSize = true;
            this.checkDateFromArticle.Location = new System.Drawing.Point(163, 12);
            this.checkDateFromArticle.Name = "checkDateFromArticle";
            this.checkDateFromArticle.Size = new System.Drawing.Size(155, 29);
            this.checkDateFromArticle.TabIndex = 12;
            this.checkDateFromArticle.Text = "Uključi u pretragu";
            this.checkDateFromArticle.UseVisualStyleBackColor = true;
            this.checkDateFromArticle.CheckedChanged += new System.EventHandler(this.checkDateFromArticle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageArticles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentArticle)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArticleNameSearch;
        private System.Windows.Forms.DataGridView dataArticles;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateToPayment;
        private System.Windows.Forms.DateTimePicker dateFromPayment;
        private System.Windows.Forms.DataGridView dataPayment;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageArticles;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearchPayment;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox checkPaymentToDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dataPaymentArticle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchPaymentArticle;
        private System.Windows.Forms.DateTimePicker dateFromArticle;
        private System.Windows.Forms.DateTimePicker dateToArticle;
        private System.Windows.Forms.TextBox txtPjUidArticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkDateFromArticle;
    }
}

