using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ShipThreading.Ships
{
    public class TunelShips
    {
        private List<IShips> shipsGenerator;
        private List<IShips> tunelGenerator;
        private WrapPanel genWrap;
        private WrapPanel tunWrap;

        private int indShip;

        public TunelShips(List<IShips> shipsGenerator, List<IShips> tunelGenerator, WrapPanel genWrap, WrapPanel tunWrap)
        {
            this.shipsGenerator = shipsGenerator;
            this.tunelGenerator = tunelGenerator;
            this.genWrap = genWrap;
            this.tunWrap = tunWrap;
        }

        public void Generate()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };

            timer.Start(); //Выполняет через определенную выдержку времени действие
            timer.Tick += (sender, args) =>
            {
                if(shipsGenerator.Count > 0 && tunelGenerator.Count < 5)
                {
                    genWrap.Children.Clear();//Очищает genWrap
                    tunWrap.Children.Clear();//Очищает tunWrap

                    Random rand = new Random();
                    indShip = rand.Next(0, shipsGenerator.Count);

                    tunelGenerator.Add(shipsGenerator[indShip]); //Добовляем карабль из shipsGenerator в tunelGenerator
                    shipsGenerator.RemoveAt(indShip); //Удаляем из shipsGenerator элемент по индексом indShip

                    foreach (var item in shipsGenerator)//Добавляет все карабли из shipsGenerator в genWrap
                    {      
                        genWrap.Children.Add(item.Canvas1);
                    }

                    foreach (var item in tunelGenerator)//Добавляет все карабли из tunelGenerator в genWrap
                    {
                        tunWrap.Children.Add(item.Canvas1);
                    }
                }
            };
        }
    }
}
