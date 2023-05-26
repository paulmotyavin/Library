﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace ThemesLib
{
    public class ChangeTheme
    {
        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                Application application = Application.Current;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/ThemesLib;component/Themes/{value}.xaml", UriKind.RelativeOrAbsolute) };
                application.Resources.MergedDictionaries.RemoveAt(0);
                application.Resources.MergedDictionaries.Insert(0, dict);
            }
        }
    }
}
