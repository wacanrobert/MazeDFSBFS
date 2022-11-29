using System.Collections.Generic;
using System.Drawing;

namespace MazeSolver
{
    class MazeSolver
    {
        private Point currentPointPosition;

        public static Pen SQUARE_CORNER = Pens.Black;
        public static int TOTAL_BLOCKS = 375;
        public static int BLOCKS_COLUMN = 22;
        public static int BLOCKS_ROW = 17;
        private Block[,] blocks;


        public static MazeSolver instance  = new MazeSolver();

        private MazeSolver()
        {
            blocks = new Block[BLOCKS_ROW, BLOCKS_COLUMN];
            currentPointPosition = new Point(0,0);

            Point squareDistance = new Point(0, 0);

            for (int i = 0; i < BLOCKS_ROW; ++i)
            {
                for (int j = 0; j < BLOCKS_COLUMN; ++j)
                {
                    blocks[i, j] = new Block(new Rectangle(squareDistance.X, squareDistance.Y, 25, 25), new Point(j, i));           
                    squareDistance.X += 25;
                }
                squareDistance.X = 0;
                squareDistance.Y += 25;
            }

            blocks[0, 0].IsCurrentPosition = true;
        }

        public static MazeSolver Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MazeSolver();
                }
                return instance;
            }
        }
        public Block[,] BlockList
        {
            get
            {
                return blocks;
            }
        }
        
    }
}
