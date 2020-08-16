using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Notification.Toasts
{
    public interface IToastMessage
    {
        void LongTime(string message);
        void ShortTime(string message);
    }
}
