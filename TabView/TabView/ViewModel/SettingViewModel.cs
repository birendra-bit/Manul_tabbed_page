using System.Collections.Generic;
using TabView.Modal;

namespace TabView.ViewModel
{
    class SettingViewModel
    {
        public IList<SettingItems> settingItems { get; set; }
        public SettingViewModel()
        {
            settingItems = new List<SettingItems>();
            settingItems.Add(new SettingItems
            {
                Icon = "wifi.png",
                Title = "Wi-Fi",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "network.png",
                Title = "Mobile network",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "hotspot.png",
                Title = "Personal hotspot",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "setting.png",
                Title = "Bluetooth",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "notice.png",
                Title = "Status bar and notification",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "volume.png",
                Title = "Volume",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "brightness.png",
                Title = "Display and Brightness",
                Arrow = "arrow.png"
            });
            settingItems.Add(new SettingItems
            {
                Icon = "wallpaper.png",
                Title = "Wallpapers and Fonts",
                Arrow = "arrow.png"
            });
        }
    }
}
