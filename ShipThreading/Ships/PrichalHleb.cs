using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ShipThreading.Ships
{
    class PrichalHleb
    {
        private List<IShips> tunelGenerator;
        private List<IShips> prichalHleb;
        private WrapPanel tunWrap;
        private WrapPanel hlebWrap;

        private int indShip;

        public PrichalHleb(List<IShips> tunelGenerator, List<IShips> prichalHleb, WrapPanel tunWrap, WrapPanel hlebWrap)
        {
            this.tunelGenerator = tunelGenerator;
            this.prichalHleb = prichalHleb;
            this.tunWrap = tunWrap;
            this.hlebWrap = hlebWrap;
        }

        public void Generate()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            timer.Start(); //Выполняет через определенную выдержку времени действие
            timer.Tick += (sender, args) =>
            {
                if (tunelGenerator.Count > 0 && prichalHleb.Count < 1)
                {
                    tunWrap.Children.Clear();//Очищает tunWrap
                    hlebWrap.Children.Clear();//Очищает hlebWrap

                    indShip = 0;
                    foreach (var ship in tunelGenerator)
                    {
                        if (ship.Name == "Hleb")
                        {
                            prichalHleb.Add(ship); //Добовляем карабль из tunelGenerator в prichalHleb
                            tunelGenerator.RemoveAt(indShip); //Удаляем из tunelGenerator элемент по индексом indShip
                            break;
                        }
                        indShip += 1;
                    }

                    foreach (var item in tunelGenerator)//Добавляет все карабли из shipsGenerator в genWrap
                    {
                        tunWrap.Children.Add(item.Canvas1);
                    }
                    foreach (var item in prichalHleb)//Добавляет все карабли из tunelGenerator в genWrap
                    {
                        hlebWrap.Children.Add(item.Canvas1);
                    }
                }
                else if (prichalHleb.Count == 1)
                {
                    prichalHleb[0].Volume -= 10;

                    hlebWrap.Children.RemoveAt(0);//Очищает hlebWrap
                    hlebWrap.Children.Add(prichalHleb[0].Canvas1);

                    if (prichalHleb[0].Volume == 0)
                    {
                        prichalHleb.RemoveAt(0);
                        hlebWrap.Children.RemoveAt(0);
                    }
                }
            };
        }
    }
}
