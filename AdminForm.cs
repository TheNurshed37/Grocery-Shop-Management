using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistrationForm
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerForm sf1 = new SellerForm();
            
            this.Hide();

            sf1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm pf1 = new ProductForm();

            this.Hide();

            pf1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryForm cf1 = new CategoryForm();

            this.Hide();

            cf1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f11 = new Form1();
            this.Hide();
            f11.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerForm cf32 = new CustomerForm();
            this.Hide();
            cf32.Show();
        }
    }
}
