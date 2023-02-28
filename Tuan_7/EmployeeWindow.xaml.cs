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
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }
        class Employee
        {
            public string Fullname { get; set; }
            public string Avatar { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string Telephone { get; set; }
        }

        Employee _e;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _e = new Employee()
            {
                Fullname = "Nguyễn Bảo Trọng",
                Avatar = "/Images/avatar2.png",
                Email = "trong.nb@garmex.vn",
                Address = "237 Phạm Văn Chiêu, P14, Q.Gò Vấp",
                Telephone = "0987830240"
            };
            this.DataContext = _e;
        }
    }
}
