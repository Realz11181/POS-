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
    public partial class SellerForm : Form
    {
        DBconn dBconn = new DBconn();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Seller";
            OleDbCommand cmd = new OleDbCommand(selectQuery, dBconn.GetCon());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Seller.DataSource = table;
        }
        private void clear()
        {
            sellid.Clear();
            sellname.Clear();
            sellage.Clear();
            sellpasword.Clear();
            sellphone.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES (" + sellid.Text + ", '" + sellname.Text + "', '" + sellage.Text + "','" + sellphone.Text + "','" + sellpasword.Text+ "')";
                OleDbCommand cmd = new OleDbCommand(insertQuery, dBconn.GetCon());
                dBconn.OpenCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBconn.CloseCon();
               getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_updatee_Click(object sender, EventArgs e)
        {
            try
            {

                string updateQuery = "UPDATE Seller SET SellerName='" + sellname.Text + "', SellerAge ='" + sellage.Text + "', SellerPhone = '"+sellphone.Text+"', SellerPass = '"+sellpasword.Text+"' WHERE SellerID =" + sellid.Text + "";
                OleDbCommand cmd = new OleDbCommand(updateQuery, dBconn.GetCon());
                    dBconn.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBconn.CloseCon();
                    getTable();
                    clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellid.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string deleteQuery = "DELETE FROM Products WHERE SellerID= " + sellid.Text + "";
                    OleDbCommand cmd = new OleDbCommand(deleteQuery, dBconn.GetCon());
                    dBconn.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Logout_MouseEnter(object sender, EventArgs e)
        {
            Logout.ForeColor = Color.Red;
        }

        private void Logout_MouseLeave(object sender, EventArgs e)
        {
            Logout.ForeColor = Color.DarkOrange;

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkOrange;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LogInForm lOGIN = new LogInForm();
            lOGIN.Show();
            this.Hide();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void buttoncategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
    }
}
