using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Waves
{
    public class Swipe : GroupBox
    {
        public Swipe()
        {
            this.Controls.Add(new NumericUpDown()
            {
                Name = "OrigFreq",
                Location = new Point(180, 10),
            });
            this.Controls.Add(new NumericUpDown()
            {
                Name = "EndFreq",
                Location = new Point(180, 35),
            });
            this.Controls.Add(new NumericUpDown()
            {
                Name = "FrequencyChange",
                Location = new Point(180, 60),
            });
            this.Controls.Add(new TextBox()
            {
                Name = "OrigFreqText",
                Location = new Point(40, 10),
                Text = "Начальная частота",
                Width = 120
            });
            this.Controls.Add(new TextBox()
            {
                Name = "EndFreqText",
                Location = new Point(40, 35),
                Text = "Конечная частота",
                Width = 120
            });
            this.Controls.Add(new TextBox()
            {
                Name = "FrequencyChangeText",
                Location = new Point(40, 60),
                Text = "Размер шага",
                Width = 120
            });
            this.Controls.Add(new Button()
            {
                Text = "Start",
                Name = "StartSwipe",
                Location = new Point(50, 90),
            });
            this.Controls.Add(new Button()
            {
                Text = "Stop",
                Name = "StopSwipe",
                Location = new Point(190, 90),
            }); ;
        }
            
    }
}
