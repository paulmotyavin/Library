using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows;

namespace LocalizationLib
{
    public class ChangeLanguage
    {
        
        private static string language;
        public static string Language
        {
            get { return language; }
            set
            {
                language = value;
                Application application = Application.Current;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/LocalizationLib;component/Languages/{value}.xaml", UriKind.RelativeOrAbsolute) };
                Window window = new Window();
                application.Resources.MergedDictionaries.RemoveAt(1);
                application.Resources.MergedDictionaries.Insert(1, dict);

            }
        }
    }
}
