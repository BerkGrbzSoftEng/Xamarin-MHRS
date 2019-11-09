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
using MHRS.CustomRenderersAll;
using MHRS.Droid.CustomRendrers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly:ExportRenderer(typeof(CustomButton),typeof(CustomButtonRenderer))]
namespace MHRS.Droid.CustomRendrers
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
                {
                Control.SetAllCaps(false);
                Control.SetBackgroundColor(Android.Graphics.Color.Red);   
            }
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}