﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using laba2DS.dartbaseDataSetTableAdapters;

namespace laba2DS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GamesTableAdapter Games = new GamesTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = Games.GetFullInfo();
        }


    }
}