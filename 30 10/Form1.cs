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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Product> pro = new List<Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            CreateProduct form = new CreateProduct(product);
            form.Text = "Add Product";
            if (form.ShowDialog() == DialogResult.OK)
            {
                pro.Add(product);
                listBox1.Items.Add(product);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Product product = new Product();
                CreateProduct form = new CreateProduct(product);
                form.label1.Text = "Edit Product";
                form.button2.Text = "Edit";
                form.Text = "Edit Product";
                form.textBox1.Text = pro[listBox1.SelectedIndex].Name.ToString();
                form.textBox2.Text = pro[listBox1.SelectedIndex].Amount.ToString();
                form.comboBox1.Text = pro[listBox1.SelectedIndex].Country.ToString();
                form.numericUpDown1.Value = pro[listBox1.SelectedIndex].Price;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    pro[listBox1.SelectedIndex].Name = form.textBox1.Text;
                    pro[listBox1.SelectedIndex].Amount = Convert.ToInt32(form.textBox2.Text);
                    pro[listBox1.SelectedIndex].Country = form.comboBox1.Text;
                    pro[listBox1.SelectedIndex].Price = form.numericUpDown1.Value;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Add(product);
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Product product = new Product();
                CreateProduct form1 = new CreateProduct(product);
                form1.label1.Text = "Info Product";
                form1.button2.Text = "OK";
                form1.Text = "Info Product";
                form1.textBox1.Enabled = false;
                form1.textBox2.Enabled = false;
                form1.comboBox1.Enabled = false;
                form1.numericUpDown1.Enabled = false;
                form1.button2.Enabled = true;
                form1.checkBox1.Visible = false;
                form1.textBox1.Text = pro[listBox1.SelectedIndex].Name.ToString();
                form1.textBox2.Text = pro[listBox1.SelectedIndex].Amount.ToString();
                form1.comboBox1.Text = pro[listBox1.SelectedIndex].Country.ToString();
                form1.numericUpDown1.Value = pro[listBox1.SelectedIndex].Price;
                form1.ShowDialog();
            }
            
        }
    }
}
