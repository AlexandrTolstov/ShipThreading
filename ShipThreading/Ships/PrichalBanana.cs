using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ShipThreading.Ships
{
    class PrichalBanana
    {
        private List<IShips> tunelGenerator;
        private List<IShips> prichalBanana;
        private WrapPanel tunWrap;
        private WrapPanel bananaWrap;

        private int indShip;

        public PrichalBanana(List<IShips> tunelGenerator, List<IShips> prichalBanana, WrapPanel tunWrap, WrapPanel bananaWrap)
        {
            this.tunelGenerator = tunelGenerator;
            this.prichalBanana = prichalBanana;
            this.tunWrap = tunWrap;
            this.bananaWrap = bananaWrap;
        }

        public void Generate()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            timer.Start(); //Выполняет через определенную выдержку времени действие
            timer.Tick += (sender, args) =>
            {
                if (tunelGenerator.Count > 0 && prichalBanana.Count < 1)
                {
                    tunWrap.Children.Clear();//Очищает tunWrap
                    bananaWrap.Children.Clear();//Очищает bananaWrap

                    Random rand = new Random();
                    indShip = rand.Next(0, tunelGenerator.Count);

                    if (tunelGenerator[indShip].Name == "Banana")
                    {
                        prichalBanana.Add(tunelGenerator[indShip]); //Добовляем карабль из tunelGenerator в prichalHleb
                        tunelGenerator.RemoveAt(indShip); //Удаляем из tunelGenerator элемент по индексом indShip
                    }

                    foreach (var item in tunelGenerator)//Добавляет все карабли из shipsGenerator в genWrap
                    {
                        tunWrap.Children.Add(item.Canvas1);
                    }
                    foreach (var item in prichalBanana)//Добавляет все карабли из tunelGenerator в genWrap
                    {
                        bananaWrap.Children.Add(item.Canvas1);
                    }
                }
                else if (prichalBanana.Count == 1)
                {
                    prichalBanana[0].Volume -= 1;

                    bananaWrap.Children.RemoveAt(0);//Очищает hlebWrap
                    bananaWrap.Children.Add(prichalBanana[0].Canvas1);

                    if (prichalBanana[0].Volume == 0)
                    {
                        prichalBanana.RemoveAt(0);
                        bananaWrap.Children.RemoveAt(0);
                    }
                }
            };
        }
    }
}
