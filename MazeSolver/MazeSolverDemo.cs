using MazeSolver.Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MazeSolver
{
    public partial class MazeSolverDemo : Form
    {
        private MazeSolver maze; // [17,22]
        private Graphics g;
        private int eX = 5;
        private int eY = 5;
        private RectangleF objEllipse;
        public MazeSolverDemo()
        {
            InitializeComponent();

            maze = MazeSolver.Instance;
            objEllipse = new RectangleF(eX, eY, 15, 15);
        }

        private void pictureMaze_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            Block[,] block = maze.BlockList;

            int rowCount = MazeSolver.BLOCKS_ROW;
            int colCount = MazeSolver.BLOCKS_COLUMN;

            for (int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < colCount; j++)
                {
                    Block b = block[i, j];
                    g.DrawRectangle(MazeSolver.SQUARE_CORNER, b.SquareBlock);
                    if (b.IsWall)
                    {
                        Rectangle rect = new Rectangle(b.SquareBlock.X + 1, b.SquareBlock.Y + 1, b.SquareBlock.Width-1, b.SquareBlock.Height-1);
                        g.FillRectangle(Brushes.Gray, rect);
                    }
                    else if (b.BlockColor != null)
                    {
                        Rectangle rect = new Rectangle(b.SquareBlock.X + 1, b.SquareBlock.Y + 1, b.SquareBlock.Width-1, b.SquareBlock.Height-1);
                        g.FillRectangle(b.BlockColor,rect);
                    }

                }
            }

            g.FillEllipse(Brushes.Blue, objEllipse);
        }
       
        private Block destBlock;
        private Queue<Block> queuePath;
        private Stack<Block> stackPath;
        private bool traversing = false;
        private void pictureMaze_MouseMove(object sender, MouseEventArgs e)
        {
            if (chkBFS.Checked)
            {
                lblX.Text = "X: " + e.X.ToString();
                lblY.Text = "Y: " + e.Y.ToString();

                if (!traversing)
                {
                    BFS bfs = new BFS();
                    destBlock = bfs.GetBlockPointedByCursor(maze.BlockList, new Point(e.X, e.Y));
                    if (destBlock != null)
                    {
                        lblDestPoint.Text = destBlock.ToString();
                        ClearVisited();

                        if (radioTraversal.Checked)
                        {
                            queuePath = bfs.Traverse(maze.BlockList, destBlock, chkDiagonal.Checked);
                        }
                    }
                    else
                    {
                        lblDestPoint.Text = "NULL";
                    }


                    pictureMaze.Refresh();
                }
            }
            else
            {
                lblX.Text = "X: " + e.X.ToString();
                lblY.Text = "Y: " + e.Y.ToString();

                if (!traversing)
                {
                    DFS dfs = new DFS();
                    destBlock = dfs.GetBlockPointedByCursor(maze.BlockList, new Point(e.X, e.Y));
                    if (destBlock != null)
                    {
                        lblDestPoint.Text = destBlock.ToString();
                        ClearVisited();

                        if (radioTraversal.Checked)
                        {
                            stackPath = dfs.Traverse(maze.BlockList, destBlock, chkDiagonal.Checked);
                        }
                    }
                    else
                    {
                        lblDestPoint.Text = "NULL";
                    }


                    pictureMaze.Refresh();
                }
            }
                
        }

        private void pictureMaze_MouseUp(object sender, MouseEventArgs e)
        {
            Point location = new Point(e.X, e.Y);

            if (radioCreateWall.Checked)
            {
                Block[,] blocks = maze.BlockList;
                if (radioCreateWall.Checked)
                {
                    int rowCount = MazeSolver.BLOCKS_ROW;
                    int colCount = MazeSolver.BLOCKS_COLUMN;
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; ++j)
                        {
                            Block b = blocks[i, j];
                            Rectangle r = b.SquareBlock;
                            if (r.Contains(location.X, location.Y) && !b.IsCurrentPosition)
                            {
                                b.IsWall = !b.IsWall;
                                break;
                            }
                        }
                    }
                }

            }
            else if(radioTraversal.Checked)
            {
                ClearVisited();
                objectTimer.Start();
            }
            pictureMaze.Refresh();

        }

        private void btnClearWalls_Click(object sender, EventArgs e)
        {
            Clear();
            pictureMaze.Refresh();
        }

        private void Clear()
        {
            Block[,] blocks = maze.BlockList;

            for (int i = 0; i < MazeSolver.BLOCKS_ROW; i++)
            {
                for (int j = 0; j < MazeSolver.BLOCKS_COLUMN; j++)
                {
                    blocks[i,j].IsWall = false;
                }
            }
        }

        private void ClearVisited()
        {
            Block[,] blocks = maze.BlockList;

            for (int i = 0; i < MazeSolver.BLOCKS_ROW; i++)
            {
                for (int j = 0; j < MazeSolver.BLOCKS_COLUMN; j++)
                {
                    blocks[i,j].IsVisited = false;
                    blocks[i,j].BlockColor = null;
                }
            }
        }
        bool nextPath = true; // X
        Block b;

        private void objectTimer_Tick(object sender, EventArgs e)
        {
            traversing = true;
            while (queuePath.Count != 0)
            {
                if(chkBFS.Checked)
                    b = queuePath.Dequeue();
                else
                    b = stackPath.Pop();
                b.BlockColor = null;
                b.IsCurrentPosition = false;
                runnerXObject.Enabled = true;

                Invoke((MethodInvoker)delegate {
                    pictureMaze.Refresh();
                });

                if (queuePath.Count == 0)
                {
                    b.IsCurrentPosition = true;
                    objEllipse.X = b.ID.X * 25 + 5;
                    objEllipse.Y = b.ID.Y * 25 + 5;
                }
                runnerXObject.Stop();

            }
            traversing = false;
            objectTimer.Stop();
            pictureMaze.Invalidate();
        }

        private void runnerObject_Tick(object sender, EventArgs e)
        {
        //    if (queuePath.Count != 0 && queuePath.Peek().ID.X == b.ID.X)
      //      {
                int endX = b.ID.X * 25;
                 int i = endX;
           //     for (int i = endX; i < endX+25; i++)
         //       {
                    if(i < endX + 25)
                    objEllipse.X = b.ID.X + 1;
       //         }

        //    }
    //        else
    /*        {
                int endY = b.ID.Y * 25;
                for (int i = endY; i < endY+25; i++)
                {
                    objEllipse.Y = b.ID.Y + 1;
                }
            }*/

        }

        private void chkDiagonal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MazeSolverDemo_Load(object sender, EventArgs e)
        {
            chkBFS.Checked = true;
        }

        private void chkBFS_CheckedChanged(object sender, EventArgs e)
        {
            chkDFS.Checked = false;
        }

        private void chkDFS_CheckedChanged(object sender, EventArgs e)
        {
            chkBFS.Checked = false;
        }

        private void chkBFS_Click(object sender, EventArgs e)
        {
            chkDFS.Checked = false;
            chkBFS.Checked = true;
        }

        private void chkDFS_Click(object sender, EventArgs e)
        {
            chkBFS.Checked = false;
            chkDFS.Checked = true;
        }
    }
}
