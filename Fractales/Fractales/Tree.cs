using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace Fractales
{
    class Tree
    {
        public List<Branch> branches { get; set; } = new List<Branch>();
        public int n { get; set; }
        public int longitude { get; set; }
        public int repeat = 0;

        public void DrawPrincipalBranch(Graphics e, int x, int y)
        {
            Convert convert = new Convert();

            int initX = x / 2;
            int initY = y - 20;

            int finalX = (int)(initX - longitude * Math.Cos(convert.SexaToRadian(90)));
            int finalY = (int)(initY - longitude * Math.Sin(convert.SexaToRadian(90)));

            branches.Add(new Branch { finalizeX = finalX, finalizeY = finalY, angle = 90, initializeX = initX, initializeY = initY, longitude = 150 });

            e.DrawLine(Pens.Black, branches[0].initializeX, branches[0].initializeY, branches[0].finalizeX, branches[0].finalizeY);
            n = 0;
        }


        public void DrawBranchesForClick(Graphics e, int angle)
        {
            Convert convert = new Convert();

            int finalX, finalY;
            int initX, initY;

            for (int i = repeat; i < repeat+1; i++)
            {
                if (longitude < 20)
                {
                    longitude = 10;
                }
                else
                {
                    longitude = longitude - 20;
                }

                for (int j = 0; j < (int)Math.Pow(2, i); j++)
                {
                    initX = branches[n].finalizeX;
                    initY = branches[n].finalizeY;

                    finalX = (int)(initX - longitude * convert.Cos(branches[n].angle, angle, '+'));
                    finalY = (int)(initY - longitude * convert.Sen(branches[n].angle, angle, '+'));
                    branches.Add(new Branch { finalizeX = finalX, finalizeY = finalY, angle = branches[n].angle + angle, initializeX = initX, initializeY = initY, longitude = 150 });
                    //Azul
                    e.DrawLine(Pens.Blue, initX, initY, finalX, finalY);

                    finalX = (int)(initX - longitude * convert.Cos(branches[n].angle, angle, '-'));
                    finalY = (int)(initY - longitude * convert.Sen(branches[n].angle, angle, '-'));
                    branches.Add(new Branch { finalizeX = finalX, finalizeY = finalY, angle = branches[n].angle - angle, initializeX = initX, initializeY = initY, longitude = 150 });
                    //Rojo
                    e.DrawLine(Pens.Red, initX, initY, finalX, finalY);
                    n++;
                }
            }
            repeat++;
        }
    }
}
