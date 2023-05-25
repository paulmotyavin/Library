using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using DeserializeLib;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<string> list;
        private int countLNG = 1;
        private int countThm = 1;

        public MainWindow()
        {
            InitializeComponent();
            list = new List<string>();
            UpdateList();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            if (TextTbx.Text != null)
            {
                list.Add(TextTbx.Text);
                TextTbx.Text = "";
                Serialization.Serialize(list);
                UpdateList();
            }
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                list.RemoveAt(listbox.SelectedIndex);
                list.Add(TextTbx.Text);
                Serialization.Serialize(list);
                TextTbx.Text = "";
                UpdateList();
            }
        }

        private void RemoveBt_Click(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                list.RemoveAt(listbox.SelectedIndex);
                TextTbx.Text = "";
                Serialization.Serialize(list);
                UpdateList();
            }
        }
        void UpdateList()
        {
            list = Serialization.Deserialize<List<string>>();
            listbox.ItemsSource = null;
            listbox.ItemsSource = list;
        }

        private void listbox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                TextTbx.Text = listbox.SelectedItem.ToString();
            }
        }

        private void LanguageBt_Click(object sender, RoutedEventArgs e)
        {
            switch (countLNG)
            {
                case 1:
                    LanguageImg.Source = new BitmapImage(new Uri("img/usa.png", UriKind.Relative));
                    App.Language = "American";
                    countLNG = 2;
                    break;
                case 2:
                    LanguageImg.Source = new BitmapImage(new Uri("img/france.png", UriKind.Relative));
                    App.Language = "French";
                    countLNG = 3;
                    break;
                
                case 3:
                    LanguageImg.Source = new BitmapImage(new Uri("img/kazakhstan.png", UriKind.Relative));
                    App.Language = "Kazakh";
                    countLNG = 4;
                    break;
                case 4:
                    LanguageImg.Source = new BitmapImage(new Uri("img/china.png", UriKind.Relative));
                    App.Language = "Chinese";
                    countLNG = 5;
                    break;
                case 5:
                    LanguageImg.Source = new BitmapImage(new Uri("img/spain.png", UriKind.Relative));
                    App.Language = "Spanish";
                    countLNG = 6;
                    break;
                case 6:
                    LanguageImg.Source = new BitmapImage(new Uri("img/norway.png", UriKind.Relative));
                    App.Language = "Norwegian";
                    countLNG = 7;
                    break;
                case 7:
                    LanguageImg.Source = new BitmapImage(new Uri("img/russia.png", UriKind.Relative));
                    App.Language = "Russian";
                    countLNG = 1;
                    break;
            }
        }

        private void ThemesBt_Click(object sender, RoutedEventArgs e)
        {
            switch (countThm)
            {
                case 1:
                    ThemesImg.Source = new BitmapImage(new Uri("img/green.png", UriKind.Relative));
                    App.Theme = "GreenTheme";
                    countThm = 2;
                    break;
                case 2:
                    ThemesImg.Source = new BitmapImage(new Uri("img/black.png", UriKind.Relative));
                    App.Theme = "BlackTheme";
                    countThm = 3;
                    break;
                case 3:
                    ThemesImg.Source = new BitmapImage(new Uri("img/violet.png", UriKind.Relative));
                    App.Theme = "VioletTheme";
                    countThm = 4;
                    break;
                case 4:
                    ThemesImg.Source = new BitmapImage(new Uri("img/white.png", UriKind.Relative));
                    App.Theme = "WhiteTheme";
                    countThm = 5;
                    break;
                case 5:
                    ThemesImg.Source = new BitmapImage(new Uri("img/blue.png", UriKind.Relative));
                    App.Theme = "BlueTheme";
                    countThm = 1;
                    break;
            }
        }
    }
}
