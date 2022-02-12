namespace Waves
{
    partial class WaveGenerator
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.startFreq = new System.Windows.Forms.NumericUpDown();
            this.endFreq = new System.Windows.Forms.NumericUpDown();
            this.stepFreq = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.StartSwipe = new System.Windows.Forms.Button();
            this.StopSwipe = new System.Windows.Forms.Button();
            this.pauseTiming = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.oscillator2 = new Waves.Oscillator();
            this.oscillator1 = new Waves.Oscillator();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseTiming)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(424, 202);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(359, 227);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // startFreq
            // 
            this.startFreq.Location = new System.Drawing.Point(195, 298);
            this.startFreq.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this.startFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startFreq.Name = "startFreq";
            this.startFreq.Size = new System.Drawing.Size(120, 20);
            this.startFreq.TabIndex = 6;
            this.startFreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // endFreq
            // 
            this.endFreq.Location = new System.Drawing.Point(195, 324);
            this.endFreq.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this.endFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endFreq.Name = "endFreq";
            this.endFreq.Size = new System.Drawing.Size(120, 20);
            this.endFreq.TabIndex = 7;
            this.endFreq.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // stepFreq
            // 
            this.stepFreq.Location = new System.Drawing.Point(195, 350);
            this.stepFreq.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this.stepFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepFreq.Name = "stepFreq";
            this.stepFreq.Size = new System.Drawing.Size(120, 20);
            this.stepFreq.TabIndex = 8;
            this.stepFreq.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Начальная частота";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Конечная частота";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 350);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Шаг";
            // 
            // StartSwipe
            // 
            this.StartSwipe.Location = new System.Drawing.Point(54, 376);
            this.StartSwipe.Name = "StartSwipe";
            this.StartSwipe.Size = new System.Drawing.Size(75, 23);
            this.StartSwipe.TabIndex = 12;
            this.StartSwipe.Text = "Start";
            this.StartSwipe.UseVisualStyleBackColor = true;
            this.StartSwipe.Click += new System.EventHandler(this.StartSwipe_Click);
            // 
            // StopSwipe
            // 
            this.StopSwipe.Location = new System.Drawing.Point(216, 376);
            this.StopSwipe.Name = "StopSwipe";
            this.StopSwipe.Size = new System.Drawing.Size(75, 23);
            this.StopSwipe.TabIndex = 13;
            this.StopSwipe.Text = "Stop";
            this.StopSwipe.UseVisualStyleBackColor = true;
            this.StopSwipe.Click += new System.EventHandler(this.StopSwipe_Click);
            // 
            // pauseTiming
            // 
            this.pauseTiming.Location = new System.Drawing.Point(524, 299);
            this.pauseTiming.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this.pauseTiming.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pauseTiming.Name = "pauseTiming";
            this.pauseTiming.Size = new System.Drawing.Size(120, 20);
            this.pauseTiming.TabIndex = 14;
            this.pauseTiming.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(359, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Пауза";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(216, 202);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Начальная частота";
            // 
            // oscillator2
            // 
            this.oscillator2.Location = new System.Drawing.Point(424, 34);
            this.oscillator2.Name = "oscillator2";
            this.oscillator2.Size = new System.Drawing.Size(353, 161);
            this.oscillator2.TabIndex = 1;
            this.oscillator2.TabStop = false;
            this.oscillator2.Text = "oscillator2";
            // 
            // oscillator1
            // 
            this.oscillator1.Location = new System.Drawing.Point(21, 34);
            this.oscillator1.Name = "oscillator1";
            this.oscillator1.Size = new System.Drawing.Size(353, 161);
            this.oscillator1.TabIndex = 0;
            this.oscillator1.TabStop = false;
            this.oscillator1.Text = "oscillator1";
            // 
            // WaveGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pauseTiming);
            this.Controls.Add(this.StopSwipe);
            this.Controls.Add(this.StartSwipe);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stepFreq);
            this.Controls.Add(this.endFreq);
            this.Controls.Add(this.startFreq);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.oscillator2);
            this.Controls.Add(this.oscillator1);
            this.Name = "WaveGenerator";
            this.Text = "WaveGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseTiming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oscillator oscillator1;
        private Oscillator oscillator2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.NumericUpDown startFreq;
        private System.Windows.Forms.NumericUpDown endFreq;
        private System.Windows.Forms.NumericUpDown stepFreq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button StartSwipe;
        private System.Windows.Forms.Button StopSwipe;
        private System.Windows.Forms.NumericUpDown pauseTiming;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

