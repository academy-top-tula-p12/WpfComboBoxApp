using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfComboBoxApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> cities = new()
        {
            "Москва", "Тула", "Новосибирск", "Туапсе", "Моршанск", "Иркутск", "Новгород"
        };

        public MainWindow()
        {
            InitializeComponent();
            comboCites.ItemsSource = cities;
            comboCites.StaysOpenOnEdit = true;
            comboCites.IsReadOnly = true;

            TabItem tabForm = new TabItem();
            var header = new StackPanel() { Orientation = Orientation.Horizontal };
            tabForm.Header = header;
            header.Children.Add(new Image() 
            { 
                Source = new BitmapImage(new Uri(@"D:\icon1.png")),
                Width = 30
            });
            header.Children.Add(new TextBlock() { Text = "Form" });

            StackPanel stack = new() { Orientation = Orientation.Vertical };
            tabForm.Content = stack;

            stack.Children.Add(new TextBlock() { Text = "login:" });
            stack.Children.Add(new TextBox());
            stack.Children.Add(new TextBlock() { Text = "password:" });
            stack.Children.Add(new TextBox());
            stack.Children.Add(new Button() { Content = "Click me" });

            tabs.Items.Add(tabForm);
        }
    }
}