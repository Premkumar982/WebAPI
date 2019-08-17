using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI;
using WebAPI.Model;

namespace WindowsFormsApp1
{
    public partial class SunForm : Form
    {
        public SunForm()
        {
            InitializeComponent();
        }

        private async void GetSunData(object sender, EventArgs e)
        {
            SunProcessor objSunProcessor = new SunProcessor();
            SunModel objSunDetails =  await objSunProcessor.LoadSunData("","");
            lblSunRiseValue.Text = objSunDetails.Sunrise;
            lblSunSetValue.Text = objSunDetails.Sunset;
        }
    }
}
