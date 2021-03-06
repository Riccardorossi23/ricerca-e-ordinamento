﻿using System;
using System.Collections;
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
using System.IO;

namespace ricerca_e_ordinamento
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
        List<string> NomiDaInserire = new List<string>();
        int i;
        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            NomiDaInserire.Add($"{txtNomiDaInserire.Text}");
            txtNomiDaInserire.Clear();
            NomiDaInserire.Sort();
            lblLista.Content = "";
            for (i = 0; i < NomiDaInserire.Count; i++)
            {
                lblLista.Content += ($" { i + 1} {NomiDaInserire[i]}\n");
            }


        }

        private void txtNomiDaInserire_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            {
               
                
                    bool ricerca = false;
                MessageBox.Show("l'alunno non è in questa lista");
                for (int i = 0; i < NomiDaInserire.Count; i++)
                {
                    if (NomiDaInserire[i] == txtcerca.Text)
                    {
                        ricerca = true;
                        MessageBox.Show("l'alunno è in questa lista");
                    }

                }

            }

        }

        private void btn_salva_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter w = new StreamWriter("fileRicercaeOrdinamento.txt", false, Encoding.UTF8);
            {
                for (i = 0; i < NomiDaInserire.Count; i++)
                {
                    w.WriteLine ($" { i + 1} {NomiDaInserire[i]}\n");
                }

                w.Flush();
                w.Close();
                
            }
        }

        private void lblLista_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}

