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
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AIS_Bank.WinForm
{
    /// <summary>
    /// Логика взаимодействия для ScreenLoad.xaml
    /// </summary>
    public partial class ScreenLoad : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        public ScreenLoad()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 1);
            dt.Start();
        }

        int startpoint = 0;

        private void dt_Tick(object sender, EventArgs e)
        {
            startpoint += 15;
            MyprogressBar.Value = startpoint;
            ProgresBar.Content = startpoint + "%";
            if (MyprogressBar.Value == 100)
            {
                MyprogressBar.Value = 0;
                dt.Stop();
                 Login LG = new Login();
                LG.Show();
                this.Close();
            }
        }
    }
}
