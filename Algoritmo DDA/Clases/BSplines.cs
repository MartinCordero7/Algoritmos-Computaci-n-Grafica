using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_DDA.Clases
{
    internal class BSplines
    {
        public List<PointF> ControlPoints { get; private set; } = new List<PointF>();

        public void AddPoint(PointF point)
        {
            ControlPoints.Add(point);
        }

        public void ClearPoints()
        {
            ControlPoints.Clear();
        }

        public List<PointF> GenerateBSplinePoints(int segments = 100)
        {
            List<PointF> curvePoints = new List<PointF>();
            if (ControlPoints.Count < 4)
                return curvePoints;

            for (int i = 0; i <= ControlPoints.Count - 4; i++)
            {
                for (int j = 0; j <= segments; j++)
                {
                    float t = j / (float)segments;
                    PointF p = DeBoor(i, t);
                    curvePoints.Add(p);
                }
            }

            return curvePoints;
        }

        private PointF DeBoor(int i, float t)
        {
            // B-spline de grado 3 (cúbica)
            PointF p0 = ControlPoints[i];
            PointF p1 = ControlPoints[i + 1];
            PointF p2 = ControlPoints[i + 2];
            PointF p3 = ControlPoints[i + 3];

            float t2 = t * t;
            float t3 = t2 * t;

            float b0 = (1 - t) * (1 - t) * (1 - t) / 6f;
            float b1 = (3 * t3 - 6 * t2 + 4) / 6f;
            float b2 = (-3 * t3 + 3 * t2 + 3 * t + 1) / 6f;
            float b3 = t3 / 6f;

            float x = b0 * p0.X + b1 * p1.X + b2 * p2.X + b3 * p3.X;
            float y = b0 * p0.Y + b1 * p1.Y + b2 * p2.Y + b3 * p3.Y;

            return new PointF(x, y);
        }
    }
}
