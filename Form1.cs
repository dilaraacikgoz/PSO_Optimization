using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO_Optimization
{
    public partial class q : Form
    {
        
        public q()
        {
            InitializeComponent();
        }

        // PSO algoritmasını verilen parametrelerle çalıştıran metot
        private void RunPSO(int particleCount, int dimension, double c1, double c2,
            double minPos, double maxPos, string stopCriteria, int maxIter,
            double epsilon, double convergenceValue)
        {
            // PSO sınıfından yeni bir nesne oluşturulur ve parametreler atanır
            PSO pso = new PSO(particleCount, dimension, c1, c2, minPos, maxPos,
                              stopCriteria, maxIter, epsilon, convergenceValue, vmax: 2.0);

         
            pso.Run();

         
            txtLog.Text = $"Global Best Fitness: {pso.GlobalBestFitness}\r\n" +
                          $"Position: {string.Join(", ", pso.GlobalBestPosition)}";

         
            DrawChart(pso.BestFitnessHistory);
        }

       
        private void DrawChart(List<double> bestFitnessHistory)
        {
            chartConvergence.Series.Clear(); // Önceki grafiği temizle
            var series = chartConvergence.Series.Add("Fitness"); // Yeni seri ekle
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; // Çizgi grafik

          
            for (int i = 0; i < bestFitnessHistory.Count; i++)
            {
                series.Points.AddXY(i, bestFitnessHistory[i]);
            }

            chartConvergence.ChartAreas[0].AxisX.Title = "Iteration";
            chartConvergence.ChartAreas[0].AxisY.Title = "Best Fitness";
            chartConvergence.ChartAreas[0].RecalculateAxesScale();
        }

      
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Arayüzdeki NumericUpDown'lardan parametreleri al
            int particleCount = (int)nudParticleCount.Value;
            int dimension = 2;  // Dimension sabit 2, 2 boyutlu problem için
            double c1 = (double)nudC1.Value;
            double c2 = (double)nudC2.Value;
            double minPosition = (double)nudMinPosition.Value;
            double maxPosition = (double)nudMaxPosition.Value;

        
            string stopCriteria = "";
            int maxIteration = 0;
            double epsilon = 0;
            double convergenceValue = 0;

            // Kullanıcının seçtiği sonlanma kriterine göre ilgili değeri al
            if (rbtnStopGen.Checked) // Jenerasyon sayısı seçiliyse
            {
                stopCriteria = "Generation";
                if (!int.TryParse(txtStopValue.Text, out maxIteration))
                {
                    MessageBox.Show("Lütfen geçerli bir iterasyon sayısı girin.");
                    return;
                }
            }
            else if (rbtnStopEpsilon.Checked) // Epsilon seçiliyse
            {
                stopCriteria = "Epsilon";
                if (!double.TryParse(txtStopValue.Text, out epsilon))
                {
                    MessageBox.Show("Lütfen geçerli bir epsilon değeri girin.");
                    return;
                }
            }
            else if (rbtnStopConverge.Checked) // Yakınsama seçiliyse
            {
                stopCriteria = "Convergence";
                if (!double.TryParse(txtStopValue.Text, out convergenceValue))
                {
                    MessageBox.Show("Lütfen geçerli bir yakınsama değeri girin.");
                    return;
                }
            }
            else
            {
        
                MessageBox.Show("Lütfen bir sonlanma kriteri seçin.");
                return;
            }

            // PSO algoritmasını çalıştır
            RunPSO(particleCount, dimension, c1, c2, minPosition, maxPosition, stopCriteria, maxIteration, epsilon, convergenceValue);
        }

       
        private void q_Load(object sender, EventArgs e)
        {
         
            nudMinPosition.Minimum = -10;
            nudMinPosition.Maximum = 10;
            nudMinPosition.DecimalPlaces = 2;
            nudMinPosition.Increment = 0.1M;

         
            nudC1.Minimum = 0;
            nudC1.Maximum = 5;
            nudC1.DecimalPlaces = 2;
            nudC1.Increment = 0.1M;

           
            nudC2.Minimum = 0;
            nudC2.Maximum = 5;
            nudC2.DecimalPlaces = 2;
            nudC2.Increment = 0.1M;
        }

    }
}
