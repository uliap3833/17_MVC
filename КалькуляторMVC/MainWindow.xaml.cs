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

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.firstNumber = TBOXFirstNumber;
            Model.secondNumber = TBOXSecondNumber;
            Model.rav = TBLOCKRez;
            Model.sign = TBLOCKSign;
            CBOperation.ItemsSource = Model.SignList;
        }

        private void CBOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox CB = (ComboBox) sender;
            Model.SignChange = CB.SelectedIndex;
        }

        private void BCalculate_Click(object sender, RoutedEventArgs e)
        {
            Model.RAV = Model.firstN;
            Model.RAV = Model.secondN;
            TBLOCKRez.Text = Model.RAV + "";            
        }
    }
}
