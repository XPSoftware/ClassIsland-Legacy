using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Abstractions.Services.Management;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Controls;
using ClassIsland.Core.Controls.CommonDialog;
using ClassIsland.Core.Enums.SettingsWindow;
using ClassIsland.Helpers;
using ClassIsland.Models.AllContributors;
using ClassIsland.Services;
using ClassIsland.Services.Management;
using ClassIsland.ViewModels.SettingsPages;
using MaterialDesignThemes.Wpf;
using Microsoft.Extensions.Logging;
using Sentry;

namespace ClassIsland.Views.SettingPages
{
    /// <summary>
    /// ConnectionSettingsPage.xaml 的交互逻辑
    /// </summary>
    [SettingsPageInfo("connection", "连接", PackIconKind.LinkBoxVariantOutline, PackIconKind.LinkBoxVariant, SettingsPageCategory.Internal)]
    public partial class ConnectionSettingsPage : SettingsPageBase
    {
        public SettingsService SettingsService { get; set; }
        
        public IManagementService ManagementService { get; } = App.GetService<IManagementService>();

        public ConnectionSettingsPage(SettingsService settingsService)
        {
            InitializeComponent();
            SettingsService = settingsService;
            DataContext = this;
        }

        private void ButtonAgreeConnectionNotice_OnClick(object sender, RoutedEventArgs e)
        {
            SettingsService.Settings.IsConnectionWarningVisible = false;
        }
    }
}
