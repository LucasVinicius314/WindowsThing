using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using System.Linq;

namespace WindowsThing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();

            var processes = Process.GetProcesses().Select(x => new ProcessData { Name = x.ProcessName });

            BaseExample.ItemsSource = processes;
        }
    }
}
