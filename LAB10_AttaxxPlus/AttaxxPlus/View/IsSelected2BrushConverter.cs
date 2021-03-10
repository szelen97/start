﻿using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace AttaxxPlus.View
{
    public class IsSelected2BrushConverter : IValueConverter
    {
        // EVIP: reusing brushes, named constants
        readonly private static SolidColorBrush borderColor = new SolidColorBrush(Colors.DarkMagenta);
        readonly private static SolidColorBrush gray = new SolidColorBrush(Colors.Gray);

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((bool)value) ? borderColor : gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
