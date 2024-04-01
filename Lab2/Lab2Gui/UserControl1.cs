using Lab2App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Gui
{
    public partial class UserControl1 : UserControl
    {
        private Deal deal;
        public UserControl1(Deal d)
        {
            this.deal = d;
            InitializeComponent();
            pictureBox1.ImageLocation = deal.thumbnail;
            title.Text = deal.title;
            published_date.Text = "Publication date: "+deal.publicationDateString;
            end_date.Text = "End date: "+deal.endDateString;
            devices_list.Text = string.Join(", ", deal.device);
            platforms_list.Text = string.Join(", ", deal.platform);
            description_text.Text = deal.description;
            instruction_text.Text = deal.instructions;
        }


        private void event_button_Click(object sender, EventArgs e)
        {
            try {
                Process.Start(new ProcessStartInfo
                {
                    FileName = deal.url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie można otworzyć URL: {ex.Message}");
            }
        }

    }
}
