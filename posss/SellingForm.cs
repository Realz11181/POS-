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
    public partial class SellingForm : Form
    {
        DBconn dBconn = new DBconn();
        public SellingForm()
        {
            InitializeComponent();
        }


        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            OleDbCommand cmd = new OleDbCommand(selectQuery, dBconn.GetCon());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "catname";
          
        }

        private void getTable()
        {
            string selectQuery = "SELECT ProdName, ProdPrice FROM Products";
            OleDbCommand cmd = new OleDbCommand(selectQuery, dBconn.GetCon());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            //sellname.Text = dataGridView_product.SelectedRows[0].Cells.Value.ToString();
        }
    }
}
