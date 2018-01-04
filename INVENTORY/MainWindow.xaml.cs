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

namespace INVENTORY
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle obj;
        private bool _isRectDragInProg;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void rect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _isRectDragInProg = true;
            obj = sender as Rectangle;

            obj.CaptureMouse();
        }

        private void rect_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isRectDragInProg = false;
            obj.ReleaseMouseCapture();
        }

        private void rect_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isRectDragInProg) return;

            // get the position of the mouse relative to the Canvas
            var mousePos = e.GetPosition(grid);

            // center the rect on the mouse          
            double left = mousePos.X  / 50;
            double top = mousePos.Y  / 50;

            int promleft = (int)left;
            int promright = (int)top;

            Grid.SetColumn(obj, promleft);
            Grid.SetRow(obj, promright);
        }   
    }
}
