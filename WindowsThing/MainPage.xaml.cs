using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using System.Linq;

namespace WindowsThing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var processGroups = Process.GetProcesses()
                .Select(x => new ProcessData { Name = x.ProcessName, Pid = x.Id })
                .GroupBy(x => x.Name, x => x, (key, g) => new ProcessGroupData { Name = key, Processes = g.ToList() })
                .OrderBy(x => x.Name);

            BaseExample.ItemsSource = processGroups;

            var h = Process.GetProcesses().Where(x => x.ProcessName == "WinUIGallery.DesktopWap").ToList();

            foreach (var h2 in h)
            {
                h2.Kill();
            }
        }
    }
}
