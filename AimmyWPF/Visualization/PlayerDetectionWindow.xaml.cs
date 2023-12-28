﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AimmyWPF.Class;

namespace Visualization
{
    /// <summary>
    /// Interaction logic for PlayerDetectionWindow.xaml
    /// </summary>
    public partial class PlayerDetectionWindow : Window
    {
        public PlayerDetectionWindow()
        {
            InitializeComponent();

            AwfulPropertyChanger.ReceivePDWSize = ChangeSize;
            AwfulPropertyChanger.ReceivePDWCornerRadius = ChangeCornerRadius;
            AwfulPropertyChanger.ReceivePDWBorderThickness = ChangeBorderThickness;
            AwfulPropertyChanger.ReceivePDWOpacity = ChangeOpacity;
        }

        void ChangeSize(int newint)
        {
            DetectedPlayerFocus.Width = newint;
            DetectedPlayerFocus.Height = newint;

            UnfilteredPlayerFocus.Width = newint;
            UnfilteredPlayerFocus.Height = newint;

            PredictionFocus.Width = newint;
            PredictionFocus.Height = newint;
        }

        void ChangeCornerRadius(int newint)
        {
            DetectedPlayerFocus.CornerRadius = new CornerRadius(newint);
            UnfilteredPlayerFocus.CornerRadius = new CornerRadius(newint);
            PredictionFocus.CornerRadius = new CornerRadius(newint);
        }

        void ChangeBorderThickness(int newint)
        {
            DetectedPlayerFocus.BorderThickness = new Thickness(newint);
            UnfilteredPlayerFocus.BorderThickness = new Thickness(newint);
            PredictionFocus.BorderThickness = new Thickness(newint);
        }

        void ChangeOpacity(double newdouble)
        {
            DetectedPlayerFocus.Opacity = newdouble;
            UnfilteredPlayerFocus.Opacity = newdouble;
            PredictionFocus.Opacity = newdouble;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}