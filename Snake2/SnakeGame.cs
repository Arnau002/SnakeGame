using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public enum DireccoSnake
    {
        Dreta,
        Esquerra,
        Avall,
        Amunt
    }

    class SnakeGame
    {
        public const int X_SIZE = 20;
        public const int Y_SIZE = 20;

        Point capSerp = new Point(0, 0);
        DireccoSnake direccio = DireccoSnake.Avall;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccoSnake Direccio { get => direccio; set => direccio = value; }

        internal void moure()
        {
            capSerp.Y++;
        }
    }
}
