using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginAndRegistrationForm
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            SellerDGV.CellContentClick += SellerDGV_CellContentClick;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\L\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void TbFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" + SellerIdTB.Text + ",'" + SellerNameTB.Text + "'," + SellerAgeTB.Text + ",'" + SellerPhoneTB.Text + "','" + SellerPasswordTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Con.Close();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            SellerIdTB.Text = "";
            SellerNameTB.Text = "";
            SellerAgeTB.Text = "";
            SellerPhoneTB.Text = "";
            SellerPasswordTB.Text = "";
        }
        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SellerDGV.Rows[e.RowIndex];

                // Set the values of the selected row to the textboxes
                SellerIdTB.Text = row.Cells["Sellerid"].Value.ToString();
                SellerNameTB.Text = row.Cells["SellerName"].Value.ToString();
                SellerAgeTB.Text = row.Cells["SellerAge"].Value.ToString();
                SellerPhoneTB.Text = row.Cells["SellerPhone"].Value.ToString();
                SellerPasswordTB.Text = row.Cells["SellerPass"].Value.ToString();
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "UPDATE SellerTbl SET SellerName=@SellerName, SellerAge=@SellerAge, SellerPhone=@SellerPhone, SellerPass=@SellerPass WHERE Sellerid=@Sellerid";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Sellerid", SellerIdTB.Text);
                cmd.Parameters.AddWithValue("@SellerName", SellerNameTB.Text);
                cmd.Parameters.AddWithValue("@SellerAge", SellerAgeTB.Text);
                cmd.Parameters.AddWithValue("@SellerPhone", SellerPhoneTB.Text);
                cmd.Parameters.AddWithValue("@SellerPass", SellerPasswordTB.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Information Updated Successfully");
                Con.Close();

                populate(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
           
                try
                {
                    // Check if a row is selected
                    if (SellerDGV.SelectedRows.Count > 0)
                    {
                        // Get the selected row
                        DataGridViewRow selectedRow = SellerDGV.SelectedRows[0];
                        int sellerId = Convert.ToInt32(selectedRow.Cells["Sellerid"].Value);

                        // Open the connection
                        Con.Open();

                        // Delete the row from the database
                        string query = "DELETE FROM SellerTbl WHERE Sellerid = @Sellerid";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Sellerid", sellerId);
                        cmd.ExecuteNonQuery();

                        // Close the connection
                        Con.Close();

                        // Remove the selected row from the DataGridView
                        SellerDGV.Rows.Remove(selectedRow);

                        MessageBox.Show("Seller Information Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Select a seller to delete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SellerPasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                        AdminForm ad = new AdminForm();
                        this.Hide();
                        ad.Show();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            this.Hide();
            ad.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from SellerTbl where Sellerid Like '%" + SearchTB.Text + "%'", Con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            SellerDGV.DataSource = dt;
        }
    }
}
