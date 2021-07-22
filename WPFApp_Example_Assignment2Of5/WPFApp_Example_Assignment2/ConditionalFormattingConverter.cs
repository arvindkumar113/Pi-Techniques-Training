using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFApp_Example_Assignment2
{
    public class ConditionalFormattingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            if(value!=null)
            {
                decimal freight = decimal.Parse(value.ToString());
                decimal compareWith = decimal.Parse(ConfigurationManager.AppSettings["freightValue"]);
                if (freight < compareWith)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
