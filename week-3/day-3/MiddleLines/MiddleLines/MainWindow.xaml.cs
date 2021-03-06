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
using GreenFox;

namespace MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
        
            foxDraw.StrokeColor(Colors.Red);
            var startPointh = new Point(canvas.Width/2, 0);
            var endPointh = new Point(canvas.Width/2, canvas.Width);
            foxDraw.DrawLine(startPointh, endPointh);

            foxDraw.StrokeColor(Colors.Green);
            var startPointv = new Point(0, canvas.Width/2);
            var endPointv = new Point(canvas.Width, canvas.Width/2);
            foxDraw.DrawLine(startPointv, endPointv);
        }
    }
}
