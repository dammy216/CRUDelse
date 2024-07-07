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
    public partial class CustomerView : Form
    {
        private settingManager _instance = settingManager.Instance;
        public CustomerView()
        {
            InitializeComponent();
            InitializeCB();
        }

        private void InitializeCB()
        {
            startPlaceCB.Items.AddRange(_instance.SettingList.Select(item => item.StartPlace).ToArray());
            endPlaceCB.Items.AddRange(_instance.SettingList.Select(item => item.EndPlace).ToArray());
        }

        private void changePrice(object sender, EventArgs e)
        {
            string startPlace = startPlaceCB.SelectedItem?.ToString();
            string endPlace = endPlaceCB.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(startPlace) || string.IsNullOrEmpty(endPlace))
            {
                priceLabel.Text = "運賃が設定されていません";
                return;
            }

            var selectedFare = _instance.SettingList.FirstOrDefault(item => item.StartPlace == startPlace && item.EndPlace == endPlace);

            if (selectedFare != null)
            {
                priceLabel.Text = $"{selectedFare.Price}円";
            }
            else
            {
                priceLabel.Text = "運賃が設定されていません";
            }
        }
    }
}
