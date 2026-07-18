namespace WindowsFormsApplication1
{
    partial class CategoryForm
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
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.catdescription = new System.Windows.Forms.TextBox();
            this.catname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonproduct = new System.Windows.Forms.Button();
            this.button_seller = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.dataGridView_Category);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.catdescription);
            this.panel1.Controls.Add(this.catname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.catid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(251, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 602);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_Category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView_Category.ColumnHeadersHeight = 24;
            this.dataGridView_Category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Category.Location = new System.Drawing.Point(403, 104);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.RowTemplate.Height = 24;
            this.dataGridView_Category.Size = new System.Drawing.Size(434, 465);
            this.dataGridView_Category.TabIndex = 16;
            this.dataGridView_Category.Click += new System.EventHandler(this.dataGridView_Category_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(550, 50);
            this.label6.TabIndex = 15;
            this.label6.Text = "MANAGE CATEGORIES";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(214, 321);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(114, 62);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(110, 404);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(137, 62);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkOrange;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(8, 321);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 62);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // catdescription
            // 
            this.catdescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catdescription.ForeColor = System.Drawing.Color.Black;
            this.catdescription.Location = new System.Drawing.Point(154, 236);
            this.catdescription.Name = "catdescription";
            this.catdescription.Size = new System.Drawing.Size(204, 34);
            this.catdescription.TabIndex = 5;
            // 
            // catname
            // 
            this.catname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catname.ForeColor = System.Drawing.Color.Black;
            this.catname.Location = new System.Drawing.Point(154, 173);
            this.catname.Name = "catname";
            this.catname.Size = new System.Drawing.Size(204, 34);
            this.catname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // catid
            // 
            this.catid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catid.ForeColor = System.Drawing.Color.Black;
            this.catid.Location = new System.Drawing.Point(154, 104);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(204, 34);
            this.catid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // buttonproduct
            // 
            this.buttonproduct.BackColor = System.Drawing.Color.White;
            this.buttonproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonproduct.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonproduct.Location = new System.Drawing.Point(9, 104);
            this.buttonproduct.Name = "buttonproduct";
            this.buttonproduct.Size = new System.Drawing.Size(236, 46);
            this.buttonproduct.TabIndex = 28;
            this.buttonproduct.Text = "Product";
            this.buttonproduct.UseVisualStyleBackColor = false;
            this.buttonproduct.Click += new System.EventHandler(this.buttonproduct_Click);
            // 
            // button_seller
            // 
            this.button_seller.BackColor = System.Drawing.Color.White;
            this.button_seller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_seller.Location = new System.Drawing.Point(9, 43);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(236, 50);
            this.button_seller.TabIndex = 27;
            this.button_seller.Text = "Seller";
            this.button_seller.UseVisualStyleBackColor = false;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // button_selling
            // 
            this.button_selling.BackColor = System.Drawing.Color.White;
            this.button_selling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_selling.Location = new System.Drawing.Point(12, 168);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(236, 50);
            this.button_selling.TabIndex = 29;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = false;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_exit.Location = new System.Drawing.Point(1054, 6);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(37, 34);
            this.label_exit.TabIndex = 26;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(55, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 34);
            this.label3.TabIndex = 30;
            this.label3.Text = "LOGOUT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonproduct);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox catdescription;
        private System.Windows.Forms.TextBox catname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonproduct;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Label label3;

    }
}