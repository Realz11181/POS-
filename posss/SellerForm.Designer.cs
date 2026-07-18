namespace WindowsFormsApplication1
{
    partial class SellerForm
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
            this.sellpasword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_Seller = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_updatee = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.sellphone = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.sellage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncategory = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.sellpasword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView_Seller);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_updatee);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.sellphone);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.sellage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sellname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sellid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(154, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 602);
            this.panel1.TabIndex = 25;
            // 
            // sellpasword
            // 
            this.sellpasword.ForeColor = System.Drawing.Color.Black;
            this.sellpasword.Location = new System.Drawing.Point(158, 346);
            this.sellpasword.Name = "sellpasword";
            this.sellpasword.Size = new System.Drawing.Size(158, 22);
            this.sellpasword.TabIndex = 18;
            this.sellpasword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView_Seller
            // 
            this.dataGridView_Seller.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_Seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Seller.Location = new System.Drawing.Point(413, 79);
            this.dataGridView_Seller.Name = "dataGridView_Seller";
            this.dataGridView_Seller.RowTemplate.Height = 24;
            this.dataGridView_Seller.Size = new System.Drawing.Size(723, 465);
            this.dataGridView_Seller.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(147, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 65);
            this.label6.TabIndex = 15;
            this.label6.Text = "MANAGE SELLER";
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
            // sellphone
            // 
            this.sellphone.ForeColor = System.Drawing.Color.Black;
            this.sellphone.Location = new System.Drawing.Point(158, 293);
            this.sellphone.Name = "sellphone";
            this.sellphone.Size = new System.Drawing.Size(158, 22);
            this.sellphone.TabIndex = 7;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.White;
            this.Age.Location = new System.Drawing.Point(22, 228);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(48, 24);
            this.Age.TabIndex = 6;
            this.Age.Text = "Age";
            // 
            // sellage
            // 
            this.sellage.ForeColor = System.Drawing.Color.Black;
            this.sellage.Location = new System.Drawing.Point(158, 228);
            this.sellage.Name = "sellage";
            this.sellage.Size = new System.Drawing.Size(158, 22);
            this.sellage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sellname
            // 
            this.sellname.ForeColor = System.Drawing.Color.Black;
            this.sellname.Location = new System.Drawing.Point(158, 165);
            this.sellname.Name = "sellname";
            this.sellname.Size = new System.Drawing.Size(158, 22);
            this.sellname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // sellid
            // 
            this.sellid.ForeColor = System.Drawing.Color.Black;
            this.sellid.Location = new System.Drawing.Point(158, 99);
            this.sellid.Name = "sellid";
            this.sellid.Size = new System.Drawing.Size(158, 22);
            this.sellid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // buttoncategory
            // 
            this.buttoncategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttoncategory.BackColor = System.Drawing.Color.Silver;
            this.buttoncategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttoncategory.Location = new System.Drawing.Point(3, 104);
            this.buttoncategory.Name = "buttoncategory";
            this.buttoncategory.Size = new System.Drawing.Size(129, 50);
            this.buttoncategory.TabIndex = 28;
            this.buttoncategory.Text = "Category";
            this.buttoncategory.UseVisualStyleBackColor = false;
            this.buttoncategory.Click += new System.EventHandler(this.buttoncategory_Click);
            // 
            // button_products
            // 
            this.button_products.BackColor = System.Drawing.Color.Silver;
            this.button_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_products.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_products.Location = new System.Drawing.Point(3, 37);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(129, 49);
            this.button_products.TabIndex = 27;
            this.button_products.Text = "Product";
            this.button_products.UseVisualStyleBackColor = false;
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // button_selling
            // 
            this.button_selling.BackColor = System.Drawing.Color.Silver;
            this.button_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_selling.Location = new System.Drawing.Point(3, 171);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(129, 59);
            this.button_selling.TabIndex = 29;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = false;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_exit.Location = new System.Drawing.Point(1258, -3);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(37, 34);
            this.label_exit.TabIndex = 26;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.DarkOrange;
            this.Logout.Location = new System.Drawing.Point(12, 582);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(83, 25);
            this.Logout.TabIndex = 19;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            this.Logout.MouseEnter += new System.EventHandler(this.Logout_MouseEnter);
            this.Logout.MouseLeave += new System.EventHandler(this.Logout_MouseLeave);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 650);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttoncategory);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Seller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_updatee;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox sellphone;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox sellage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sellid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncategory;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.TextBox sellpasword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Logout;
    }
}