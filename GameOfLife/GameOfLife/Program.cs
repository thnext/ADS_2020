﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Convay’s Game of Life!");
            bool[,] grid = new bool[20, 20];
            grid[1, 1] = true;
            for(int x= 0;x <20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Console.Write(grid[x,y] ? "X" : ".");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Alive neigbours for 2,1 = " +
                GetAliveNeighboursCount(2,1,grid));
            Console.WriteLine("Alive neigbours for 0,1 = " +
                GetAliveNeighboursCount(0, 1, grid));
        }
        public static int GetAliveNeighboursCount(int x,int y,bool [,] grid)
        {
            int count = 0;
            int n = 20;
            if (grid[(x - 1 + n) % n, (y - 1 + n) % n] == true)
                count++;
            if (grid[x, (y - 1 + n) % n] == true)
                count++;
            if (grid[(x + 1)%n, (y - 1 + n) % n] == true)
                count++;
            if (grid[(x - 1 + n) % n, y] == true)
                count++;
            if (grid[(x + 1) % n, y] == true)
                count++;
            if (grid[(x - 1 + n) % n, (y + 1) % n] == true)
                count++;
            if (grid[x, (y + 1) % n] == true)
                count++;
            if (grid[(x + 1) % n, (y + 1) % n] == true)
                count++;
            return count;
        }
    }
}
