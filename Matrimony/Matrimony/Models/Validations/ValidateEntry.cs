using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Matrimony.Models.Validations
{
    public class ValidateEntry : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            entry.TextColor = entry.Text.Length > 0 ? Color.Black : Color.Gray;
        }
    }
}
