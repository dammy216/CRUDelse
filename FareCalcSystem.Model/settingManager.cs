using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareCalcSystem.Model
{
    public class settingManager
    {
        private List<Settings> _settingList = new List<Settings>();
        public Settings[] SettingList { get { return _settingList.ToArray(); } }
        private static settingManager _instance;
        public Settings ResultSettings;
        public static settingManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new settingManager();
                }
                return _instance;
            }
        }

        public void AddSettings()
        {
            _settingList.Add(ResultSettings);
        }

        public void EditSettings(Settings settings)
        {
            var index = _settingList.FindIndex(item => item == settings);
            _settingList[index] = ResultSettings;
        }

        public void RemoveSettings(Settings settings)
        {
            var sameSetting = _settingList.FirstOrDefault(item => item == settings);
            _settingList.Remove(sameSetting);
        }

        public string[] GetSettingItems(Settings settings)
        {
            var startPlace = settings.StartPlace;
            var endPlace = settings.EndPlace;
            var price = settings.Price.ToString();

            string[] items = { startPlace, endPlace, price };
            return items;
        }
    }
}
