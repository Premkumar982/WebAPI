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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetComicImage(object sender, EventArgs e)
        {
            ComicProcessor objProcessComicData = new ComicProcessor();
            var image = await objProcessComicData.LoadComicImages();
            picComicImage.ImageLocation = image.Img;
        }

        private void RedirectToSun(object sender, EventArgs e)
        {
            SunForm sform = new SunForm();
            sform.Show();
        }
    }
}
