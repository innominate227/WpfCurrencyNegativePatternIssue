using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var string1 = (-10).ToString("C2", new System.Globalization.CultureInfo("en-US"));
            var string2 = (-10).ToString("C2", System.Windows.Markup.XmlLanguage.GetLanguage("en-US").GetEquivalentCulture());

            var sb = new StringBuilder();
            sb.AppendLine($"CurrentCulture ={ Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyNegativePattern}.");
            sb.AppendLine($"CurrentUICulture={Thread.CurrentThread.CurrentUICulture.NumberFormat.CurrencyNegativePattern}.");
            sb.AppendLine($"\"{{-10:C0}}\" = {-10:C0}");
            sb.AppendLine($"(-10).ToString(\"C2\", new System.Globalization.CultureInfo(\"en-US\")) = {string1}");
            sb.AppendLine($"(-10).ToString(\"C2\", System.Windows.Markup.XmlLanguage.GetLanguage(\"en-US\").GetEquivalentCulture()) = {string2}");

            var message = sb.ToString();
            this.DataContext = new ViewModel() { Value = -10, Message = message };
        }

    }

    public class ViewModel
    {
        public double Value { get; set; }
        public string Message { get; set; }
    }
}
