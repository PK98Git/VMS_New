using System;
using System.Windows.Forms;


namespace VMS.Forms
{
    public partial class Dashboard : System.Windows.Forms.Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DashPalate DP1 = new DashPalate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DP1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage4.Controls.Clear();
            this.tabPage4.Controls.Add(DP1);
            DP1.Show();    
            bunifuPages1.SetPage("DashboardPg");
        }


        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {


        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            /*Vaccination VC1 = new Vaccination() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            VC1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage1.Controls.Add(VC1);
            VC1.Show();
            */


            // Vaccination VC1 = new Vaccination() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // VC1.FormBorderStyle = FormBorderStyle.None;
            //this.tabPage1.Controls.Add(VC1);
            //VC1.Show();
            //tabPage1.BringToFront();
            //this.tabPage1.Controls.Clear();
            this.tabPage4.Controls.Remove(tabPage4);
            
            bunifuPages1.SetPage("VaccinationPg");


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Centers C1 = new Centers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            C1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage5.Controls.Clear();
            this.tabPage5.Controls.Add(C1);
            C1.Show();
            bunifuPages1.SetPage("CentersPg");
        }

        private void ScheduleBTN_Click(object sender, EventArgs e)
        {
            
            Forms.Shedule Sche1 = new Forms.Shedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Sche1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage6.Controls.Clear();
            this.tabPage6.Controls.Add(Sche1);
            Sche1.Show();
            
            bunifuPages1.SetPage("SchedulePg");
            
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void PeopleBTN_Click(object sender, EventArgs e)
        {
            //People Section

            bunifuPages1.SetPage("peopleP");
        }

        private void VacPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            DashPalate DP1 = new DashPalate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DP1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage4.Controls.Clear();
            this.tabPage4.Controls.Add(DP1);
            DP1.Show();
            bunifuPages1.SetPage("DashboardPg");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            
            Forms.VCNow VCN = new Forms.VCNow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            VCN.FormBorderStyle = FormBorderStyle.None;
            this.tabPage1.Controls.Clear();
            this.tabPage1.Controls.Add(VCN);
            VCN.Show();
            //tabPage4.Show();
            
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Centers CE1 = new Centers();
            CE1.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void bunifuButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void VCNowBTN_Click(object sender, EventArgs e)
        {
            Forms.VCNow VCN = new Forms.VCNow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            VCN.FormBorderStyle = FormBorderStyle.None;
            this.tabPage1.Controls.Clear();
            this.tabPage1.Controls.Add(VCN);
            VCN.Show();
        }

        private void StaffBTNClick(object sender, EventArgs e)
        {
            staff ST1 = new staff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ST1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage3.Controls.Clear();
            this.tabPage3.Controls.Add(ST1);
            ST1.Show();
            bunifuPages1.SetPage("StaffPg");
        }
    }
}
