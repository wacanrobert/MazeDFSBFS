using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class Block
    {
        private Rectangle block;
        private Point id;
        private bool isWall;
        private bool isCurrentPosition;
        private bool visited;
        private Point position;
        private Brush color;
        private Block parentBlock;
        private bool isPath;
        private int cost;
        
        public Block (Rectangle rectangle, Point position)
        {
            id = position;
            block = rectangle;
            this.position = position;
        }

        public Rectangle SquareBlock
        {
            get { return block; }
            set { block = value; }
        }

        public Point ID
        {
            get { return id; }
            set { id = value; }
        }

        public bool IsWall
        {
            get { return isWall; }
            set { isWall = value; }
        }

        public bool IsCurrentPosition
        {
            get { return isCurrentPosition; }
            set { isCurrentPosition = value; }
        }

        public bool IsVisited
        {
            get { return visited; }
            set { visited = value; }
        }

        public bool IsPath
        {
            get { return isPath; }
            set { isPath = value; }
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public Block ParentBlock
        {
            get { return parentBlock; }
            set { parentBlock = value; }
        }

        public Brush BlockColor
        {
            get { return color; }
            set { color = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public override string ToString()
        {
            return '(' + ID.X.ToString() + ',' + ID.Y.ToString() + ')';
        }
    }
}
