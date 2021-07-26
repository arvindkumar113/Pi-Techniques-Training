using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SampleProject5.Converters
{
    /// <summary>
    /// Converter that takes bool value and returns the visibility. if ture returns <see cref="Visibility.Visible"/>, if false returns <see cref="Visibility.Hidden", if null returns <see cref="Visibility.Hidden"/>
    /// </summary>
    public class BoolToVisibilityConverter :IValueConverter
    {
        #region Properties
        /// <summary>
        /// Gets or sets the visiblity returned if the value is true. The default value is <see cref="Visibility.Visible"/>.
        /// </summary>
        public Visibility TrueValue { get; set; }

        /// <summary>
        /// Gets or sets the visiblity returned if the value is false. The default value is <see cref="Visibility.Hidden"/>.
        /// </summary>
        public Visibility FalseValue { get; set; }

        /// <summary>
        /// Gets or sets the visiblity returned if the value is null. The default value is <see cref="Visibility.Hidden"/>.
        /// </summary>
        public Visibility NullValue { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// The default constructor which sets the default visibility properties.
        /// </summary>
        public BoolToVisibilityConverter()
        {
            TrueValue = Visibility.Visible;
            FalseValue = Visibility.Hidden;
            NullValue = Visibility.Hidden;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Executes the value conversion 
        /// </summary>
        /// <param name="value">Expects a bool value</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns><see cref="TrueValue"/> if the value is True, <see cref="FalseValue"/> is the value is False.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if(value==null)
           {
               return NullValue;
           }
           bool b;
           bool.TryParse(value.ToString(), out b);
           return b ? TrueValue : FalseValue;
        }

        /// <summary>
        /// Reverses the value conversion
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>True if the value equals <see cref="TrueValue"/>, False if the value equals <see cref="FalseValue"/></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
