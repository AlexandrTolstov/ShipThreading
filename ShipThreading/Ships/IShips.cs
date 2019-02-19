using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShipThreading.Ships
{
    interface IShips
    {
        void GenShip(WrapPanel wrap);
        int typeShip { get; }
    }
}
