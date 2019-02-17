﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShipThreading
{
    class Hleb10
    {
        public Hleb10(WrapPanel wrap)
        {
            var Canvas1 = new Canvas
            {
                Width = 50,
                Height = 25,
                Margin = new Thickness(20.0)
            };

            var Path1 = new Path
            {
                Width = 76.872,
                Margin = new Thickness(-1.52588e-005, 16, 0.0, 0.0),
                Height = 25.7876,
                Stretch = Stretch.Fill,
                StrokeLineJoin = PenLineJoin.Round,
                Stroke = new SolidColorBrush(Color.FromRgb(r: 0, g: 0, b: 0)),
                Fill = new SolidColorBrush(Color.FromRgb(r: 238, g: 145, b: 145)),
                Data = Geometry.Parse("F1 M 7.79359,53.4863L 79.0465,53.4863L 97,21.1996L 64.4593,25.074L 65.0203,30.8856L 0.5,30.8856L 7.79359,53.4863 Z ")
            };
            var Path2 = new Path
            {
                Width = 8.64601,
                Margin = new Thickness(12.2921, 0.0, 0.0, 40.0),
                Height = 24.3003,
                Stretch = Stretch.Fill,
                StrokeLineJoin = PenLineJoin.Round,
                Stroke = new SolidColorBrush(Color.FromRgb(r: 0, g: 0, b: 0)),
                Fill = new SolidColorBrush(Color.FromRgb(r: 238, g: 145, b: 145)),
                Data = Geometry.Parse("F1 M 12.7921,23.8003L 12.7921,14.2571L 16.2108,14.2571L 16.2108,8.55594L 19.85,8.55594L 19.85,0.5L 20.4014,0.5L 20.4381,23.759L 12.7921,23.8003 Z ")
            };
            Canvas1.Children.Add(Path1);
            Canvas1.Children.Add(Path2);

            wrap.Children.Add(Canvas1);
        }
    }
}