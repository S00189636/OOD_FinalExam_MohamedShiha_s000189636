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

namespace MohamadShiha_S00189636
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();

        //List<Phone> AllPhones;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from phone in db.Phones
                        select phone;

            PhoneslistBox.ItemsSource = query.ToList();
        }
        private void Phones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PhoneslistBox.SelectedIndex < 0) return;
            Phone SelectedPhone = PhoneslistBox.SelectedItem as Phone;

            PhonePriceTextBox.Text = String.Format("{0:c}", PhoneslistBox.SelectedValue);
            PhoneImage.Source = new BitmapImage(new Uri(SelectedPhone.Phone_Image, UriKind.Relative));
        }

    }
}
