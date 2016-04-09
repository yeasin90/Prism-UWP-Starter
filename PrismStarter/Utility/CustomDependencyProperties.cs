using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace PrismStarter.Utility
{
    public static class CustomDependencyProperties
    {
        public static readonly DependencyProperty MyCtrlProperty =
            DependencyProperty.RegisterAttached("MyCtrl",
                typeof(string),
                typeof(CustomDependencyProperties),
                new PropertyMetadata("Hi", MyCtrlPropertyChanged));

        public static string GetMyCtrl(DependencyObject obj)
        {
            return (string)obj.GetValue(MyCtrlProperty);
        }

        public static void SetMyCtrl(DependencyObject obj, string value)
        {
            obj.SetValue(MyCtrlProperty, value);
        }

        private static void MyCtrlPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
