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
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        public BookWindow()
        {
            InitializeComponent();
        }
        class Book
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public string Author { get; set; }
            public int PublishedYear { get; set; }
        }
        Book _b;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _b = new Book()
            {
                Name = "The Lord Of The Rings - The Fellowship of the Ring",
                Image = "/Images/rings.jpg",
                Author = "J. R. R. Tolkien",
                PublishedYear = 1954
            };
            this.DataContext = _b;
        }
    }
}
