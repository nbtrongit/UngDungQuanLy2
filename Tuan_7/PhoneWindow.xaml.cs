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

namespace Tuan_7
{
    /// <summary>
    /// Interaction logic for PhoneWindow.xaml
    /// </summary>
    public partial class PhoneWindow : Window
    {
        public PhoneWindow()
        {
            InitializeComponent();
        }
        class Phone
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public string Manufacturer { get; set; }
            public int Price { get; set; }
        }
        Phone _p;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _p = new Phone() 
            { 
                Name = "Điện thoại ZTE Blade V40 Vita",
                Image = "/Images/ztebladev40.png",
                Manufacturer = "ZTE",
                Price = 2790000
            };
            this.DataContext = _p;
        }
    }
}
