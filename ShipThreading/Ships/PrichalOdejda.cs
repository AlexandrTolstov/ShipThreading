using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ShipThreading.Ships
{
    class PrichalOdejda
    {
        private List<IShips> tunelGenerator;
        private List<IShips> prichalOdejda;
        private WrapPanel tunWrap;
        private WrapPanel odejdaWrap;

        private int indShip;

        public PrichalOdejda(List<IShips> tunelGenerator, List<IShips> prichalOdejda, WrapPanel tunWrap, WrapPanel odejdaWrap)
        {
            this.tunelGenerator = tunelGenerator;
            this.prichalOdejda = prichalOdejda;
            this.tunWrap = tunWrap;
            this.odejdaWrap = odejdaWrap;
        }

        public void Generate()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            timer.Start(); //Выполняет через определенную выдержку времени действие
            timer.Tick += (sender, args) =>
            {
                if (tunelGenerator.Count > 0 && prichalOdejda.Count < 1)
                {
                    tunWrap.Children.Clear();//Очищает tunWrap
                    odejdaWrap.Children.Clear();//Очищает bananaWrap

                    indShip = 0;
                    foreach (var ship in tunelGenerator)
                    {
                        if (ship.Name == "Odejda")
                        {
                            prichalOdejda.Add(ship); //Добовляем карабль из tunelGenerator в prichalHleb
                            tunelGenerator.RemoveAt(indShip); //Удаляем из tunelGenerator элемент по индексом indShip
                            break;
                        }
                        indShip += 1;
                    }

                    foreach (var item in tunelGenerator)//Добавляет все карабли из shipsGenerator в genWrap
                    {
                        tunWrap.Children.Add(item.Canvas1);
                    }
                    foreach (var item in prichalOdejda)//Добавляет все карабли из tunelGenerator в genWrap
                    {
                        odejdaWrap.Children.Add(item.Canvas1);
                    }
                }
                else if (prichalOdejda.Count == 1)
                {
                    prichalOdejda[0].Volume -= 1;

                    odejdaWrap.Children.RemoveAt(0);//Очищает hlebWrap
                    odejdaWrap.Children.Add(prichalOdejda[0].Canvas1);

                    if (prichalOdejda[0].Volume == 0)
                    {
                        prichalOdejda.RemoveAt(0);
                        odejdaWrap.Children.RemoveAt(0);
                    }
                }
            };
        }
    }
}
