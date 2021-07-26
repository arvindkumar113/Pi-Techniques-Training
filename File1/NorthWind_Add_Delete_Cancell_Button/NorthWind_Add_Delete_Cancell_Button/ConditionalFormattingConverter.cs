using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NorthWind_Add_Delete_Cancell_Button
{
    public class ConditionalFormattingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value!=null)
            {
                decimal comparewith = decimal.Parse(ConfigurationManager.AppSettings["formatValue"]);
                decimal units = decimal.Parse(value.ToString());
                if (units > comparewith)
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
