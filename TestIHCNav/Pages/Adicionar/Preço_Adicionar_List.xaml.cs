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

namespace TestIHCNav.Pages.Adicionar
{
    /// <summary>
    /// Interaction logic for Preço_Adicionar_List.xaml
    /// </summary>
    public partial class Preço_Adicionar_List : UserControl
    {
        public Preço_Adicionar_List()
        {
            InitializeComponent();
        }

        private void adicionar_button_Click(object sender, RoutedEventArgs e)
        {
            if (!tecnologia_textbox.Text.Equals("") && !categoria_textbox.Text.Equals("") && !preço_textbox.Text.Equals(""))
            {
                ModernDialog.ShowMessage("Preço adicionado com sucesso!", "Sucesso!", MessageBoxButton.OK);
                IInputElement target = NavigationHelper.FindFrame("_top", this);
                NavigationCommands.GoToPage.Execute("/Pages/Adicionar.xaml", target);
            }
            else
                ModernDialog.ShowMessage("Dados inválidos!", "Sem Sucesso!", MessageBoxButton.OK);
        }
    }
}