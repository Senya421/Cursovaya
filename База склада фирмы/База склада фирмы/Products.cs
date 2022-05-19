using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace База_склада_фирмы
{
    public partial class Products : Form
    {

        public string ProductName;
        public string ProductCharacteristic;
        public string Type;
        public double ProductPrice;


        public Products()
        {
            InitializeComponent();
            comboBox1.Items.Add("Процессор");
            comboBox1.Items.Add("Видеокарта");
            comboBox1.Items.Add("Материнская плата");
            comboBox1.Items.Add("Оперативная память");
            comboBox1.Items.Add("Корпус");
            comboBox1.Items.Add("Блок питания");
            comboBox1.Items.Add("Жесткий диск");
            comboBox1.Items.Add("SSD - накопитель");
            comboBox1.Items.Add("Охлаждение");

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductName = textBox1.Text;
            ProductCharacteristic = richTextBox1.Text;
            ProductPrice = Convert.ToDouble(textBox2.Text);
            //Type = Convert.ToString(comboBox1.Items.Add(Type));
            this.Close();
            
        }
    }
}
