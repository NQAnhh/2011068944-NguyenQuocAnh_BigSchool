using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace _2011068944_NguyenQuocAnh.ViewModels
{
    internal class ValidTimeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "hh:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, 
                out dateTime);
            return isValid;
        }
    }
}