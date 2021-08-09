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
        private void MoveSidePanel(Control c)
        {
            SidePanel.Height = c.Height;
            SidePanel.Top = c.Top;
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
            

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            /*
            Centers C1 = new Centers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            C1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage5.Controls.Clear();
            this.tabPage5.Controls.Add(C1);
            C1.Show();
            */
            
        }

        private void ScheduleBTN_Click(object sender, EventArgs e)
        {
            /*
            Forms.Shedule Sche1 = new Forms.Shedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Sche1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage6.Controls.Clear();
            this.tabPage6.Controls.Add(Sche1);
            Sche1.Show();
            */
            bunifuPages1.SetPage("SchedulePg");
            MoveSidePanel(ScheduleBTN);

            newTestvms.ScheduleF.SheduledData SD1 = new newTestvms.ScheduleF.SheduledData();


            SchedPanel.Controls.Clear();
            SD1.Dock = DockStyle.Fill;
            SchedPanel.Controls.Add(SD1);
            SD1.BringToFront();


        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void PeopleBTN_Click(object sender, EventArgs e)
        {
            //People Section


            WindowsFormsApp1.Form1 P1 = new WindowsFormsApp1.Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            P1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage2.Controls.Clear();
            this.tabPage2.Controls.Add(P1);
            P1.Show();
            bunifuPages1.SetPage("PeoplePg");
            MoveSidePanel(PeopleBTN);
        }

        private void VacPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            /*
            DashPalate DP1 = new DashPalate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DP1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage4.Controls.Clear();
            this.tabPage4.Controls.Add(DP1);
            DP1.Show();
            bunifuPages1.SetPage("DashboardPg");
            */

            
            bunifuPages1.SetPage("DashboardPg");
            MoveSidePanel(DashBTN);

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


        private void VCNowBTN_Click(object sender, EventArgs e)
        {

            newTestvms.Vaccination.VCNowCon VcnCOn = new newTestvms.Vaccination.VCNowCon() { Dock = DockStyle.Fill,  };
            addPanelC(VcnCOn);

        }

        private void StaffBTNClick(object sender, EventArgs e)
        {
            staff ST1 = new staff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ST1.FormBorderStyle = FormBorderStyle.None;
            this.tabPage3.Controls.Clear();
            this.tabPage3.Controls.Add(ST1);
            ST1.Show();
            bunifuPages1.SetPage("StaffPg");
            MoveSidePanel(StaffBTN);
        }
        private void addPanelC(UserControl uc)
        {

            panel4.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel4.Controls.Add(uc);
            uc.BringToFront();

        }
        private void addPanelCenter(UserControl uc)
        {

            CenterPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(uc);
            uc.BringToFront();

        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            //view list of vaccines
            newTestvms.VaccinationF.ViewListCon viewListCon = new newTestvms.VaccinationF.ViewListCon();
            addPanelC(viewListCon);
        }

        private void AddNewCenterBTNClick(object sender, EventArgs e)
        {
            newTestvms.Centers.addCenterControl AddnewCenterC1 = new newTestvms.Centers.addCenterControl();
            addPanelCenter(AddnewCenterC1);
        }

        private void DashBTN_Click(object sender, EventArgs e)
        {
            //this.tabPage4.Controls.Clear();
            bunifuPages1.SetPage("DashboardPg");
            MoveSidePanel(DashBTN);

        }

        private void VaccinationBTNClick(object sender, EventArgs e)
        {
            this.tabPage4.Controls.Remove(tabPage4);
            bunifuPages1.SetPage("VaccinationPg");
            MoveSidePanel(VaccinationBTN);
        }

        private void StocksBTN_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("StocksPg");
            MoveSidePanel(StocksBTN);
        }

        private void CenterBTN_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("CentersPg");
            MoveSidePanel(CenterBTN);
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MedEqStockBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void VacccineStockBTN_Click(object sender, EventArgs e)
        {
            newTestvms.Stocks.StockDashCon STV1 = new newTestvms.Stocks.StockDashCon();

            StocksPanel.Controls.Clear();
            STV1.Dock = DockStyle.Fill;
            StocksPanel.Controls.Add(STV1);
            STV1.BringToFront();
        }

        private void VcNextBTN_Click(object sender, EventArgs e)
        {
            this.tabPage4.Controls.Remove(tabPage4);
            bunifuPages1.SetPage("VaccinationPg");
            MoveSidePanel(VaccinationBTN);

            newTestvms.Vaccination.VCNowCon VcnCOn = new newTestvms.Vaccination.VCNowCon() { Dock = DockStyle.Fill, };
            addPanelC(VcnCOn);
        }

        private void SchedNewBTN_Click(object sender, EventArgs e)
        {
            


            newTestvms.ScheduleF.SchedNew SDN1 = new newTestvms.ScheduleF.SchedNew();

            SchedPanel.Controls.Clear();
            SDN1.Dock = DockStyle.Fill;
            SchedPanel.Controls.Add(SDN1);
            SDN1.BringToFront();

        }
    }
}
