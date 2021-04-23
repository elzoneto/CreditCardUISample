using Foundation;
using PaymentUIStripe.Controls;
using PaymentUIStripe.iOS.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Entry), typeof(CustomEntryRenderer), new[] { typeof(CustomVisual) })]

namespace PaymentUIStripe.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}