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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(voda.Text);
                int p = int.Parse(vodp.Text);
                int n = 0;
               for (int i=a; i<=p; i++)
                {
                    stolb.Text +=  " " + i;
                    n++;

                }
                stolb1.Text += "N = " + n;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }   
    
}
