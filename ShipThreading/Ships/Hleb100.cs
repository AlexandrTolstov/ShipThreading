using ShipThreading.Ships;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShipThreading
{
    class Hleb100 : IShips
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public Hleb100()
        {
            Name = "Hleb";
            Volume = 100;
        }
        Canvas IShips.Canvas1
        {
            get
            {
                var Canvas1 = new Canvas
                {
                    Width = 120 * 0.8,
                    Height = 60 * 0.8,
                    Margin = new Thickness(20.0)
                };

                var Path1 = new Path
                {
                    Width = 151.914,
                    Margin = new Thickness(0, 34.9417, 0.0, 0.0),
                    Height = 55.5009,
                    Stretch = Stretch.Fill,
                    StrokeLineJoin = PenLineJoin.Round,
                    Stroke = new SolidColorBrush(Color.FromRgb(r: 0, g: 0, b: 0)),
                    Fill = new SolidColorBrush(Color.FromRgb(r: 238, g: 145, b: 145)),
                    Data = Geometry.Parse("F1 M 11.9063,89.9425L 123.337,89.9425L 151.414,35.4417L 100.524,41.9818L 101.402,51.792L 0.5,51.792L 11.9063,89.9425 Z ")
                };
                var Path2 = new Path
                {
                    Width = 16.2084,
                    Margin = new Thickness(24.4498, 0.0, 0.0, 40.0),
                    Height = 52.2308,
                    Stretch = Stretch.Fill,
                    StrokeLineJoin = PenLineJoin.Round,
                    Stroke = new SolidColorBrush(Color.FromRgb(r: 0, g: 0, b: 0)),
                    Fill = new SolidColorBrush(Color.FromRgb(r: 238, g: 145, b: 145)),
                    Data = Geometry.Parse("F1 M 24.9498,51.7308L 24.9498,30.748L 31.7497,30.748L 31.7497,18.2128L 38.9883,18.2128L 38.9883,0.500031L 40.0851,0.500031L 40.1582,51.64L 24.9498,51.7308 Z ")
                };
                var label = new Label { Content = Volume.ToString(), FontSize = 20, Margin = new Thickness(80.0, 0.0, 0.0, 0.0) };
                Canvas1.Children.Add(Path1);
                Canvas1.Children.Add(Path2);
                Canvas1.Children.Add(label);

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
