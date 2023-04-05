using Microsoft.Win32;
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

namespace WpfApp1.Source
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        ClsOrder order = new ClsOrder();
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            order.PLAT = PLAT.Text;
            order.POL = POL.Text;
            order.SUM = Money.Text;

            ListBox.Items.Clear();
            ListBox.Items.Add(order.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            order.SaveToFile(saveFileDialog.FileName);
        }
        public Page1()
        {
            InitializeComponent();
        }
        public void POLBox(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= POLBox;
        }
        public void PLATBox(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= PLATBox;
        }
        public void MoneyBox(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= MoneyBox;
        }

    }
}
