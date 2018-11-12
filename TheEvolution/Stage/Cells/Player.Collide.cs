using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;
using TheEvolution.Stage.Organella;

namespace TheEvolution.Stage.Cells {
    partial class Player {

        public void CollideFood() {
            if (!isShocked) {
                if (!isSick) {
                    images = imgPlayerEat;
                } else {
                    images = imgPlayerSickEat;
                }
            }
            imgIndex = 0;
            if (foodCount < 3) {
                if (hp != 10) {
                    foodCount++;
                }
            } else {
                foodCount = 0;
                Hp += 1;
            }
            Eat(this, new PlayerEventArgs(foodCount, hp));
        }

        public void CollideCompetitor(Competitor competitor) {
            BumpMove(competitor);
            Hp -= 1;
        }

        public virtual void KillCompetitor(object sender, EventArgs e) {
            for (int i = 0; i < 25; i++) {
                CollideFood();
            }
        }

        public void CollideVirus() {
            sickInterval = 150;
            isSick = true;
            images = imgPlayerSick;
        }

        public void CollidePredator(Cell Predator) {
            Hp -= 1;
            BumpMove(Predator);
        }

        public void CollideShocker(Cell shocker) {
            BumpMove(shocker);
            shockInterval = 60;
            isShocked = true;
            images = imgPlayerShocked;
            moveSpeed = 0;
        }

        public void CollideTracker(Cell tracker) {
            if (!isHidden) {
                isHidden = true;
            } else {
                isHidden = false;
            }
        }

        public void CollidePlantWall(Cell plantWall) {
            BumpMove(plantWall);
        }

        public void BumpMove(Cell c) {
            direction = GetDirectionToTarget(c);
            direction.X -= 2 * direction.X;
            direction.Y -= 2 * direction.Y;
            int tempX, tempY;
            tempX = position.X + (int)(direction.X * 1.2);
            tempY = position.Y + (int)(direction.Y * 1.2);
            if (tempX > -GameSystem.screen.Width || tempX < 2 * GameSystem.screen.Width) {
                position.X = tempX;
            }
            if (tempY > -GameSystem.screen.Height || tempY < 2 * GameSystem.screen.Height) {
                position.Y = tempY;
            }
        }

        public void CollideOrganelle(Organelle o) {
            if (o is Mitochondria) {
                imgPlayer = imgPlayerMito;
            } else if (o is Lysosome) {
                imgPlayer = imgPlayerMitoLyso;
            } else if (o is ER) {
                imgPlayer = imgPlayerMitoLysoER;
            } else if (o is Centromere) {
                imgPlayer = imgPlayerComplete;
                if (GameSystem.formStage.chapterSurvival != null) {
                    GameSystem.formStage.Invoke(
                (Action)delegate () { GameSystem.formStage.gonnaEvolve.Start(); });
                }
            }
            images = imgPlayer;
        }

        private void gonnaEnvolve_Tick(object sender, EventArgs e) {
            imgPlayer = imgPlayerFinal;
            imgPlayerEat = imgPlayerFinalEat;
            images = imgPlayer;
            GameSystem.formStage.Invoke((Action)delegate() {
                GameSystem.formStage.Pause_Click(this, EventArgs.Empty);
                GameSystem.formStage.gonnaEvolve.Stop();
            });
        }
    }
}
