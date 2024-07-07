using FareCalcSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareCalcSystem
{
    public partial class addView : Form
    {
        private settingManager _instance = settingManager.Instance;
        public addView() :this(null)
        {
        }
        public addView(Settings settings)
        {
            InitializeComponent();
            if(settings == null) return;

            startPlaceTB.Text = settings.StartPlace.ToString();
            endPlaceTB.Text = settings.EndPlace.ToString();
            priceNB.Value = settings.Price;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var setting = new Settings(startPlaceTB.Text, endPlaceTB.Text, (int)priceNB.Value);
            _instance.ResultSettings = setting;
            DialogResult = DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
