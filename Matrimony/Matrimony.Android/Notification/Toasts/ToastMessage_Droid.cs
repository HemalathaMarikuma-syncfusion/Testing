using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Matrimony.Droid.Notification.Toasts;
using Matrimony.Notification.Toasts;
using Xamarin.Forms;

[assembly:Dependency(typeof(ToastMessage_Droid))]
namespace Matrimony.Droid.Notification.Toasts
{
    public class ToastMessage_Droid : IToastMessage
    {
        public void LongTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}