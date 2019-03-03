using ShipThreading.Ships;
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
using System.Windows.Threading;

namespace ShipThreading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<IShips> GenShips = new List<IShips>(); //Хранит карабли в генераторе
        List<IShips> TunelShips = new List<IShips>(); //Хранит карабли в тунели

        List<IShips> PrichalHlebShips = new List<IShips>(); //Хранит карабли в причале по погрузке хлеба
        List<IShips> PrichalBananShips = new List<IShips>(); //Хранит карабли в причале по погрузке бананов
        List<IShips> PrichalOdejdaShips = new List<IShips>(); //Хранит карабли в причале по погрузке Oдежды

        public bool startTriger = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerShip_Click(object sender, RoutedEventArgs e)
        {
            if (GenShips.Count < 13 && startTriger == false)
            {
                GeneratorShips generatorShips = new GeneratorShips(GenShips, GeneratorWrap);
                generatorShips.Generate();
            }

            TunelShips tunelShips = new TunelShips(GenShips, TunelShips, GeneratorWrap, TunelWrap);
            tunelShips.Generate();

            startTriger = true;
        }
    }
}
