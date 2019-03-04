using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Threading;
using System.Windows.Threading;

namespace ShipThreading.Ships
{
    public class GeneratorShips
    {
        private List<IShips> shipsGenerator;
        private WrapPanel wrap;

        public GeneratorShips(List<IShips> shipsGenerator, WrapPanel wrap)
        {
            this.shipsGenerator = shipsGenerator;
            this.wrap = wrap;
        }

        public void Generate()
        {
            Random rand = new Random();          
            IShips ships;

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            timer.Start(); //Выполняет через определенную выдержку времени действие
            timer.Tick += (sender, args) =>
            {
                if (shipsGenerator.Count < 13)
                {
                    int randNum = rand.Next(1, 10);
                    wrap.Children.Clear();//Очищает Wrap panel
                    switch (randNum)
                    {
                        case 1:
                            ships = new Banana10();
                            shipsGenerator.Add(ships);
                            break;
                        case 2:
                            ships = new Banana50();
                            shipsGenerator.Add(ships);
                            break;
                        case 3:
                            ships = new Banana100();
                            shipsGenerator.Add(ships);
                            break;
                        case 4:
                            ships = new Hleb10();
                            shipsGenerator.Add(ships);
                            break;
                        case 5:
                            ships = new Hleb50();
                            shipsGenerator.Add(ships);
                            break;
                        case 6:
                            ships = new Hleb100();
                            shipsGenerator.Add(ships);
                            break;
                        case 7:
                            ships = new Odejda10();
                            shipsGenerator.Add(ships);
                            break;
                        case 8:
                            ships = new Odejda50();
                            shipsGenerator.Add(ships);
                            break;
                        case 9:
                            ships = new Odejda100();
                            shipsGenerator.Add(ships);
                            break;
                    }
                    foreach (var item in shipsGenerator)//Добавляет все карабли из List<IShips> в Wrap panel
                    {
                        wrap.Children.Add(item.Canvas1);
                    }
                }
            };
        }
    }
}
