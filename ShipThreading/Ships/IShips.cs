using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShipThreading.Ships
{
    public interface IShips
    {
        string Name { get; }
        int Volume { get; }
        Canvas Canvas1 { get; }
    }
}
