using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution {
    public partial class FormTip : Form {

        EChapter chapter;
        int i;

        public FormTip(EChapter chapter) {
            InitializeComponent();
            this.chapter = chapter;

            picBoxPlot.Size = GameSystem.screen;
        }

        private void FormTip_Load(object sender, EventArgs e) {
            if (chapter == EChapter.Tutorial) {
                picBoxPlot.Image = Resources.Chapter1op1;
            } else if (chapter == EChapter.Survival) {
                picBoxPlot.Image = Resources.Chapter2gif;
                timerGif.Interval = 20000;
                timerGif.Start();
            }
        }

        private void FormTip_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                NextImage();
            }
        }

        private void picBoxPlot_Click(object sender, EventArgs e) {
            NextImage();
        }

        private void NextImage() {
            if (chapter == EChapter.Tutorial) {
                if (i == 0) {
                    picBoxPlot.Image = Resources.Chapter1op2;
                } else if (i == 1){
                    picBoxPlot.Image = Resources.Chapter1gif;
                    timerGif.Interval = 12500;
                    timerGif.Start();
                } else {
                    End();
                }
                i++;
            } else if (chapter == EChapter.Survival) {
                if (i == 0) {
                    picBoxPlot.Image = Resources.Chapter2final;
                } else {
                    End();
                }
                i++;
            }
        }

        private void End() {
            DialogResult = DialogResult.OK;
        }

        private void timerGif_Tick(object sender, EventArgs e) {
            if (chapter == EChapter.Tutorial) {
                picBoxPlot.Image = Resources.Chapter1final;
            } else if (chapter == EChapter.Survival) {
                picBoxPlot.Image = Resources.Chapter2gifEnd;
            }
            timerGif.Stop();
        }
    }
}
