using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numCounter = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_B_Click(object sender, RoutedEventArgs e)
        {
            numCounter++;
            LV1.Items.Add(numCounter);
        }

        private void Del_B_Click(object sender, RoutedEventArgs e)
        {
            if (LV1.SelectedItems.Count > 0)
            {          
                var SelectedItems = LV1.SelectedItems.Cast<int>().ToList();
          
                foreach (var item in SelectedItems)
                {                 
                    LV1.Items.Remove(item); 
                }
            }

            else
            {
                MessageBox.Show("Элемент(ы) не выбраны");
            }

        }

        private void Clear_B_Click(object sender, RoutedEventArgs e)
        {
            LV1.Items.Clear();
            numCounter = -1;
        }
    }
}
