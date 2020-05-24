using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pavilions_WS.ViewModels
{
    abstract class ValidateViewModel : BaseValidateModel
    {
        protected override bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            var b = base.Set(ref field, value, propertyName);
            if (b && GetType().GetProperty(propertyName).GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0)
            {
                IsValid = GetType().GetProperties()
                                   .Where(p => p.GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0)
                                   .Select(p => (string)p.GetValue(this))
                                   .All(s => !string.IsNullOrEmpty(s));
                NotifyPropertyChanged(nameof(IsValid));
            }
            return b;
        }

        public bool IsValid { get; private set; }
    }
}

