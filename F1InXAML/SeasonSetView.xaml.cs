﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace F1InXAML
{
    /// <summary>
    /// Interaction logic for SeasonSetView.xaml
    /// </summary>
    public partial class SeasonSetView : UserControl
    {
        public SeasonSetView()
        {
            InitializeComponent();
        }

        private void DonateButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://pledgie.com/campaigns/31029");
        }
    }
}
