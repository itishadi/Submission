using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simulerad_Iot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Task.WhenAll(TogglePhoneCallStateAsync());
        }

        private async Task TogglePhoneCallStateAsync()
        {
            Storyboard phoneCall = (Storyboard)this.FindResource("PhoneStoryboard");
            while(true)
            {
                phoneCall.Begin();
                await Task.Delay(1000);
            }
        }
    }
}
