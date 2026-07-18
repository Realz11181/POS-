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
    public partial class CategoryForm : Form
    {
        DBconn dBconn = new DBconn();
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Category";
            OleDbCommand cmd = new OleDbCommand(selectQuery, dBconn.GetCon());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Category.DataSource = table;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + catid.Text + ",'" + catname.Text + "','" + catdescription.Text + "')";
                OleDbCommand cmd = new OleDbCommand(insertQuery, dBconn.GetCon());
                dBconn.OpenCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBconn.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (catid.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName='" + catname.Text + "', CatDes ='" + catdescription.Text + "' WHERE catId =" + catid.Text + "";
                    OleDbCommand cmd = new OleDbCommand(updateQuery, dBconn.GetCon());
                    dBconn.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       private void dataGridView_Category_Click(object sender, EventArgs e)
       {
           
       }
       private void clear()
       {
           catid.Clear();
           catname.Clear();
           catdescription.Clear();
       }

       private void button_delete_Click(object sender, EventArgs e)
       {
           try
           {
               string deleteQuery = "DELETE FROM Category WHERE catld = '" + catid + "'";
               OleDbCommand cmd = new OleDbCommand(deleteQuery, dBconn.GetCon());
               dBconn.OpenCon();
               cmd.ExecuteNonQuery();
               MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               dBconn.CloseCon();
               getTable();
               clear();
            

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }
       }

       private void label_exit_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void label_exit_MouseEnter(object sender, EventArgs e)
       {
           label_exit.ForeColor = Color.Red;
       }

       private void label_exit_MouseLeave(object sender, EventArgs e)
       {
           label_exit.ForeColor = Color.DarkOrange;
       }

       private void label3_MouseEnter(object sender, EventArgs e)
       {
           label3.ForeColor = Color.Red;
       }

       private void label3_MouseLeave(object sender, EventArgs e)
       {
           label3.ForeColor = Color.DarkOrange;
       }

       private void label3_Click(object sender, EventArgs e)
       {
           LogInForm login = new LogInForm();
           login.Show();
           this.Hide();
       }

       private void buttonproduct_Click(object sender, EventArgs e)
       {
           ProductForm product = new ProductForm();
           product.Show();
           this.Hide();
       }

       private void button_seller_Click(object sender, EventArgs e)
       {
           SellerForm seller = new SellerForm();
           seller.Show();
           this.Hide();
       }

    
    }
}
