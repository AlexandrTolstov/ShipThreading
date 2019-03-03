using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShipThreading.Ships
{
    public interface IShips
    {
        string Name { get; set; }
        int Volume { get; set; }
        Canvas Canvas1 { get;}
    }
}
