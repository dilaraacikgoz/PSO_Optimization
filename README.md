# PSO Optimization App (Particle Swarm Optimization)

Bu proje, **Parçacık Sürüsü Optimizasyonu (Particle Swarm Optimization - PSO)** algoritmasının  
C# ile uygulanmış bir örneğidir. PSO, doğadan ilham alan sezgisel bir optimizasyon yöntemidir ve bu projede **Six-Hump Camelback fonksiyonunu** optimize etmek için kullanılmıştır.

---

## 🎯 Proje Amacı

Bu uygulama PSO’nun:

- Parçacıkların pozisyon ve hız güncellemeleri  
- Global ve local best kavramları  
- Iterasyon bazlı iyileşme takibi  
- Durdurma kriterleri (Generation, Epsilon, Convergence)

gibi temel mantığını göstermeyi amaçlar.

---

## 🧠 Kullanılan Test Fonksiyonu

**Six-Hump Camelback Function**

Bu fonksiyon, optimizasyon literatüründe çok kullanılan, iki boyutlu, çoklu lokal minima içeren bir fonksiyondur.

Formülü:

\[
f(x_1, x_2) = (4 - 2.1x_1^2 + \frac{x_1^4}{3})x_1^2 + x_1x_2 + (-4 + 4x_2^2)x_2^2
\]

Global minimum noktaları:

- (0.0898, -0.7126)
- (-0.0898, 0.7126)

Global minimum değeri yaklaşık: **-1.0316**

---

## ⚙️ PSO Parametreleri

Proje içerisinde aşağıdaki ayarlar desteklenir:

### **Sürü ayarları**
- Parçacık sayısı (ParticleCount)
- Boyut (Dimension)

### **Öğrenme katsayıları**
- C1 → Cognitive (bireysel öğrenme)
- C2 → Social (sürü öğrenmesi)

### **Pozisyon ve hız sınırları**
- Minimum pozisyon (MinPosition)
- Maksimum pozisyon (MaxPosition)
- Maksimum hız (VMax)

### **Durdurma kriterleri**
- **Generation:** Belirli iterasyon sayısından sonra durur  
- **Epsilon:** Fitness değişimi çok küçükse durur  
- **Convergence:** Fitness değeri belirlenen seviyenin altına inerse durur  

---

## 📌 Proje Yapısı

### **Particle.cs**
- Parçacığın pozisyon, hız ve en iyi (personal best) bilgilerini tutar.

### **PSO.cs**
- PSO algoritmasının tamamını içerir:
  - Başlatma (Initialize)
  - Hız güncelleme formülü
  - Pozisyon güncelleme
  - Fitness hesaplama
  - Global en iyi değerin güncellenmesi

---

## 📈 Fitness Takibi

Her iterasyonda bulunan **En iyi fitness değeri**,  
`BestFitnessHistory` listesine eklenir.

Bu sayede grafik ya da raporlama için kullanılabilir.

---

## 🚀 Kurulum ve Çalıştırma

1. Projeyi clonelayın:

   ```bash
   git clone https://github.com/KULLANICI_ADIN/PSO_Optimization.git
