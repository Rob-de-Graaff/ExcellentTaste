using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ExcellentTaste.Extensions
{
    public static class VATEnumExtension
    {
        public static string DisplayNameVAT(this Enum e)
            => e.GetType().GetMember(e.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;
    }

    public static class ConsumableTypeEnumExtension
    {
        public static string DisplayNameConsumableType(this Enum e)
            => e.GetType().GetMember(e.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;
    }
}