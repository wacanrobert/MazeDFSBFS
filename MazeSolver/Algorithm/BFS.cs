using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver.Algorithm
{
    class BFS
    {
        public BFS(){ }

        public Block GetStartingPosition(Block[,] block)
        {
            Block currentBlock = null;

            for (int i = 0; i < MazeSolver.BLOCKS_ROW; ++i)
            {
                for (int j = 0; j < MazeSolver.BLOCKS_COLUMN; ++j)
                {
                    if (block[i, j].IsCurrentPosition)
                    {
                        currentBlock = block[i,j];
                        break;
                    }
                }
            }
            return currentBlock;
        }
        public Block GetBlockPointedByCursor(Block[,] block, Point curPoint)
        {
            Block currentBlock = null;

            for (int i = 0; i < MazeSolver.BLOCKS_COLUMN; ++i)
            {
                for (int j = 0; j < MazeSolver.BLOCKS_ROW; ++j)
                {
                    if (block[j,i].SquareBlock.Contains(curPoint))
                    {
                        currentBlock = block[j,i];
                        break;
                    }
                }
            }
            return currentBlock;
        }

        public Queue<Block> Traverse(Block[,] block, Block pointedByCursor, bool allowDiagonal)
        {
            Queue<Block> queue = new Queue<Block>();
            Queue<Block> qPath = new Queue<Block>();


            if (!pointedByCursor.IsWall)
            {
                Dictionary<int, Block> origin = new Dictionary<int, Block>();
                Dictionary<int, Block> path = new Dictionary<int, Block>();

                Block startingPosition = GetStartingPosition(block);
                startingPosition.IsVisited = true;
                int k = 0;
                int l = 0;

                origin.Add(k++, startingPosition);
                queue.Enqueue(startingPosition);
                path.Add(l++, startingPosition);

                while (queue.Count != 0)
                {
                    Block currentBlock = queue.Dequeue();
                    currentBlock.IsVisited = true;

                    Point pCurrentPoint = currentBlock.ID;

                    if (pCurrentPoint.X == pointedByCursor.ID.X && pCurrentPoint.Y == pointedByCursor.ID.Y)
                        break;

                    bool notInQueue = !queue.Contains(currentBlock);

                    if (notInQueue)
                    {
                        // UP
                        if (pCurrentPoint.Y > 0 && pCurrentPoint.Y < MazeSolver.BLOCKS_ROW)
                        {
                            Block up = block[pCurrentPoint.Y-1, pCurrentPoint.X];

                            if (up.IsWall && allowDiagonal && pCurrentPoint.X > 0 && pCurrentPoint.Y > 0)
                                up = block[pCurrentPoint.Y-1, pCurrentPoint.X-1];
                            if (!up.IsWall && !up.IsVisited)
                            {
                                queue.Enqueue(up);
                                path.Add(l++, up);
                                origin.Add(k++, block[pCurrentPoint.Y, pCurrentPoint.X]);
                                if (up.ID.X == pointedByCursor.ID.X && up.ID.Y == pointedByCursor.ID.Y)
                                    break;
                            }

                        }

                        // DOWN 
                        if (pCurrentPoint.Y < MazeSolver.BLOCKS_ROW - 1)
                        {
                            Block down = block[pCurrentPoint.Y+1, pCurrentPoint.X];

                            if(down.IsWall && allowDiagonal && pCurrentPoint.X < MazeSolver.BLOCKS_COLUMN-1)
                                down = block[pCurrentPoint.Y+1, pCurrentPoint.X+1];

                            if (!down.IsWall && !down.IsVisited)
                            {
                                queue.Enqueue(down);
                                path.Add(l++, down);
                                origin.Add(k++, block[pCurrentPoint.Y, pCurrentPoint.X]);
                                if (down.ID.X == pointedByCursor.ID.X && down.ID.Y == pointedByCursor.ID.Y)
                                    break;
                            }
                        }

                        // LEFT
                        if (pCurrentPoint.X > 0 && pCurrentPoint.X < MazeSolver.BLOCKS_COLUMN)
                        {
                            Block left = block[pCurrentPoint.Y, pCurrentPoint.X - 1];

                            if (left.IsWall && allowDiagonal && pCurrentPoint.Y < MazeSolver.BLOCKS_ROW - 1)
                                left = block[pCurrentPoint.Y + 1, pCurrentPoint.X-1];
                            if (!left.IsWall && !left.IsVisited)
                            {
                                queue.Enqueue(left);
                                path.Add(l++, left);
                                origin.Add(k++, block[pCurrentPoint.Y, pCurrentPoint.X]);

                                if (left.ID.X == pointedByCursor.ID.X && left.ID.Y == pointedByCursor.ID.Y)
                                    break;
                            }
                        }


                        // RIGHT
                        if (pCurrentPoint.X < MazeSolver.BLOCKS_COLUMN - 1)
                        {
                            Block right = block[pCurrentPoint.Y, pCurrentPoint.X + 1];

                            if (right.IsWall && allowDiagonal && pCurrentPoint.Y > 0)
                                right = block[pCurrentPoint.Y - 1, pCurrentPoint.X+1];

                            if (!right.IsWall && !right.IsVisited)
                            {
                                queue.Enqueue(right);
                                path.Add(l++, right);
                                origin.Add(k++, block[pCurrentPoint.Y, pCurrentPoint.X]);

                                if (right.ID.X == pointedByCursor.ID.X && right.ID.Y == pointedByCursor.ID.Y)
                                    break;
                            }
                        }
                    }
                }

                Block endBlockStack = path[path.Count - 1];
                Block prevPath = origin[origin.Count - 1];

                endBlockStack.BlockColor = Brushes.Cyan;
                Block getPath = endBlockStack;
                qPath.Enqueue(getPath);

                while (!getPath.Equals(startingPosition))
                {
                    for (int b = path.Count - 1; b >= 0; b--)
                    {
                        if (prevPath == path[b])
                        {
                            getPath = path[b];
                            prevPath = origin[b];
                            getPath.IsPath = true;
                            getPath.BlockColor = Brushes.Cyan;
                            qPath.Enqueue(getPath);
                            break;
                        }
                    }
                }
            }
            Queue<Block> rev = new Queue<Block>(qPath.Reverse());
            return rev;
        } 
    }
}
