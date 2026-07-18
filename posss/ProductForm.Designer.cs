namespace WindowsFormsApplication1
{
    partial class ProductForm
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
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_updatee = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.prod_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodquantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prodid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.button_seller = new System.Windows.Forms.Button();
            this.buttoncategory = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.dataGridView_Product);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_Search);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_updatee);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.prod_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prodquantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prodprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prodname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prodid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(157, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 602);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(405, 128);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowTemplate.Height = 24;
            this.dataGridView_Product.Size = new System.Drawing.Size(523, 465);
            this.dataGridView_Product.TabIndex = 16;
            this.dataGridView_Product.Click += new System.EventHandler(this.dataGridView_Product_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(125, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 65);
            this.label6.TabIndex = 15;
            this.label6.Text = "MANAGE PRODUCTS";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(710, 61);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(181, 51);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "REFREASH";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Location = new System.Drawing.Point(516, 78);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(156, 24);
            this.comboBox_Search.TabIndex = 13;
            this.comboBox_Search.Text = "Select Category";
            this.comboBox_Search.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Search_SelectionChangeCommitted);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(248, 441);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(102, 49);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_updatee
            // 
            this.button_updatee.BackColor = System.Drawing.Color.DarkOrange;
            this.button_updatee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatee.ForeColor = System.Drawing.Color.White;
            this.button_updatee.Location = new System.Drawing.Point(109, 441);
            this.button_updatee.Name = "button_updatee";
            this.button_updatee.Size = new System.Drawing.Size(120, 49);
            this.button_updatee.TabIndex = 11;
            this.button_updatee.Text = "Update";
            this.button_updatee.UseVisualStyleBackColor = false;
            this.button_updatee.Click += new System.EventHandler(this.button_updatee_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkOrange;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(8, 441);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 49);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // prod_category
            // 
            this.prod_category.FormattingEnabled = true;
            this.prod_category.Location = new System.Drawing.Point(160, 358);
            this.prod_category.Name = "prod_category";
            this.prod_category.Size = new System.Drawing.Size(156, 24);
            this.prod_category.TabIndex = 9;
            this.prod_category.Text = "Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // prodquantity
            // 
            this.prodquantity.ForeColor = System.Drawing.Color.Black;
            this.prodquantity.Location = new System.Drawing.Point(158, 293);
            this.prodquantity.Name = "prodquantity";
            this.prodquantity.Size = new System.Drawing.Size(158, 22);
            this.prodquantity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // prodprice
            // 
            this.prodprice.ForeColor = System.Drawing.Color.Black;
            this.prodprice.Location = new System.Drawing.Point(158, 228);
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(158, 22);
            this.prodprice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // prodname
            // 
            this.prodname.ForeColor = System.Drawing.Color.Black;
            this.prodname.Location = new System.Drawing.Point(158, 165);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(158, 22);
            this.prodname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // prodid
            // 
            this.prodid.ForeColor = System.Drawing.Color.Black;
            this.prodid.Location = new System.Drawing.Point(158, 99);
            this.prodid.Name = "prodid";
            this.prodid.Size = new System.Drawing.Size(158, 22);
            this.prodid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 97);
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
            this.label_exit.Location = new System.Drawing.Point(1063, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(37, 34);
            this.label_exit.TabIndex = 20;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // button_seller
            // 
            this.button_seller.BackColor = System.Drawing.Color.Silver;
            this.button_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_seller.Location = new System.Drawing.Point(6, 40);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(129, 49);
            this.button_seller.TabIndex = 21;
            this.button_seller.Text = "Seller";
            this.button_seller.UseVisualStyleBackColor = false;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // buttoncategory
            // 
            this.buttoncategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttoncategory.BackColor = System.Drawing.Color.Silver;
            this.buttoncategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttoncategory.Location = new System.Drawing.Point(6, 107);
            this.buttoncategory.Name = "buttoncategory";
            this.buttoncategory.Size = new System.Drawing.Size(129, 50);
            this.buttoncategory.TabIndex = 22;
            this.buttoncategory.Text = "Category";
            this.buttoncategory.UseVisualStyleBackColor = false;
            this.buttoncategory.Click += new System.EventHandler(this.buttoncategory_Click);
            // 
            // button_selling
            // 
            this.button_selling.BackColor = System.Drawing.Color.Silver;
            this.button_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_selling.Location = new System.Drawing.Point(6, 174);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(129, 59);
            this.button_selling.TabIndex = 23;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Silver;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_logout.Location = new System.Drawing.Point(6, 578);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(101, 60);
            this.button_logout.TabIndex = 24;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            this.button_logout.MouseEnter += new System.EventHandler(this.button_logout_MouseEnter);
            this.button_logout.MouseLeave += new System.EventHandler(this.button_logout_MouseLeave);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.buttoncategory);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prodprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prodid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_updatee;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox prod_category;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Button buttoncategory;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_logout;
    }
}