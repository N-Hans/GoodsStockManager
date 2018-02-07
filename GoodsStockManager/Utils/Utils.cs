using GoodsStockManager.API.Data.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStockManager.API.Utils
{
    public static class Utils
    {

        public static List<SelectOption> GetEnumMembersDescription(Type enumType)
        {
            if (enumType.IsEnum)
            {
                List<SelectOption> selectOptions = new List<SelectOption>();

                Array values = Enum.GetValues(enumType);

                foreach (int val in values)
                {
                    var memInfo = enumType.GetMember(enumType.GetEnumName(val));
                    var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (descriptionAttributes.Length > 0)
                    {
                        selectOptions.Add(new SelectOption { DisplayValue = ((DescriptionAttribute)descriptionAttributes[0]).Description, Value = val });
                    }
                }
                return selectOptions;
            }
            return new List<SelectOption>();
        }
    }
}
