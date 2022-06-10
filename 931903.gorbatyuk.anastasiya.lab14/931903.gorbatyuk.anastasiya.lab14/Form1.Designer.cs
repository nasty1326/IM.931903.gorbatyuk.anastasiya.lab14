
namespace _931903.gorbatyuk.anastasiya.lab14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPeople = new System.Windows.Forms.Label();
            this.lbAllPeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numVhod = new System.Windows.Forms.NumericUpDown();
            this.numOperator = new System.Windows.Forms.NumericUpDown();
            this.numSer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVhod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numSer);
            this.panel1.Controls.Add(this.numOperator);
            this.panel1.Controls.Add(this.numVhod);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 100);
            this.panel1.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(25, 31);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(128, 38);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(185, 31);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(128, 38);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество людей в очереди:";
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Location = new System.Drawing.Point(235, 161);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(20, 17);
            this.lbPeople.TabIndex = 3;
            this.lbPeople.Text = " 0";
            // 
            // lbAllPeople
            // 
            this.lbAllPeople.AutoSize = true;
            this.lbAllPeople.Location = new System.Drawing.Point(133, 125);
            this.lbAllPeople.Name = "lbAllPeople";
            this.lbAllPeople.Size = new System.Drawing.Size(20, 17);
            this.lbAllPeople.TabIndex = 5;
            this.lbAllPeople.Text = " 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Всего людей:";
            // 
            // numVhod
            // 
            this.numVhod.Location = new System.Drawing.Point(1042, 47);
            this.numVhod.Name = "numVhod";
            this.numVhod.Size = new System.Drawing.Size(78, 22);
            this.numVhod.TabIndex = 2;
            // 
            // numOperator
            // 
            this.numOperator.Location = new System.Drawing.Point(441, 47);
            this.numOperator.Name = "numOperator";
            this.numOperator.Size = new System.Drawing.Size(78, 22);
            this.numOperator.TabIndex = 3;
            // 
            // numSer
            // 
            this.numSer.Location = new System.Drawing.Point(711, 47);
            this.numSer.Name = "numSer";
            this.numSer.Size = new System.Drawing.Size(78, 22);
            this.numSer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Операторов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сервисный параметр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Параметр для входящего потока";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(292, 116);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(828, 431);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 559);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbAllPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVhod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSer;
        private System.Windows.Forms.NumericUpDown numOperator;
        private System.Windows.Forms.NumericUpDown numVhod;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.Label lbAllPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

