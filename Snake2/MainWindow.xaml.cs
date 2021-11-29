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
using System.Windows.Threading;

namespace Snake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SnakeGame jocSerp = new SnakeGame();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {           
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int tamanyXCasella = (int)(cnvCanvas.ActualWidth / SnakeGame.X_SIZE);
            int tamanyYCasella = (int)(cnvCanvas.ActualHeight / SnakeGame.Y_SIZE);

            Ellipse ellSerp = new Ellipse()
            {
                Fill = Brushes.Green,
                Width = cnvCanvas.ActualWidth / SnakeGame.X_SIZE,
                Height = cnvCanvas.ActualHeight / SnakeGame.Y_SIZE

            };
            cnvCanvas.Children.Add(ellSerp);
            Canvas.SetTop(ellSerp, jocSerp.CapSerp.Y * tamanyYCasella);
            Canvas.SetLeft(ellSerp, jocSerp.CapSerp.X * tamanyXCasella);
        }

        private void cnvCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            jocSerp.moure();
        }
    }
}
