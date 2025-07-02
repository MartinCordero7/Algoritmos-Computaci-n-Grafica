using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_DDA.Clases
{
    internal class PerformanceMonitor
    {
        private static ListBox performanceListBox;
        private Process currentProcess;

        public static void Initialize(ListBox listBox)
        {
            performanceListBox = listBox;
        }

        public PerformanceMonitor()
        {
            currentProcess = Process.GetCurrentProcess();
        }

        public void MeasureAlgorithm(Action algorithm, string algorithmName, string algorithmType)
        {
            if (performanceListBox == null)
                return;

            // Recolectar basura antes de medir
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Memoria inicial
            long initialMemory = currentProcess.WorkingSet64;

            // Medir tiempo
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Ejecutar algoritmo
            algorithm.Invoke();

            stopwatch.Stop();

            // Memoria final
            long finalMemory = currentProcess.WorkingSet64;
            long memoryUsed = finalMemory - initialMemory;

            // Agregar resultados al ListBox
            performanceListBox.Invoke((MethodInvoker)delegate {
                performanceListBox.Items.Add($"=== {algorithmType}: {algorithmName} ===");
                performanceListBox.Items.Add($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
                performanceListBox.Items.Add($"Memoria utilizada: {memoryUsed / 1024} KB");
                performanceListBox.Items.Add($"Fecha/Hora: {DateTime.Now}");
                performanceListBox.Items.Add("============================");
                performanceListBox.TopIndex = performanceListBox.Items.Count - 1;
            });
        }

        public static void ClearMeasurements()
        {
            if (performanceListBox != null)
            {
                performanceListBox.Items.Clear();
            }
        }
    }
}
