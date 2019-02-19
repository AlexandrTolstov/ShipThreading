using ShipThreading.Ships;
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

            Random rand = new Random();

            IShips[] Ships = new IShips[5];

            for (int i = 0; i < 5; i++)
            {
                if(rand.Next(1, 3) == 2)
                {
                    Ships[i] = new Hleb10(GeneratorWrap);
                }
                else
                {
                    Ships[i] = new Hleb50(GeneratorWrap);
                }
            }

            //var Hleb50Ship = new Hleb50(GeneratorWrap);
            //var Hleb100Ship = new Hleb100(GeneratorWrap);
            //var Hleb10Ship1 = new Hleb10(GeneratorWrap);
            //var Hleb100Ship2 = new Hleb100(GeneratorWrap);

            //var Banana10Ship = new Banana10(GeneratorWrap);
            //var Banana50Ship = new Banana50(GeneratorWrap);
            //var Banana100Ship = new Banana100(GeneratorWrap);

            //var Odejda10Ship = new Odejda10(GeneratorWrap);
            //var Odejda50Ship = new Odejda50(GeneratorWrap);
            //var Odejda100Ship = new Odejda100(GeneratorWrap);


        }
    }
}
