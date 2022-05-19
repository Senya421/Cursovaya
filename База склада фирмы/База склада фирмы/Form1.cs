using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace База_склада_фирмы
{
    public partial class Form1 : Form
    {
        
        public Form1() 
        {
            InitializeComponent();
            

        }

        private void Products_Load(object sender, EventArgs e)
        {
            
        }

      
        DataTable dataTable;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Наименование товара");
            dataTable.Columns.Add("Тип товара");
            dataTable.Columns.Add("Характеристика товара");
            dataTable.Columns.Add("Цена товара");
            dataGridView1.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            dataTable.Rows.Add(products.ProductName, products.Type, products.ProductCharacteristic, products.ProductPrice);
            dataGridView1.DataSource = dataTable;
            
        }
    }
}
