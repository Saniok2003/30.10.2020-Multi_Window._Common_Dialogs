using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_10
{
    public partial class CreateProduct : Form
    {
        public Product Product { get; set; }
        public CreateProduct(Product Product)
        {
            InitializeComponent();
                this.Product = Product;
                checkBox1.Checked = false;
                button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter valid name!");
                return;
            }
            Product.Name = textBox1.Text;
            Product.Price = numericUpDown1.Value;
            Product.Amount = Convert.ToInt32(textBox2.Text);
            Product.Country = comboBox1.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }
    }
}
