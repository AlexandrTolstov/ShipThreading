using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ShipThreading.Ships
{
    public static class ShipOperate
    {
        public static void GenShip(List<IShips> ships, WrapPanel wrap)
        {
            ships.Add(new Hleb50(wrap));
            ships.Add(new Hleb100(wrap));
        }
    }
}
