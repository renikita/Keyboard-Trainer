﻿using System;
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

namespace Keyboard_Trainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int SpeedChar = 0;
        private int FailsChar = 0;
        private int DifficultChar = 0;
        public MainWindow()
        {
            InitializeComponent();
        
         
        }

        private void IsLoaded(object sender, EventArgs e)
        {
            SpeedLabel.Content = $"Speed {SpeedChar} chars/min";
            FailLabel.Content = $"Fails: {FailsChar}";
            DifficultyLabel.Content = $"Difficult: {DifficultChar}";
        }

        private void GetValueSlider(object sender, DragEventArgs e)
        {

        }



        
    }
}
