﻿using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
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

namespace TestIHCNav.Pages.Remover
{
    /// <summary>
    /// Interaction logic for Tecnologia_Remover_List.xaml
    /// </summary>
    public partial class Tecnologia_Remover_List : UserControl
    {
        public Tecnologia_Remover_List()
        {
            InitializeComponent();
        }

        private void remover_button_Click(object sender, RoutedEventArgs e)
        {
            /*            if (Carregar num item)
                        {  */
            ModernDialog.ShowMessage("Tecnologia removida com sucesso!", "Sucesso!", MessageBoxButton.OK);
            IInputElement target = NavigationHelper.FindFrame("_top", this);
            NavigationCommands.GoToPage.Execute("/Pages/Remover.xaml", target);
            /*            }
                        else
                            ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);*/
        }

        private void ModernTab_SelectedSourceChanged(object sender, SourceEventArgs e)
        {

        }

        private void ModernTab_SelectedSourceChanged2(object sender, SourceEventArgs e)
        {

        }

        private void ModernTab_SelectedSourceChanged3(object sender, SourceEventArgs e)
        {

        }

        private void ModernTab_SelectedSourceChanged4(object sender, SourceEventArgs e)
        {

        }
    }
}