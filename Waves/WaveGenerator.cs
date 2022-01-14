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

namespace Waves
{
    public partial class WaveGenerator : Form
    {
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;
        public WaveGenerator()
        {
            InitializeComponent();
        }

        private void WaveGenerator_KeyDown(object sender, KeyEventArgs e)
        {
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)];
            float frequency;
            switch (e.KeyCode)
            {
                case Keys.Z:
                    frequency = 65.4f;
                    break;
                case Keys.X:
                    frequency = 138.59f;
                    break;
                case Keys.C:
                    frequency = 261.62f;
                    break;
                case Keys.V:
                    frequency = 523.25f;
                    break;
                case Keys.B:
                    frequency = 2093f;
                    break;
                case Keys.N:
                    frequency = 4186.01f;
                    break;
                default:
                    return;
            }
            foreach (Oscillator oscillator in this.Controls.OfType<Oscillator>())
            {
                int samplesPerWaveLength = (int)(SAMPLE_RATE / frequency);
                short ampStep = (short)((short.MaxValue * 2) / samplesPerWaveLength);
                short tempSample;
                switch (oscillator.WaveForm)
                {
                    case WaveForm.Sine:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SAMPLE_RATE) * i));
                        }
                        break;

                    case WaveForm.Square:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] = Convert.ToInt16(short.MaxValue * Math.Sign(Math.Sin((Math.PI * 2 * frequency) / SAMPLE_RATE * i)));
                        }
                        break;

                    case WaveForm.Saw:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            tempSample = -short.MaxValue;
                            for (int j = 0; j < samplesPerWaveLength && i < SAMPLE_RATE; j++)
                            {
                                tempSample += ampStep;
                                wave[i++] = Convert.ToInt16(tempSample);
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
                            wave[i] = Convert.ToInt16(tempSample);
                        }
                        break;
                }
            }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
    public enum WaveForm
    {
        Sine, Square, Saw, Triangle
    }
}
