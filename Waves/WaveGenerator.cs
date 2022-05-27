using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Threading;
using System.Diagnostics;

namespace Waves
{
    public partial class WaveGenerator : Form
    {
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;
        private double frequency;
        CancellationTokenSource _tokenSource;
        byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)];
        public WaveGenerator()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            frequency = (double)numericUpDown1.Value;
            PlaySound(OscillatorGen(frequency));
        }

        public void PlaySound(short[] wave)
        {
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                {
                    short blockAlign = BITS_PER_SAMPLE / 8;
                    int subChunkTwoSize = SAMPLE_RATE * blockAlign;
                    binaryWriter.Write(new[] { 'R', 'I', 'F', 'F' });
                    binaryWriter.Write(36 + subChunkTwoSize);
                    binaryWriter.Write(new[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                    binaryWriter.Write(16);
                    binaryWriter.Write((short)1);
                    binaryWriter.Write((short)1);
                    binaryWriter.Write(SAMPLE_RATE);
                    binaryWriter.Write(SAMPLE_RATE * blockAlign);
                    binaryWriter.Write(blockAlign);
                    binaryWriter.Write(BITS_PER_SAMPLE);
                    binaryWriter.Write(new[] { 'd', 'a', 't', 'a' });
                    binaryWriter.Write(subChunkTwoSize);
                    binaryWriter.Write(binaryWave);
                    memoryStream.Position = 0;
                    new SoundPlayer(memoryStream).Play();
                }
            }
        }

        public enum WaveForm
        {
            Sine, Square, Saw, Triangle
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        private async void StartSwipe_Click(object sender, EventArgs e)
        {
            _tokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = _tokenSource.Token;
            int start = (int)startFreq.Value;
            int end = (int)endFreq.Value;
            int step = (int)stepFreq.Value;
            try
            {
                await Task.Run(() => Swipe(cancelToken, start, end, step), cancelToken);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Остановлено");
            }
            catch (Exception ex)
            {
            }
        }

        private void Swipe(CancellationToken cancelToken, int start, int end, int step)
        {
            for (int q = start; q != end; q += step)
            {
                PlaySound(OscillatorGen(q));
                System.Threading.Thread.Sleep(((int)pauseTiming.Value) * 1000);
                cancelToken.ThrowIfCancellationRequested();
            }
            MessageBox.Show("Выполнено");
            return;
        }

        private void StopSwipe_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        public void Play() { 
        }

        private short[] OscillatorGen(double frequency)
        {
            IEnumerable<Oscillator> oscillators = this.Controls.OfType<Oscillator>().Where(o => o.On);
            short[] wave = new short[SAMPLE_RATE];
            int oscillatorsCount = oscillators.Count();
            foreach (Oscillator oscillator in oscillators)
            {
                int samplesPerWaveLength = (int)(SAMPLE_RATE / frequency);
                short ampStep = (short)((short.MaxValue * 2) / samplesPerWaveLength);
                short tempSample;
                switch (oscillator.WaveForm)
                {
                    case WaveForm.Sine:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SAMPLE_RATE) * i)) / oscillatorsCount);
                        }
                        break;

                    case WaveForm.Square:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sign(Math.Sin((Math.PI * 2 * frequency) / SAMPLE_RATE * i))) / oscillatorsCount);
                        }
                        break;

                    case WaveForm.Saw:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            tempSample = -short.MaxValue;
                            for (int j = 0; j < samplesPerWaveLength && i < SAMPLE_RATE; j++)
                            {
                                tempSample += ampStep;
                                wave[i++] += Convert.ToInt16(tempSample / oscillatorsCount);
                            }
                            i--;
                        }
                        break;
                    case WaveForm.Triangle:
                        tempSample = -short.MaxValue;
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            if (Math.Abs(tempSample + ampStep) > short.MaxValue)
                            {
                                ampStep = (short)-ampStep;
                            }
                            tempSample += ampStep;
                            wave[i] += Convert.ToInt16(tempSample / oscillatorsCount);
                        }
                        break;
                }
            }
            return wave;
        }

        private void stepFreq_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
