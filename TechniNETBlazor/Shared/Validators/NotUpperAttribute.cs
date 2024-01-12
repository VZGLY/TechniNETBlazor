using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniNETBlazor.Shared.Validators
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NotUpperAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string Value = (string)value;

            foreach (char elem in Value)
            {
                if (char.IsUpper(elem))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
