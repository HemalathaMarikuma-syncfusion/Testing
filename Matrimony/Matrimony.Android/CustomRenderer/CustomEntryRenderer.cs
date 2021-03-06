﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Matrimony.Customization;
using Matrimony.Droid.CustomRenderer;
using Matrimony.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Matrimony.Droid.CustomRenderer
{

    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control.SetTextColor(global::Android.Graphics.Color.Black);
                Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHighlightColor(global::Android.Graphics.Color.WhiteSmoke);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.LightGray));
            }

        }

    }

}