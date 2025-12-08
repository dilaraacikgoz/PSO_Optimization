using System;
using System.Collections.Generic;

namespace PSO_Optimization
{
    // Parçacık (Particle) sınıfı: Bir parçacığın pozisyonu, hızı ve en iyi pozisyonunu tutar
    public class Particle
    {
        public double[] Position;      // Parçacığın mevcut pozisyonu (boyutlu dizi)
        public double[] Velocity;      // Parçacığın hızı
        public double[] BestPosition;  // Parçacığın kendi bulduğu en iyi pozisyon
        public double BestFitness;     // Parçacığın en iyi fitness değeri (minimize edilen değer)

        // Constructor: Boyut sayısına göre dizileri oluşturur, fitness başlangıçta çok büyük atanır
        public Particle(int dimension)
        {
            Position = new double[dimension];
            Velocity = new double[dimension];
            BestPosition = new double[dimension];
            BestFitness = double.MaxValue; // Başlangıçta en kötü (maksimum) fitness
        }
    }

    // PSO (Particle Swarm Optimization) algoritmasının ana sınıfı
    public class PSO
    {
        
        public int ParticleCount;      
        public int Dimension;          
        public double C1, C2;          
        public double MinPosition;     
        public double MaxPosition;     
        public double VMax;            
        public string StopCriteria;    
        public int MaxIterations;      
        public double Epsilon;         
        public double ConvergenceValue;

        // Algoritmanın durumu
        public List<Particle> Particles;          
        public double[] GlobalBestPosition;       // Sürü genelinde bulunan en iyi pozisyon
        public double GlobalBestFitness = double.MaxValue; 
        public List<double> BestFitnessHistory = new List<double>(); 

        Random rand = new Random(); // Rastgele sayı üreteci

        // Constructor: Parametreleri alır ve sınıf değişkenlerine atar, dizileri oluşturur
        public PSO(int particleCount, int dimension, double c1, double c2,
            double minPos, double maxPos,
            string stopCriteria, int maxIter,
            double epsilon, double convergenceValue,
            double vmax = 1.0)
        {
            ParticleCount = particleCount;
            Dimension = dimension;
            C1 = c1;
            C2 = c2;
            MinPosition = minPos;
            MaxPosition = maxPos;
            StopCriteria = stopCriteria;
            MaxIterations = maxIter;
            Epsilon = epsilon;
            ConvergenceValue = convergenceValue;
            VMax = vmax;

            Particles = new List<Particle>();
            GlobalBestPosition = new double[Dimension];
        }

        // Parçacıkları başlatır, rastgele pozisyon ve hız verir, en iyi pozisyonları atar
        public void Initialize()
        {
            Particles.Clear();

            for (int i = 0; i < ParticleCount; i++)
            {
                Particle p = new Particle(Dimension);

                for (int d = 0; d < Dimension; d++)
                {
                    
                    p.Position[d] = MinPosition + rand.NextDouble() * (MaxPosition - MinPosition);

                  
                    p.Velocity[d] = (rand.NextDouble() * 2 - 1) * VMax;

              
                    p.BestPosition[d] = p.Position[d];
                }

       
                p.BestFitness = FitnessFunction(p.Position);

           
                if (p.BestFitness < GlobalBestFitness)
                {
                    GlobalBestFitness = p.BestFitness;
                    Array.Copy(p.Position, GlobalBestPosition, Dimension);
                }

                Particles.Add(p);
            }

            BestFitnessHistory.Clear();
            BestFitnessHistory.Add(GlobalBestFitness);
        }

        // PSO algoritmasını çalıştırır
        public void Run()
        {
            Initialize();

            int iteration = 0;
            bool stop = false;

            while (!stop)
            {
                iteration++;

                // Her parçacık için fitness değerini hesapla ve en iyi pozisyonları güncelle
                foreach (var p in Particles)
                {
                    double fitness = FitnessFunction(p.Position);

                    if (fitness < p.BestFitness)
                    {
                        p.BestFitness = fitness;
                        Array.Copy(p.Position, p.BestPosition, Dimension);
                    }

                    if (fitness < GlobalBestFitness)
                    {
                        GlobalBestFitness = fitness;
                        Array.Copy(p.Position, GlobalBestPosition, Dimension);
                    }
                }

             
                BestFitnessHistory.Add(GlobalBestFitness);

                // Her parçacığın hız ve pozisyonunu güncelle
                foreach (var p in Particles)
                {
                    for (int d = 0; d < Dimension; d++)
                    {
                        double r1 = rand.NextDouble();
                        double r2 = rand.NextDouble();

                        // PSO hız güncelleme denklemi
                        p.Velocity[d] = p.Velocity[d] +
                                        C1 * r1 * (p.BestPosition[d] - p.Position[d]) +
                                        C2 * r2 * (GlobalBestPosition[d] - p.Position[d]);

                        // Hızı sınırla
                        if (p.Velocity[d] > VMax) p.Velocity[d] = VMax;
                        if (p.Velocity[d] < -VMax) p.Velocity[d] = -VMax;

                        // Pozisyonu güncelle
                        p.Position[d] += p.Velocity[d];

                        // Pozisyonu sınırla
                        if (p.Position[d] > MaxPosition) p.Position[d] = MaxPosition;
                        if (p.Position[d] < MinPosition) p.Position[d] = MinPosition;
                    }
                }

            
                if (StopCriteria == "Generation" && iteration >= MaxIterations)
                    stop = true;
                else if (StopCriteria == "Epsilon" && iteration > 1)
                {
                  
                    double diff = Math.Abs(BestFitnessHistory[BestFitnessHistory.Count - 1] - BestFitnessHistory[BestFitnessHistory.Count - 2]);
                    if (diff < Epsilon)
                        stop = true;
                }
                else if (StopCriteria == "Convergence")
                {
                  
                    if (GlobalBestFitness <= ConvergenceValue)
                        stop = true;
                }

                if (iteration >= 100000)
                    stop = true;
            }
        }

        // Fitness fonksiyonu: optimize edilen problem (Six-hump camel-back fonksiyonu, 2 boyutlu)
        private double FitnessFunction(double[] position)
        {
            double x1 = position[0];
            double x2 = position[1];

            double term1 = (4 - 2.1 * Math.Pow(x1, 2) + Math.Pow(x1, 4) / 3) * Math.Pow(x1, 2);
            double term2 = x1 * x2;
            double term3 = (-4 + 4 * Math.Pow(x2, 2)) * Math.Pow(x2, 2);

            return term1 + term2 + term3;
        }
    }
}
