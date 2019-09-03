﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace BionicLibrary.Net.Converter
{
  [ValueConversion(typeof(bool), typeof(bool))]
  public class InvertBooleanConverter : IValueConverter
  {
    #region Implementation of IValueConverter

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is bool)
      {
        return !(bool) value;
      }
      return Binding.DoNothing;

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is bool)
      {
        return !(bool) value;
      }
      return Binding.DoNothing;

    }

    #endregion
  }
}
