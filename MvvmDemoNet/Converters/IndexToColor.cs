using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace MvvmDemoNet.Converters
{
    internal class IndexToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = Colors.White;
            
                double input = ((Int32)value)/1d;
                Random random = new Random();
                
                byte red = (byte)(random.Next(0, (int)(255 * input / 100d)) );
                byte green = (byte)(random.Next(0, (int)(255 *input / 100d)));
                byte blue = (byte)(random.Next(0, (int)(255 *input / 100d)));
                color = Color.FromRgb(red, green, blue);
            Brush brush = new SolidColorBrush(color);
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
