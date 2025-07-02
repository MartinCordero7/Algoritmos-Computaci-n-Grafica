using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_DDA.Clases
{
    internal class Relleno
    {
        private List<(Point start, Point end, bool isInside)> lineSegments;
        private Size canvas;
        private const int TOLERANCE = 2;


        public Relleno(Size canvasSize)
        {
            canvas = canvasSize;
            lineSegments = new List<(Point start, Point end, bool isInside)>();

        }

        public void AddLine(Point start, Point end)
        {
            lineSegments.Add((start, end, true));
        }

        public void Draw(Graphics g)
        {
            using (Pen insidePen = new Pen(Color.Black, 2))
            {
                foreach (var line in lineSegments)
                {
                    if (!line.start.IsEmpty && !line.end.IsEmpty)
                    {
                        Pen pen = insidePen;
                        g.DrawLine(pen, line.start, line.end);
                    }
                }
            }
        }


        public void FloodFill(Bitmap bmp, Point pt, Color fillColor)
        {
            // Validación inicial de coordenadas
            if (pt.X < 0 || pt.X >= bmp.Width || pt.Y < 0 || pt.Y >= bmp.Height)
                return;

            Color targetColor = bmp.GetPixel(pt.X, pt.Y);

            // Si el color objetivo es igual al color de relleno, no hay nada que hacer
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            // Usar un HashSet para almacenar puntos ya visitados y evitar procesarlos múltiples veces
            HashSet<Point> visitedPoints = new HashSet<Point>();
            Queue<Point> pixels = new Queue<Point>();

            pixels.Enqueue(pt);
            visitedPoints.Add(pt);

            // Direcciones para verificar (arriba, abajo, izquierda, derecha)
            Point[] directions = new Point[]
            {
            new Point(0, -1),  // arriba
            new Point(0, 1),   // abajo
            new Point(-1, 0),  // izquierda
            new Point(1, 0)    // derecha
            };

            while (pixels.Count > 0)
            {
                Point current = pixels.Dequeue();

                if (bmp.GetPixel(current.X, current.Y).ToArgb() == targetColor.ToArgb() && !IsPointOnLine(current))
                {
                    bmp.SetPixel(current.X, current.Y, fillColor);

                    // Verificar las cuatro direcciones
                    foreach (var dir in directions)
                    {
                        Point newPoint = new Point(current.X + dir.X, current.Y + dir.Y);

                        if (IsValidPoint(newPoint, bmp.Width, bmp.Height) &&
                            !visitedPoints.Contains(newPoint))
                        {
                            pixels.Enqueue(newPoint);
                            visitedPoints.Add(newPoint);
                        }
                    }
                }
            }
        }

        private bool IsValidPoint(Point pt, int width, int height)
        {
            return pt.X >= 0 && pt.X < width && pt.Y >= 0 && pt.Y < height;
        }

        private bool IsPointOnLine(Point pt)
        {
            return lineSegments.Exists(line => IsPointNearLine(pt, line.start, line.end));
        }

        private bool IsPointNearLine(Point p, Point start, Point end)
        {
            // Si la línea es un punto
            if (start == end)
            {
                return Math.Abs(p.X - start.X) <= TOLERANCE &&
                       Math.Abs(p.Y - start.Y) <= TOLERANCE;
            }

            // Calcular la distancia del punto a la línea
            float numerator = Math.Abs((end.Y - start.Y) * p.X -
                                     (end.X - start.X) * p.Y +
                                      end.X * start.Y -
                                      end.Y * start.X);

            float denominator = (float)Math.Sqrt(Math.Pow(end.Y - start.Y, 2) +
                                               Math.Pow(end.X - start.X, 2));

            if (denominator == 0)
                return false;

            float distance = numerator / denominator;

            // Verificar si el punto está dentro del segmento de línea
            float dotProduct = ((p.X - start.X) * (end.X - start.X) +
                              (p.Y - start.Y) * (end.Y - start.Y)) /
                              (float)(Math.Pow(end.X - start.X, 2) +
                                     Math.Pow(end.Y - start.Y, 2));

            return distance <= TOLERANCE && dotProduct >= 0 && dotProduct <= 1;
        }

        public void BoundaryFill(Bitmap bmp, Point startPt, Color fillColor, Color boundaryColor)
        {
            // Verifica si el punto inicial está fuera de los límites
            if (!IsValidPoint(startPt, bmp.Width, bmp.Height))
                return;

            // Crear una cola para los puntos a procesar
            Queue<Point> points = new Queue<Point>();
            points.Enqueue(startPt);

            while (points.Count > 0)
            {
                Point pt = points.Dequeue();

                // Verifica si el punto está dentro de los límites
                if (!IsValidPoint(pt, bmp.Width, bmp.Height))
                    continue;

                Color currentColor = bmp.GetPixel(pt.X, pt.Y);

                // Si el punto no es del color del borde y no ha sido pintado todavía
                if (currentColor.ToArgb() != boundaryColor.ToArgb() &&
                    currentColor.ToArgb() != fillColor.ToArgb())
                {
                    // Pinta el punto actual
                    bmp.SetPixel(pt.X, pt.Y, fillColor);

                    // Agrega los puntos adyacentes a la cola
                    points.Enqueue(new Point(pt.X + 1, pt.Y));  // Derecha
                    points.Enqueue(new Point(pt.X, pt.Y + 1));  // Abajo
                    points.Enqueue(new Point(pt.X - 1, pt.Y));  // Izquierda
                    points.Enqueue(new Point(pt.X, pt.Y - 1));  // Arriba

                    // Diagonales
                    points.Enqueue(new Point(pt.X - 1, pt.Y - 1));
                    points.Enqueue(new Point(pt.X - 1, pt.Y + 1));
                    points.Enqueue(new Point(pt.X + 1, pt.Y - 1));
                    points.Enqueue(new Point(pt.X + 1, pt.Y + 1));
                }
            }
        }


        public List<Point> FillPolygon(Graphics graphics, List<Point> polygon, Color fillColor)
        {
            List<Point> paintedPixels = new List<Point>();

            if (polygon == null || polygon.Count < 3)
                return paintedPixels;

            int yMin = int.MaxValue, yMax = int.MinValue;

            // Encontrar el rango de Y
            foreach (var point in polygon)
            {
                if (point.Y < yMin) yMin = point.Y;
                if (point.Y > yMax) yMax = point.Y;
            }

            // Escanear cada línea horizontalmente
            for (int y = yMin; y <= yMax; y++)
            {
                List<int> intersections = new List<int>();

                for (int i = 0; i < polygon.Count; i++)
                {
                    Point p1 = polygon[i];
                    Point p2 = polygon[(i + 1) % polygon.Count];

                    if (p1.Y == p2.Y) continue; // Línea horizontal no se procesa

                    if (y >= p1.Y && y < p2.Y || y >= p2.Y && y < p1.Y)
                    {
                        int x = (int)(p1.X + (y - p1.Y) * (p2.X - p1.X) / (double)(p2.Y - p1.Y));
                        intersections.Add(x);
                    }
                }

                intersections.Sort();

                for (int i = 0; i < intersections.Count; i += 2)
                {
                    for (int x = intersections[i]; x <= intersections[i + 1]; x++)
                    {
                        graphics.FillRectangle(new SolidBrush(fillColor), x, y, 1, 1);
                        paintedPixels.Add(new Point(x, y));
                    }
                }
            }

            return paintedPixels;
        }

    }
}
