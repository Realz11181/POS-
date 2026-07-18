using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class ProductForm : Form
    {
        DBconn dBconn = new DBconn();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void buttoncategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            OleDbCommand cmd = new OleDbCommand(selectQuery, dBconn.GetCon());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            prod_category.DataSource = table;
            prod_category.ValueMember = "catname";
            comboBox_Search.DataSource = table;
            comboBox_Search.ValueMember = "catname";
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Products";
            OleDbCommand cmd = new OleDbCommand(selectQuery, dBconn.GetCon());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }

        private void clear()
        {
            prodid.Clear();
            prodname.Clear();
            prodprice.Clear();
            prodquantity.Clear();
            prod_category.SelectedIndex = 0;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Products VALUES ('" + prodid.Text + "', '" + prodname.Text + "', " + prodprice.Text + "," + prodquantity.Text + ",'" + prod_category.Text + "')";
                OleDbCommand cmd = new OleDbCommand(insertQuery, dBconn.GetCon());
                dBconn.OpenCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBconn.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_updatee_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodid.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (prodname.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (prodprice.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (prodquantity.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Products SET ProdName = '" + prodname.Text + "', ProdPrice = " + prodprice.Text + ", ProdQty = " + prodquantity.Text + ", ProdCt = '" + prod_category.Text + "' WHERE ProId = '" + prodid.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(updateQuery, dBconn.GetCon());
                    dBconn.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBconn.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Product_Click(object sender, EventArgs e)
        {
            //prodid.Text = dataGridView_Product.SelectedRows[0].Cells[0].Value.ToString();
            //prodname.Text = dataGridView_Product.SelectedRows[0].Cells[1].Value.ToString();
            //prodprice.Text = dataGridView_Product.SelectedRows[0].Cells[2].Value.ToString();
            //prodquantity.Text = dataGridView_Product.SelectedRows[0].Cells[3].Value.ToString();
            //prod_category.SelectedValue = dataGridView_Product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodid.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string deleteQuery = "DELETE FROM Products WHERE ProId = " + prodid.Text + "";
                    OleDbCommand cmd = new OleDbCommand(deleteQuery, dBconn.GetCon());
                    dBconn.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBconn.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkOrange;
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.DarkOrange;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }
     
    }
}
