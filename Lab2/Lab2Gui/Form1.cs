using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;
using Lab2App;
using Lab2Gui;
using Microsoft.VisualBasic.Logging;
namespace Lab2

{
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;
        private string fraze = "";
        private string deviceType = "";
        private string platform = "";
        private string type = "";
        private DateTime dateTime = new DateTime();
        private bool onlyActive = false;
        private RadioButton selectedDevice;

        public Form1()
        {
            InitializeComponent();
            this.Load += async (sender, e) => await InitializeAsync();
        }

        private void clearButton_click(object sender, EventArgs e)
        {

            resetChoices();
            resetValues();
            Deals_list.Controls.Clear();
        }

        private void searchButton_click(object sender, EventArgs e)
        {
            string fraze = frazeBox.Text;
            DateTime dateTime = DateCheckBoxValue();
            bool onlyActive = Only_active.Checked;

            foreach (var control in deviceTypeBox.Controls)
            {
                if (control is RadioButton radio)
                {
                    if (radio.Checked)
                    {
                       deviceType = radio.Text;
                    }
                }
            }

            LoadDealsList(dbManager.QueryDeals(fraze, deviceType, platform, type, dateTime, onlyActive));
            resetValues();
            resetChoices();
        }


        private void device_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            selectedDevice = radioButton;
            InitializePlatformBox();
        }

        private void resetValues() { 
            fraze = "";
            deviceType = "";
            platform = "";
            type = "";
            dateTime = new DateTime();
            onlyActive = false;
        }

        private void resetChoices()
        {
            frazeBox.Text = "";

            foreach (var control in deviceTypeBox.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }

            foreach (var control in dateBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            
            platformBox.SelectedIndex = -1;
            giveawayBox.SelectedIndex = -1;

            Only_active.Checked = false;
        }

        private void InitializePlatformBox()
        {
            platformBox.Enabled = !selectedDevice.Text.Equals("VR");
            platformBox.Items.Clear();

            if (selectedDevice.Text.Equals("PC")){
                foreach (var platform in PlatformSingleton.Instance.PcPlatforms)
                {
                    platformBox.Items.Add(platform);
                }
            }

            if(selectedDevice.Text.Equals("Mobile"))
            {
                foreach (var platform in PlatformSingleton.Instance.MobilePlatforms)
                {
                    platformBox.Items.Add(platform);
                }
            }

            if(selectedDevice.Text.Equals("Console"))
            {
                foreach (var platform in PlatformSingleton.Instance.ConsolePlatforms)
                {
                    platformBox.Items.Add(platform);
                }
            }

        }

        private void InitializeTypeBox()
        {
            foreach (var type in PlatformSingleton.Instance.DealType)
            {
                giveawayBox.Items.Add(type);
            }
        }


        private async Task InitializeDealsListAsync()
        {
            List<Deal> deals = dbManager.getAll();

            foreach (var deal in deals)
            {
                UserControl1 userControl = new UserControl1(deal);
                Deals_list.Controls.Add(userControl);
            }
        }

        private void LoadDealsList(List<Deal> deals)
        {
            Deals_list.Controls.Clear(); 
            foreach (var deal in deals)
            {
                UserControl1 userControl = new UserControl1(deal); 

                Deals_list.Controls.Add(userControl);
            }
        }

        private async Task InitializeAsync()
        {
            dbManager = await DatabaseManager.InitializeAsync();
            await InitializeDealsListAsync();
            InitializeTypeBox();
        }

        private DateTime DateCheckBoxValue()
        {
            if(Today_radio.Checked)
            {
                return DateTime.Today;
            }
            else if(Yestarday_radio.Checked)
            {
                return DateTime.Today.Date.AddDays(-1);
            }
            else if(Week_radio.Checked)
            {
                return DateTime.Today.Date.AddDays(-7);
            }
            else if(Month_radio.Checked)
            {
                return DateTime.Today.Date.AddMonths(-1);
            }
            else
            {
                return new DateTime();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void givewaytype_label_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

 

        private void fraze_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
