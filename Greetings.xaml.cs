using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KyokuMusicPlayer.Classes.Themes;

namespace KyokuMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Greetings : Window
    {
        public Greetings()
        {
            InitializeComponent();
            ThemeApplier.Apply(ThemeLoader.Load(), this);
        }

        private void Light_Theme_Button_Checked(object sender, RoutedEventArgs e)
        {
            ThemeSwitcher.Switch("Light",true,this);
        }

        private void Dark_Theme_Button_Checked(object sender, RoutedEventArgs e)
        {
            ThemeSwitcher.Switch("Dark",true,this);
        }

        private void Continue_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not complete.");
        }
    }
}
