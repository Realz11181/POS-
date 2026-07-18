namespace WindowsFormsApplication1
{
    partial class SellingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.sellqty = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.sellprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Label();
            this.dataGridView_sellint = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView_sellint);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sellqty);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.sellprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sellname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sellid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(154, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 602);
            this.panel1.TabIndex = 31;
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Location = new System.Drawing.Point(381, 62);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowTemplate.Height = 24;
            this.dataGridView_order.Size = new System.Drawing.Size(547, 165);
            this.dataGridView_order.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "SELLING";
            // 
            // sellqty
            // 
            this.sellqty.ForeColor = System.Drawing.Color.Black;
            this.sellqty.Location = new System.Drawing.Point(169, 193);
            this.sellqty.Name = "sellqty";
            this.sellqty.Size = new System.Drawing.Size(158, 22);
            this.sellqty.TabIndex = 7;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.White;
            this.Age.Location = new System.Drawing.Point(33, 150);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(58, 24);
            this.Age.TabIndex = 6;
            this.Age.Text = "Price";
            // 
            // sellprice
            // 
            this.sellprice.ForeColor = System.Drawing.Color.Black;
            this.sellprice.Location = new System.Drawing.Point(169, 150);
            this.sellprice.Name = "sellprice";
            this.sellprice.Size = new System.Drawing.Size(158, 22);
            this.sellprice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sellname
            // 
            this.sellname.ForeColor = System.Drawing.Color.Black;
            this.sellname.Location = new System.Drawing.Point(169, 104);
            this.sellname.Name = "sellname";
            this.sellname.Size = new System.Drawing.Size(158, 22);
            this.sellname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // sellid
            // 
            this.sellid.ForeColor = System.Drawing.Color.Black;
            this.sellid.Location = new System.Drawing.Point(169, 62);
            this.sellid.Name = "sellid";
            this.sellid.Size = new System.Drawing.Size(158, 22);
            this.sellid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_exit.Location = new System.Drawing.Point(1060, 6);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(37, 34);
            this.label_exit.TabIndex = 32;
            this.label_exit.Text = "X";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.DarkOrange;
            this.Logout.Location = new System.Drawing.Point(12, 582);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(83, 25);
            this.Logout.TabIndex = 30;
            this.Logout.Text = "Logout";
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(31, 361);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowTemplate.Height = 24;
            this.dataGridView_product.Size = new System.Drawing.Size(286, 238);
            this.dataGridView_product.TabIndex = 17;
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "SellerName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(719, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date:";
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(46, 306);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(153, 30);
            this.comboBox_category.TabIndex = 20;
            this.comboBox_category.Text = "Select Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(226, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Refresh";
            // 
            // btn_order
            // 
            this.btn_order.AutoSize = true;
            this.btn_order.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(127, 254);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(118, 25);
            this.btn_order.TabIndex = 34;
            this.btn_order.Text = "Add Order";
            // 
            // dataGridView_sellint
            // 
            this.dataGridView_sellint.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_sellint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sellint.Location = new System.Drawing.Point(368, 325);
            this.dataGridView_sellint.Name = "dataGridView_sellint";
            this.dataGridView_sellint.RowTemplate.Height = 24;
            this.dataGridView_sellint.Size = new System.Drawing.Size(547, 230);
            this.dataGridView_sellint.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(578, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Sells List";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(392, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "Amount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(719, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ks";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(535, 568);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(52, 24);
            this.btnadd.TabIndex = 39;
            this.btnadd.Text = "ADD";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(710, 568);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(70, 24);
            this.btnprint.TabIndex = 40;
            this.btnprint.Text = "PRINT";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnprint;
        private System.Windows.Forms.Label btnadd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_sellint;
        private System.Windows.Forms.Label btn_order;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sellqty;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox sellprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sellid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label Logout;
    }
}