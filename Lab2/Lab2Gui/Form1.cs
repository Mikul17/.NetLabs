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
        private DateTime dateTime;
        private bool onlyActive;
        private RadioButton selectedDevice;
        private RadioButton selectedDate;
        private int currentPage = 1;
        private int pageSize = 10;
        private long maxPages = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += async (sender, e) => await InitializeAsync();
        }
        private async void clearButton_click(object sender, EventArgs e)
        {
            resetChoices();
            resetValues();
            LoadDealsList(await dbManager.QueryDeals(fraze, deviceType, platform, type, dateTime, onlyActive, currentPage, pageSize));
            currentPage = 1;
            await UpdatePageLabel();
        }
        private async void searchButton_click(object sender, EventArgs e)
        {
            fraze = frazeBox.Text;
            deviceType = selectedDevice==null ? "" : selectedDevice.Text;
            platform = platformBox.Text;
            type = giveawayBox.Text == string.Empty ? "" : giveawayBox.Text;
            dateTime = DateCheckBoxValue();
            onlyActive = Only_active.Checked;
            
            
            
            currentPage = 1;
            await UpdatePageLabel();
            LoadDealsList(await dbManager.QueryDeals(fraze, deviceType, platform, type, dateTime, onlyActive, currentPage, pageSize));
            resetChoices();
            previous_page_button.Enabled = false;
            next_page_button.Enabled = currentPage < maxPages;
        }
        private void device_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            selectedDevice = radioButton;
            InitializePlatformBox();
        }
        private void date_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            selectedDate = radioButton;
        }
        private void resetValues() { 
            fraze = "";
            deviceType = "";
            platform = "";
            type = "";
            dateTime = new DateTime();
            onlyActive = false;
            selectedDate = null;
            selectedDevice = null;
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
            platformBox.Text = "";
            giveawayBox.Text = "";
            

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
            List<Deal> deals = await dbManager.queryPage(currentPage,pageSize);

            foreach (var deal in deals)
            {
                UserControl1 userControl = new UserControl1(deal);
                Deals_list.Controls.Add(userControl);
            }
        }
        private void LoadDealsList(List<Deal> deals)
        {
            Deals_list.SuspendLayout();
            Deals_list.Controls.Clear();
            foreach (var deal in deals)
            {
                UserControl1 userControl = new UserControl1(deal);
                Deals_list.Controls.Add(userControl);
            }
            Deals_list.ResumeLayout();
        }
        private async Task InitializeAsync()
        {
            dbManager = await DatabaseManager.InitializeAsync();
            await InitializeDealsListAsync();
            InitializeTypeBox();
            await CalculateTotalPagesAsync();
            await UpdatePageLabel();
        }
        private DateTime DateCheckBoxValue()
        {
            if (selectedDate == null)
            {
                return new DateTime();
            }
            switch (selectedDate.Name)
            {
                case nameof(Today_radio):
                    return DateTime.Today;
                case nameof(Yestarday_radio):
                    return DateTime.Today.AddDays(-1);
                case nameof(Week_radio):
                    return DateTime.Today.AddDays(-7);
                case nameof(Month_radio):
                    return DateTime.Today.AddMonths(-1);
                default:
                    return new DateTime();
            }
        }
        private async void NextPageButtonClick(object sender, EventArgs e)
        {
            if (currentPage < maxPages)
            {
                currentPage++;
                await FetchAndDisplayDeals();
                await UpdatePageLabel();
            }
        }
        private async void PrevPageButtonClick(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await FetchAndDisplayDeals();
                await UpdatePageLabel();
            }
        }
        private async Task FetchAndDisplayDeals()
        {
            List<Deal> deals = await dbManager.QueryDeals(fraze, deviceType, platform, type, dateTime, onlyActive, currentPage, pageSize);
            LoadDealsList(deals);
        }
        private async Task<int> CalculateTotalPagesAsync()
        {
            var totalCount = await Task.Run(() => dbManager.CountFilteredDeals(fraze, deviceType, platform, type, dateTime, onlyActive));
            maxPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (maxPages==0)
            {
                maxPages = 1;
            }
            return 1;
        }
        private async Task UpdatePageLabel()
        {
            await CalculateTotalPagesAsync();
            page_counter.Text = $"{currentPage}/{maxPages}";
            previous_page_button.Enabled = currentPage > 1;
            next_page_button.Enabled = currentPage < maxPages;
        }
    }
}
