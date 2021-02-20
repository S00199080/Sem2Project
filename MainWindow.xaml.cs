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

namespace Sem2Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void genbtn_Click(object sender, RoutedEventArgs e)
        {
            if (combobx.SelectedItem == warrior)
            {
                classnametxtblck.Text = "Warrior";
            }
            else if (combobx.SelectedItem == pyromancer)
            {
                classnametxtblck.Text = "Pyromancer";
            }
            else if (combobx.SelectedItem == sorcerer)
            {
                classnametxtblck.Text = "Sorcerer";
            }
            else if (combobx.SelectedItem == miracleuser)
            {
                classnametxtblck.Text = "Miracle User";
            }
            else if (combobx.SelectedItem == dexterityuser)
            {
                classnametxtblck.Text = "Dexterity User";
            }
        }
    }
}
