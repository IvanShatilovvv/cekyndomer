using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private int counter = 0;
        private bool isCounting = false;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void ToggleCounting(object sender, RoutedEventArgs e)
        {
            if (isCounting)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
            isCounting = !isCounting;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            txtCounter.Text = counter.ToString();
            counter++;
        }
    }
}