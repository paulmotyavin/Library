using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string theme;
        private static string language;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/ThemesLib;component/Themes/{value}.xaml", UriKind.RelativeOrAbsolute) };

                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);

               /* var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText($"{desktop}\\theme.txt", value);*/
            }
        }

        public static string Language
        {
            get { return language; }
            set
            {
                language = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/LocalizationLib;component/Languages/{value}.xaml", UriKind.RelativeOrAbsolute) };

                Current.Resources.MergedDictionaries.RemoveAt(1);
                Current.Resources.MergedDictionaries.Insert(1, dict);

/*                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText($"{desktop}\\language.txt", value);*/
            }
        }

        public App()
        {
            InitializeComponent();

/*            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (File.Exists($"{desktop}\\theme.txt"))
            {
                Theme = File.ReadAllText($"{desktop}\\theme.txt");
            }

            else if (File.Exists($"{desktop}\\language.txt"))
            {
                language = File.ReadAllText($"{desktop}\\language.txt");
            }*/
        }
    }
}
