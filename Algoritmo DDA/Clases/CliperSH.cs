using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_DDA.Clases
{
    internal class CliperSH
    {
        private Rectangle clipRegion;

        public CliperSH(Rectangle clipRegion)
        {
            this.clipRegion = clipRegion;
        }

        public List<Point> ClipPolygon(List<Point> polygon)
        {
            if (polygon == null || polygon.Count < 3)
                return new List<Point>(); // Polígono no válido

            List<Point> output = new List<Point>(polygon);
            output = ClipAgainstEdge(output, Edge.Left);
            output = ClipAgainstEdge(output, Edge.Right);
            output = ClipAgainstEdge(output, Edge.Top);
            output = ClipAgainstEdge(output, Edge.Bottom);
            return output;
        }

        private enum Edge { Left, Right, Top, Bottom }

        private List<Point> ClipAgainstEdge(List<Point> input, Edge edge)
        {
            List<Point> output = new List<Point>();

            for (int i = 0; i < input.Count; i++)
            {
                Point current = input[i];
                Point prev = input[(i - 1 + input.Count) % input.Count];

                bool currInside = IsInsideEdge(current, edge);
                bool prevInside = IsInsideEdge(prev, edge);

                if (currInside)
                {
                    if (!prevInside)
                    {
                        Point inter = ComputeIntersection(prev, current, edge);
                        output.Add(inter);
                    }
                    output.Add(current);
                }
                else if (prevInside)
                {
                    Point inter = ComputeIntersection(prev, current, edge);
                    output.Add(inter);
                }
            }

            return output;
        }

        private bool IsInsideEdge(Point p, Edge edge)
        {
            switch (edge)
            {
                case Edge.Left: return p.X >= clipRegion.Left;
                case Edge.Right: return p.X <= clipRegion.Right;
                case Edge.Top: return p.Y >= clipRegion.Top;
                case Edge.Bottom: return p.Y <= clipRegion.Bottom;
                default: return false;
            }
        }

        private Point ComputeIntersection(Point p1, Point p2, Edge edge)
        {
            float x = 0, y = 0;
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;

            switch (edge)
            {
                case Edge.Left:
                    x = clipRegion.Left;
                    y = p1.Y + dy * (clipRegion.Left - p1.X) / dx;
                    break;
                case Edge.Right:
                    x = clipRegion.Right;
                    y = p1.Y + dy * (clipRegion.Right - p1.X) / dx;
                    break;
                case Edge.Top:
                    y = clipRegion.Top;
                    x = p1.X + dx * (clipRegion.Top - p1.Y) / dy;
                    break;
                case Edge.Bottom:
                    y = clipRegion.Bottom;
                    x = p1.X + dx * (clipRegion.Bottom - p1.Y) / dy;
                    break;
            }

            return new Point((int)Math.Round(x), (int)Math.Round(y));
        }
    }
}

