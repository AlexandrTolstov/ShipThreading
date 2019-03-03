using ShipThreading.Ships;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShipThreading
{
    class Hleb50 : IShips
    {
        string IShips.Name { get => "Hleb"; }
        int IShips.Volume { get => 50; }
        Canvas IShips.Canvas1
        {
            get
            {
                var Canvas1 = new Canvas
                {
                    Width = 80 * 0.8,
                    Height = 60 * 0.8,
                    Margin = new Thickness(20.0)
                };

                var Path1 = new Path
                {
                    Width = 114.808,
                    Margin = new Thickness(0.0, 23.9028, 0.0, 0.0),
                    Height = 38.2827,
                    Stretch = Stretch.Fill,
                    StrokeLineJoin = PenLineJoin.Round,
                    Stroke = new SolidColorBrush(Color.FromRgb(r: 0, g: 0, b: 0)),
                    Fill = new SolidColorBrush(Color.FromRgb(r: 238, g: 145, b: 145)),
                    Data = Geometry.Parse("F1 M 9.10177,61.6855L 93.1344,61.6855L 114.308,24.4028L 75.9308,28.8767L 76.5925,35.5876L 0.5,35.5876L 9.10177,61.6855 Z ")
                };
                var Path2 = new Path
                {
                    Width = 12.469,
                    Margin = new Thickness(18.4382, 0.0, 0.0, 40.0),
                    Height = 36.0458,
                    Stretch = Stretch.Fill,
                    StrokeLineJoin = PenLineJoin.Round,
                    Stroke = new SolidColorBrush(Color.FromRgb(r: 0, g: 0, b: 0)),
                    Fill = new SolidColorBrush(Color.FromRgb(r: 238, g: 145, b: 145)),
                    Data = Geometry.Parse("F1 M 18.9382,35.5458L 18.9382,21.1919L 24.0661,21.1919L 24.0661,12.6169L 29.5249,12.6169L 29.5249,0.5L 30.352,0.5L 30.4072,35.4837L 18.9382,35.5458 Z ")
                };
                Canvas1.Children.Add(Path1);
                Canvas1.Children.Add(Path2);

                /*Уменьшаем немного массштаб караблика*/
                ScaleTransform st = new ScaleTransform();
                st.ScaleX = 0.7;
                st.ScaleY = 0.7;
                Canvas1.RenderTransform = st;

                return Canvas1;
            }
        }
    }
}
