using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Northern =new string[] { "Jaffna", "Vavuniya", "Mannar" };

           
        }
        
        static Regex validate_emailaddress = email_validation();
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(textBox4.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox4.Focus();
                textBox4.Clear();

                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.ToString() == "Jaffna")
            {
                string[] jds = new string[] { "Delft","Island North","Island South","Jaffna","Karainagar","Nallur","Thenmaradchi","Vadamaradchi East","Vadamaradchi North","Vadamaradchi South-West","Valikamam East","Valikamam North","Valikamam South","Valikamam South-West","Valikamam West"};
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(jds);

            }
            if (comboBox2.Text.ToString() == "Vavuniya")
            {
                string[] vds = new string[] { "Vavuniya","Vavuniya North","Vavuniya South","Vengalacheddikulam"};
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(vds);
            }
            if (comboBox2.Text.ToString() == "Kilinochchi")
            {
                string[] kds = new string[] { "Kandavalai", "Karachchi", "Pachchilaipalli", "Poonakary" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(kds);
            }
            if (comboBox2.Text.ToString() == "Mannar")
            {
                string[] mds = new string[] { "Madhu", "Mannar", "Manthai West", "Musalai", "Nanaddan" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(mds);
            }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "Nothern Province")
            {
                string[] nothern = new string[] { "Jaffna", "Vavuniya", "Mannar", "Mullaithevu", "Kilinochi" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(nothern);

            }
            if (comboBox1.Text.ToString() == "Western Province")
            {
                string[] western = new string[] { "Colombo", "Gampaha", "Kalutara"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(western);

            }
            if (comboBox1.Text.ToString() == "Uva Province")
            {
                string[] uva = new string[] { "Baddulla", "Moneragala" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(uva);

            }
            if (comboBox1.Text.ToString() == "Central Province")
            {
                string[] central = new string[] { "Kandy", "Matale", "Nuwara Eliya" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(central);

            }
            if (comboBox1.Text.ToString() == "Eastern Province")
            {
                string[] Eastern= new string[] { "Ampara", "Baticaloa", "Trincomalee" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(Eastern);

            }
            if (comboBox1.Text.ToString() == "NorthCentral Province")
            {
                string[] NorthCentre = new string[] { "Anuradhapura", "Polannaruwa" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(NorthCentre);

            }
            if (comboBox1.Text.ToString() == "NorthWest Province")
            {
                string[] NorthWest = new string[] { "Kurunegala", "Puttalam" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(NorthWest);

            }
            if (comboBox1.Text.ToString() == "Sabaragamuwa Province")
            {
                string[] Sabaragamuwa = new string[] { "Kegalle", "Ratnapura" };
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(Sabaragamuwa);

            }
            if (comboBox1.Text.ToString() == "Southern Province")
            {
                string[] Southern = new string[] { "Galle", "Hambantota", "Matara"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(Southern);

            }



        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            maskedTextBox1.Select(0,0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.Date;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox2.Select(0, 0);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
