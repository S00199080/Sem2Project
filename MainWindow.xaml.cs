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
    
    public partial class MainWindow : Window
    {

        StatTypes stats = new StatTypes();

        WeaponTypeContainer db = new WeaponTypeContainer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void genbtn_Click(object sender, RoutedEventArgs e)
        {
            string[] rings = { "Cloranthy Ring", "Havel's Ring", "Knight Ring", "Prayer Ring", "Silver Serpent Ring", "Thief's Ring", "Golden Serpent Ring", "Life Ring", "Sun Princess Ring", "Estus Ring", "Ashen Estus Ring", "Ring Of Favour", "Ring Of Steel Protection", "Thunder Stoneplate Ring", "Dark Stoneplate Ring", "Poisonbite Ring", "Scholar Ring", "Bloodbite Ring", "Darkmoon Ring", "Deep Ring", "Witches Ring" };


            if (combobx.SelectedItem == warrior)
            {
               

                string[] armourSets = { "Knight Set", "Havel's Set", "Iron Dragonslayer Set", "Northern Armour Set" ,"Ringed Knight Set", "Gundyr's Set", "Executioner Set"};
               

                classnametxtblck.Text = "Warrior";

                var query = from w in db.Weapons
                            where w.WeaponType == ("Strength")
                            select w;

                lstbx1.ItemsSource = query.ToList();



                txtblckSTR.Text = "60";
                txtblckDEX.Text = "15";
                txtblckLUC.Text = "10";
                txtblckEND.Text = "30";
                txtblckVIG.Text = "20";
                txtblckVIT.Text = "25";
                txtblckFAI.Text = "10";
                txtblckINT.Text = "10";
                txtblckATT.Text = "20";

                Random rnd = new Random();
                int index = rnd.Next(armourSets.Length);
                int ringindex1 = rnd.Next(rings.Length);
                int ringindex2 = rnd.Next(rings.Length);
                int ringindex3 = rnd.Next(rings.Length);
                int ringindex4 = rnd.Next(rings.Length);


                txtblckarmour.Text = ($"{armourSets[index]}");
                txtblckring1.Text= ($"{rings[ringindex1]}");
                txtblckring2.Text = ($"{rings[ringindex2]}");
                txtblckring3.Text = ($"{rings[ringindex3]}");
                txtblckring4.Text = ($"{rings[ringindex4]}");
            }

            else if (combobx.SelectedItem == pyromancer)
            {
                string[] armourSets = { "Pyromancy Set", "Fire Witch Set", "Sunset Armour Set", "Mirrah Set" };

                classnametxtblck.Text = "Pyromancer";
                

                var query = from w in db.Weapons
                            where w.WeaponType == ("Pyromancer")
                            select w;
                lstbx1.ItemsSource = query.ToList();

                txtblckSTR.Text = "30";
                txtblckDEX.Text = "25";
                txtblckLUC.Text = "10";
                txtblckEND.Text = "30";
                txtblckVIG.Text = "20";
                txtblckVIT.Text = "15";
                txtblckFAI.Text = "40";
                txtblckINT.Text = "30";
                txtblckATT.Text = "20";

                Random rnd = new Random();
                int index = rnd.Next(armourSets.Length);
                int ringindex1 = rnd.Next(rings.Length);
                int ringindex2 = rnd.Next(rings.Length);
                int ringindex3 = rnd.Next(rings.Length);
                int ringindex4 = rnd.Next(rings.Length);


                txtblckarmour.Text = ($"{armourSets[index]}");
                txtblckring1.Text = ($"{rings[ringindex1]}");
                txtblckring2.Text = ($"{rings[ringindex2]}");
                txtblckring3.Text = ($"{rings[ringindex3]}");
                txtblckring4.Text = ($"{rings[ringindex4]}");

            }

            else if (combobx.SelectedItem == sorcerer)
            {
                string[] armourSets = { "Cleric Set", "Cornyx Set", "Brigand Set", "Sorcerer Set" };

                classnametxtblck.Text = "Sorcerer";
                

                var query = from w in db.Weapons
                            where w.WeaponType == ("Sorcerer")
                            select w;
                lstbx1.ItemsSource = query.ToList();

                txtblckSTR.Text = "20";
                txtblckDEX.Text = "15";
                txtblckLUC.Text = "10";
                txtblckEND.Text = "20";
                txtblckVIG.Text = "30";
                txtblckVIT.Text = "15";
                txtblckFAI.Text = "40";
                txtblckINT.Text = "50";
                txtblckATT.Text = "30";

                Random rnd = new Random();
                int index = rnd.Next(armourSets.Length);
                int ringindex1 = rnd.Next(rings.Length);
                int ringindex2 = rnd.Next(rings.Length);
                int ringindex3 = rnd.Next(rings.Length);
                int ringindex4 = rnd.Next(rings.Length);


                txtblckarmour.Text = ($"{armourSets[index]}");
                txtblckring1.Text = ($"{rings[ringindex1]}");
                txtblckring2.Text = ($"{rings[ringindex2]}");
                txtblckring3.Text = ($"{rings[ringindex3]}");
                txtblckring4.Text = ($"{rings[ringindex4]}");
            }

            else if (combobx.SelectedItem == miracleuser)
            {
                string[] armourSets = { "Archdeacon Set", "Antiquated Set", "Evangelist Set", "Pale Shade Set" };

                classnametxtblck.Text = "Miracle User";
                

                var query = from w in db.Weapons
                            where w.WeaponType == ("Miracle User")
                            select w;
                lstbx1.ItemsSource = query.ToList();

                txtblckSTR.Text = "15";
                txtblckDEX.Text = "25";
                txtblckLUC.Text = "20";
                txtblckEND.Text = "15";
                txtblckVIG.Text = "20";
                txtblckVIT.Text = "20";
                txtblckFAI.Text = "60";
                txtblckINT.Text = "30";
                txtblckATT.Text = "25";

                Random rnd = new Random();
                int index = rnd.Next(armourSets.Length);
                int ringindex1 = rnd.Next(rings.Length);
                int ringindex2 = rnd.Next(rings.Length);
                int ringindex3 = rnd.Next(rings.Length);
                int ringindex4 = rnd.Next(rings.Length);


                txtblckarmour.Text = ($"{armourSets[index]}");
                txtblckring1.Text = ($"{rings[ringindex1]}");
                txtblckring2.Text = ($"{rings[ringindex2]}");
                txtblckring3.Text = ($"{rings[ringindex3]}");
                txtblckring4.Text = ($"{rings[ringindex4]}");

            }

            else if (combobx.SelectedItem == dexterityuser)
            {
                string[] armourSets = { "Black Set", "Pontiff Knight Set", "Catarina Set", "Chain Armour Set", "Dancer Set" };

                classnametxtblck.Text = "Dexterity";
                

                var query = from w in db.Weapons
                            where w.WeaponType == ("Dexterity")
                            select w;
                lstbx1.ItemsSource = query.ToList();

                txtblckSTR.Text = "20";
                txtblckDEX.Text = "55";
                txtblckLUC.Text = "20";
                txtblckEND.Text = "30";
                txtblckVIG.Text = "40";
                txtblckVIT.Text = "25";
                txtblckFAI.Text = "10";
                txtblckINT.Text = "10";
                txtblckATT.Text = "10";

                Random rnd = new Random();
                int index = rnd.Next(armourSets.Length);
                int ringindex1 = rnd.Next(rings.Length);
                int ringindex2 = rnd.Next(rings.Length);
                int ringindex3 = rnd.Next(rings.Length);
                int ringindex4 = rnd.Next(rings.Length);


                txtblckarmour.Text = ($"{armourSets[index]}");
                txtblckring1.Text = ($"{rings[ringindex1]}");
                txtblckring2.Text = ($"{rings[ringindex2]}");
                txtblckring3.Text = ($"{rings[ringindex3]}");
                txtblckring4.Text = ($"{rings[ringindex4]}");
            }

            




        }

        private void combobx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
