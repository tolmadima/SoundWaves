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
            this.oscillator1 = new Waves.Oscillator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oscillator1
            // 
            this.oscillator1.Location = new System.Drawing.Point(29, 34);
            this.oscillator1.Name = "oscillator1";
            this.oscillator1.Size = new System.Drawing.Size(200, 100);
            this.oscillator1.TabIndex = 0;
            this.oscillator1.TabStop = false;
            this.oscillator1.Text = "oscillator1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Клавиши Z-N запуск сигнала с различными частотами";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WaveGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.oscillator1);
            this.KeyPreview = true;
            this.Name = "WaveGenerator";
            this.Text = "WaveGenerator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WaveGenerator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oscillator oscillator1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

