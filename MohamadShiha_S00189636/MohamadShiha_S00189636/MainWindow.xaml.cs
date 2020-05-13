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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // will get all phones 
            var query = from phone in db.Phones
                        select phone;

            // populate the list box with all phones 
            PhoneslistBox.ItemsSource = query.ToList();
        }
        private void Phones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // this will check if the selection is not null 
            if (PhoneslistBox.SelectedIndex < 0) return;
            // get the selected phone
            Phone SelectedPhone = PhoneslistBox.SelectedItem as Phone;
            // get the price from the value 
            PhonePriceTextBox.Text = String.Format("{0:c}", PhoneslistBox.SelectedValue);
            // get the image from the selected phone 
            PhoneImage.Source = new BitmapImage(new Uri(SelectedPhone.Phone_Image, UriKind.Relative));
        }

    }
}
