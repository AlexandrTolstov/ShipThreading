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

namespace ShipThreading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            var Hleb10Ship = new Hleb10(GeneratorWrap);
            var Hleb50Ship = new Hleb50(GeneratorWrap);
            var Hleb100Ship = new Hleb100(GeneratorWrap);
            var Hleb10Ship1 = new Hleb10(GeneratorWrap);
            var Hleb100Ship2 = new Hleb100(GeneratorWrap);

            GeneratorWrap.Children.RemoveRange(0, 1);
        }
    }
}
