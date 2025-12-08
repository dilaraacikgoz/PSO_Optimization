namespace PSO_Optimization
{
    partial class q
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblParticleCount = new System.Windows.Forms.Label();
            this.nudParticleCount = new System.Windows.Forms.NumericUpDown();
            this.lblMaxIteration = new System.Windows.Forms.Label();
            this.nudMaxIteration = new System.Windows.Forms.NumericUpDown();
            this.lblC1 = new System.Windows.Forms.Label();
            this.nudC1 = new System.Windows.Forms.NumericUpDown();
            this.lblC2 = new System.Windows.Forms.Label();
            this.nudC2 = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.chartConvergence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblMinPosition = new System.Windows.Forms.Label();
            this.nudMinPosition = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPosition = new System.Windows.Forms.Label();
            this.nudMaxPosition = new System.Windows.Forms.NumericUpDown();
            this.rbtnStopGen = new System.Windows.Forms.RadioButton();
            this.rbtnStopEpsilon = new System.Windows.Forms.RadioButton();
            this.rbtnStopConverge = new System.Windows.Forms.RadioButton();
            this.txtStopValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParticleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParticleCount
            // 
            this.lblParticleCount.AutoSize = true;
            this.lblParticleCount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParticleCount.Location = new System.Drawing.Point(6, 32);
            this.lblParticleCount.Name = "lblParticleCount";
            this.lblParticleCount.Size = new System.Drawing.Size(115, 21);
            this.lblParticleCount.TabIndex = 0;
            this.lblParticleCount.Text = "Parçacık Sayısı:";
            // 
            // nudParticleCount
            // 
            this.nudParticleCount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudParticleCount.Location = new System.Drawing.Point(206, 30);
            this.nudParticleCount.Name = "nudParticleCount";
            this.nudParticleCount.Size = new System.Drawing.Size(120, 28);
            this.nudParticleCount.TabIndex = 1;
            // 
            // lblMaxIteration
            // 
            this.lblMaxIteration.AutoSize = true;
            this.lblMaxIteration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxIteration.Location = new System.Drawing.Point(6, 70);
            this.lblMaxIteration.Name = "lblMaxIteration";
            this.lblMaxIteration.Size = new System.Drawing.Size(163, 21);
            this.lblMaxIteration.TabIndex = 4;
            this.lblMaxIteration.Text = "Maksimum İterasyon:";
            // 
            // nudMaxIteration
            // 
            this.nudMaxIteration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMaxIteration.Location = new System.Drawing.Point(206, 68);
            this.nudMaxIteration.Name = "nudMaxIteration";
            this.nudMaxIteration.Size = new System.Drawing.Size(120, 28);
            this.nudMaxIteration.TabIndex = 5;
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblC1.Location = new System.Drawing.Point(6, 106);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(159, 21);
            this.lblC1.TabIndex = 6;
            this.lblC1.Text = "Öğrenme Faktörü C1:";
            // 
            // nudC1
            // 
            this.nudC1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudC1.Location = new System.Drawing.Point(206, 104);
            this.nudC1.Name = "nudC1";
            this.nudC1.Size = new System.Drawing.Size(120, 28);
            this.nudC1.TabIndex = 7;
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblC2.Location = new System.Drawing.Point(6, 142);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(159, 21);
            this.lblC2.TabIndex = 8;
            this.lblC2.Text = "Öğrenme Faktörü C2:";
            // 
            // nudC2
            // 
            this.nudC2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudC2.Location = new System.Drawing.Point(206, 140);
            this.nudC2.Name = "nudC2";
            this.nudC2.Size = new System.Drawing.Size(120, 28);
            this.nudC2.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(435, 361);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 48);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Algoritmayı Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chartConvergence
            // 
            chartArea1.Name = "ChartArea1";
            this.chartConvergence.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartConvergence.Legends.Add(legend1);
            this.chartConvergence.Location = new System.Drawing.Point(435, 37);
            this.chartConvergence.Name = "chartConvergence";
            this.chartConvergence.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartConvergence.Series.Add(series1);
            this.chartConvergence.Size = new System.Drawing.Size(300, 300);
            this.chartConvergence.TabIndex = 11;
            this.chartConvergence.Text = "chart1";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLog.Location = new System.Drawing.Point(435, 425);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(300, 29);
            this.txtLog.TabIndex = 12;
            // 
            // lblMinPosition
            // 
            this.lblMinPosition.AutoSize = true;
            this.lblMinPosition.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinPosition.Location = new System.Drawing.Point(2, 31);
            this.lblMinPosition.Name = "lblMinPosition";
            this.lblMinPosition.Size = new System.Drawing.Size(70, 22);
            this.lblMinPosition.TabIndex = 13;
            this.lblMinPosition.Text = "Alt Sınır:";
            // 
            // nudMinPosition
            // 
            this.nudMinPosition.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMinPosition.Location = new System.Drawing.Point(77, 25);
            this.nudMinPosition.Name = "nudMinPosition";
            this.nudMinPosition.Size = new System.Drawing.Size(120, 28);
            this.nudMinPosition.TabIndex = 14;
            // 
            // lblMaxPosition
            // 
            this.lblMaxPosition.AutoSize = true;
            this.lblMaxPosition.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPosition.Location = new System.Drawing.Point(2, 61);
            this.lblMaxPosition.Name = "lblMaxPosition";
            this.lblMaxPosition.Size = new System.Drawing.Size(74, 21);
            this.lblMaxPosition.TabIndex = 15;
            this.lblMaxPosition.Text = "Üst Sınır:";
            // 
            // nudMaxPosition
            // 
            this.nudMaxPosition.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMaxPosition.Location = new System.Drawing.Point(77, 59);
            this.nudMaxPosition.Name = "nudMaxPosition";
            this.nudMaxPosition.Size = new System.Drawing.Size(120, 28);
            this.nudMaxPosition.TabIndex = 16;
            // 
            // rbtnStopGen
            // 
            this.rbtnStopGen.AutoSize = true;
            this.rbtnStopGen.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnStopGen.Location = new System.Drawing.Point(7, 22);
            this.rbtnStopGen.Name = "rbtnStopGen";
            this.rbtnStopGen.Size = new System.Drawing.Size(157, 26);
            this.rbtnStopGen.TabIndex = 18;
            this.rbtnStopGen.TabStop = true;
            this.rbtnStopGen.Text = "\tJenerasyon Sayısı";
            this.rbtnStopGen.UseVisualStyleBackColor = true;
            // 
            // rbtnStopEpsilon
            // 
            this.rbtnStopEpsilon.AutoSize = true;
            this.rbtnStopEpsilon.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnStopEpsilon.Location = new System.Drawing.Point(6, 48);
            this.rbtnStopEpsilon.Name = "rbtnStopEpsilon";
            this.rbtnStopEpsilon.Size = new System.Drawing.Size(134, 26);
            this.rbtnStopEpsilon.TabIndex = 19;
            this.rbtnStopEpsilon.TabStop = true;
            this.rbtnStopEpsilon.Text = "Epsilon Değeri";
            this.rbtnStopEpsilon.UseVisualStyleBackColor = true;
            // 
            // rbtnStopConverge
            // 
            this.rbtnStopConverge.AutoSize = true;
            this.rbtnStopConverge.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnStopConverge.Location = new System.Drawing.Point(6, 74);
            this.rbtnStopConverge.Name = "rbtnStopConverge";
            this.rbtnStopConverge.Size = new System.Drawing.Size(159, 26);
            this.rbtnStopConverge.TabIndex = 20;
            this.rbtnStopConverge.TabStop = true;
            this.rbtnStopConverge.Text = "Yakınsama Değeri";
            this.rbtnStopConverge.UseVisualStyleBackColor = true;
            // 
            // txtStopValue
            // 
            this.txtStopValue.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStopValue.Location = new System.Drawing.Point(251, 497);
            this.txtStopValue.Name = "txtStopValue";
            this.txtStopValue.Size = new System.Drawing.Size(115, 29);
            this.txtStopValue.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.rbtnStopConverge);
            this.groupBox1.Controls.Add(this.rbtnStopEpsilon);
            this.groupBox1.Controls.Add(this.rbtnStopGen);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonlanma Kriteri Seçiniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMinPosition);
            this.groupBox2.Controls.Add(this.nudMinPosition);
            this.groupBox2.Controls.Add(this.lblMaxPosition);
            this.groupBox2.Controls.Add(this.nudMaxPosition);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(30, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınır Değerleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblC2);
            this.groupBox3.Controls.Add(this.lblC1);
            this.groupBox3.Controls.Add(this.lblMaxIteration);
            this.groupBox3.Controls.Add(this.lblParticleCount);
            this.groupBox3.Controls.Add(this.nudParticleCount);
            this.groupBox3.Controls.Add(this.nudMaxIteration);
            this.groupBox3.Controls.Add(this.nudC1);
            this.groupBox3.Controls.Add(this.nudC2);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(30, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 180);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametreler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Geçerli Sonlanma Değeri:";
            // 
            // q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStopValue);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.chartConvergence);
            this.Controls.Add(this.btnStart);
            this.Name = "q";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.q_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudParticleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPosition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParticleCount;
        private System.Windows.Forms.NumericUpDown nudParticleCount;
        private System.Windows.Forms.Label lblMaxIteration;
        private System.Windows.Forms.NumericUpDown nudMaxIteration;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.NumericUpDown nudC1;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.NumericUpDown nudC2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConvergence;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblMinPosition;
        private System.Windows.Forms.NumericUpDown nudMinPosition;
        private System.Windows.Forms.Label lblMaxPosition;
        private System.Windows.Forms.NumericUpDown nudMaxPosition;
        private System.Windows.Forms.RadioButton rbtnStopGen;
        private System.Windows.Forms.RadioButton rbtnStopEpsilon;
        private System.Windows.Forms.RadioButton rbtnStopConverge;
        private System.Windows.Forms.TextBox txtStopValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}

