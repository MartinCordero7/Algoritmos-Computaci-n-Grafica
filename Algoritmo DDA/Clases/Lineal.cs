using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_DDA.Clases
{
    internal class Lineal
    {
        private PointF? point1 = null;
        private PointF? point2 = null;
        private PointF? selectedPoint = null;
        private float currentL = 0f;

        private const float PointRadius = 8f;
        private const float Step = 0.01f;

        public bool AddOrResetPoint(Point location)
        {
            if (point1 == null)
            {
                point1 = location;
                return false;
            }
            else if (point2 == null)
            {
                point2 = location;
                return true;
            }
            else
            {
                point1 = location;
                point2 = null;
                currentL = 0f;
                return false;
            }
        }

        public void Draw(Graphics g)
        {
            if (point1.HasValue)
            {
                DrawControlPoint(g, point1.Value, Brushes.Red);
            }

            if (point2.HasValue)
            {
                DrawControlPoint(g, point2.Value, Brushes.Green);
            }

            if (point1.HasValue && point2.HasValue)
            {
                DrawBezierCurve(g, point1.Value, point2.Value, currentL);
            }
        }

        public void SelectPointAtLocation(Point location)
        {
            if (point1.HasValue && IsPointSelected(point1.Value, location))
            {
                selectedPoint = point1;
            }
            else if (point2.HasValue && IsPointSelected(point2.Value, location))
            {
                selectedPoint = point2;
            }
        }

        public bool UpdateSelectedPoint(Point location)
        {
            if (selectedPoint.HasValue)
            {
                if (selectedPoint == point1)
                {
                    point1 = location;
                    return true;
                }
                else if (selectedPoint == point2)
                {
                    point2 = location;
                    return true;
                }
            }
            return false;
        }

        public void ClearSelectedPoint()
        {
            selectedPoint = null;
        }

        public bool UpdateAnimation()
        {
            currentL += Step;
            if (currentL > 1f)
            {
                currentL = 1f;
                return true;
            }
            return false;
        }

        public void ResetAnimation()
        {
            currentL = 0f;
        }

        private void DrawBezierCurve(Graphics g, PointF p0, PointF p1, float maxL)
        {
            using (Pen curvePen = new Pen(Color.Blue, 2))
            {
                for (float l = 0; l <= maxL; l += 0.01f)
                {
                    float x = (1 - l) * p0.X + l * p1.X;
                    float y = (1 - l) * p0.Y + l * p1.Y;
                    g.DrawEllipse(curvePen, x, y, 1, 1);
                }
            }
        }

        private void DrawControlPoint(Graphics g, PointF point, Brush brush)
        {
            g.FillEllipse(brush, point.X - PointRadius / 2, point.Y - PointRadius / 2, PointRadius, PointRadius);
        }

        private bool IsPointSelected(PointF point, Point location)
        {
            return Math.Sqrt(Math.Pow(point.X - location.X, 2) + Math.Pow(point.Y - location.Y, 2)) <= PointRadius;
        }
    }
}
