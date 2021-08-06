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

namespace VMS
{
    public partial class doctor : UserControl
    {

        newTestvms.dbconnection db = new newTestvms.dbconnection();

        public doctor()
        {
            InitializeComponent();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private bool checkEmpty()
        {
            if (maskedTextBox1.Text == "" || bunifuCustomTextbox8.Text == "" || bunifuCustomTextbox2.Text == "" || bunifuCustomTextbox6.Text == "" || richTextBox1.Text == "" || richTextBox2.Text == "" || bunifuCustomTextbox3.Text == "" || maskedTextBox2.Text == "" || bunifuCustomTextbox5.Text == "")
            {
                return true;

            }
            return false;

        }

        private void resetData()
        {
            maskedTextBox1.Text = "";
            bunifuCustomTextbox8.Text = "";
            bunifuCustomTextbox2.Text = "";
            bunifuCustomTextbox6.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            bunifuRadioButton1.Checked = true;
            bunifuRadioButton2.Checked = false;
            bunifuCustomTextbox3.Text = "";
            bunifuDatepicker1.Value = DateTime.Today;
            maskedTextBox2.Text = "";
            bunifuCustomTextbox5.Text = "";

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection("Data Source=DESKTOP-PVBM0T3\\SQLEXPRESS; Initial Catalog=VMS;Integrated Security=true;");
             SqlCommand cmd;
             SqlDataAdapter adapt;
             //ID variable used in Updating and Deleting Record  
             int ID = 0;*/

            // newTestvms.dbconnection db1 = new newTestvms.dbconnection();

            
            if (checkEmpty() == false)
            {

                string gender;
                if (bunifuRadioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("Insert into doctor(d_id, slmc_no, f_name, l_name, qualification, address, gender, nic, dob, phoneno, email)  values(@d_id, @slmc_no, @f_name, @l_name, @qualification, @address, @gender, @nic, @dob, @phoneno, @email)");



                    //cmd = new SqlCommand("Insert into doctor (d_id,slmc_no,f_name,l_name,qualification,address,gender,nic,dob,phoneno,email)  values(@d_id,@slmc_no,@f_name,@l_name,@qualification,@address,@gender,@nic,@dob,@phoneno,@email)", con);
                    // con.Open();
                    cmd.Parameters.AddWithValue("@d_id", maskedTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@slmc_no", bunifuCustomTextbox8.Text.ToString());
                    cmd.Parameters.AddWithValue("@f_name", bunifuCustomTextbox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@l_name", bunifuCustomTextbox6.Text.ToString());
                    cmd.Parameters.AddWithValue("@qualification", richTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@address", richTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@nic", bunifuCustomTextbox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@dob", bunifuDatepicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phoneno", maskedTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", bunifuCustomTextbox5.Text.ToString());


                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from doctor");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doctor_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from doctor");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {


            if (checkEmpty() == false)
            {
                string gender;
                if (bunifuRadioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("update doctor set d_id=@d_id, slmc_no=@slmc_no, f_name=@f_name, l_name=@l_name, qualification=@qualification, address=@address, gender=@gender, nic=@nic, dob=@dob, phoneno=@phoneno, email=@email where d_id=@d_id");



                    //cmd = new SqlCommand("Insert into doctor (d_id,slmc_no,f_name,l_name,qualification,address,gender,nic,dob,phoneno,email)  values(@d_id,@slmc_no,@f_name,@l_name,@qualification,@address,@gender,@nic,@dob,@phoneno,@email)", con);
                    // con.Open();
                    cmd.Parameters.AddWithValue("@d_id", maskedTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@slmc_no", bunifuCustomTextbox8.Text.ToString());
                    cmd.Parameters.AddWithValue("@f_name", bunifuCustomTextbox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@l_name", bunifuCustomTextbox6.Text.ToString());
                    cmd.Parameters.AddWithValue("@qualification", richTextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@address", richTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@nic", bunifuCustomTextbox3.Text.ToString());
                    cmd.Parameters.AddWithValue("@dob", bunifuDatepicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phoneno", maskedTextBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", bunifuCustomTextbox5.Text.ToString());


                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Updated Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from doctor");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = bunifuDataGridView1.CurrentRow.Cells["d_id"].Value.ToString();
            bunifuCustomTextbox8.Text = bunifuDataGridView1.CurrentRow.Cells["slmc_no"].Value.ToString();
            bunifuCustomTextbox2.Text = bunifuDataGridView1.CurrentRow.Cells["f_name"].Value.ToString();
            bunifuCustomTextbox6.Text = bunifuDataGridView1.CurrentRow.Cells["l_name"].Value.ToString();
            richTextBox1.Text = bunifuDataGridView1.CurrentRow.Cells["qualification"].Value.ToString();
            richTextBox2.Text = bunifuDataGridView1.CurrentRow.Cells["address"].Value.ToString();
            if (bunifuDataGridView1.CurrentRow.Cells["gender"].Value.ToString() == "Male")
            {
                bunifuRadioButton1.Checked = true;
                bunifuRadioButton2.Checked = false;

            }
            else
            {
                bunifuRadioButton2.Checked = true;
                bunifuRadioButton1.Checked = false;
            }

            bunifuCustomTextbox3.Text = bunifuDataGridView1.CurrentRow.Cells["nic"].Value.ToString();
            bunifuDatepicker1.Text = bunifuDataGridView1.CurrentRow.Cells["dob"].Value.ToString();
            maskedTextBox2.Text = bunifuDataGridView1.CurrentRow.Cells["phoneno"].Value.ToString();
            bunifuCustomTextbox5.Text = bunifuDataGridView1.CurrentRow.Cells["email"].Value.ToString();
      
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "DR_")
            {

                try
                {

                    SqlCommand cmd = db.ExecuteQueries("delete doctor where d_id=@d_id");

                    cmd.Parameters.AddWithValue("@d_id", maskedTextBox1.Text.ToString());
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();

                    DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    bunifuDataGridView1.DataSource = db.ShowDataInGridView("select * from doctor");
                    resetData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Selct the record to be deleted from the table", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
