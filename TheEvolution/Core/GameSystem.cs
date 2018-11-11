using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using TheEvolution.Stage.Cells;
using TheEvolution.Properties;

namespace TheEvolution.Core {
    static class GameSystem {

        public static Size screen;
        public static FormStart formStart;
        public static FormStage formStage;
        public static FormEnd formEnd;
        public static Chapter chapter;
        public static PictureBox picBoxStage;
        public static Player player;
        public static List<Competitor> competitors = new List<Competitor>();
        public static List<Cell> otherCells = new List<Cell>();
        public static List<Food> foods = new List<Food>();
        public static List<Organelle> organella = new List<Organelle>();
        public static List<Painter> painters = new List<Painter>();
        public static bool isStart;

        public static void Act() {
            while (isStart) {
                if (player.Hp == 0) {
                    formStage.Invoke((Action)delegate () {
                        formStage.GameOver();
                    });
                    Thread.Yield();
                }
                player.NextStep();
                CheckPlayerInMap();
                foreach (Competitor c in competitors) {
                    c.NextStep();
                }
                foreach (Cell c in otherCells) {
                    c.NextStep();
                }
                foreach (Food f in foods) {
                    f.NextStep();
                }
                if (formStage.hpBeatInterval == 0) {
                    formStage.Invoke((Action)delegate () {
                        SetSquareControlSize(formStage.picBoxHp, formStage.panelStatus.Size, 0.06, 0.5, 0.08);
                    });
                } else {
                    formStage.hpBeatInterval--;
                }
                if (formStage.labelTime.Visible) {
                    formStage.Invoke((Action)delegate () {
                        formStage.labelTime.Text = chapter.GetTimeSurvived();
                    });
                }
                picBoxStage.Invalidate();
                Thread.Sleep(50);
            }
        }

        public static void CollisionDetect() {
            while (isStart) {
                GetFood(player);
                foreach (Competitor c in competitors.ToArray()) {
                    GetFood(c);
                }
                CompetitorCollide();
                OtherCellCollide();
                GetOrganelle();
                Thread.Sleep(100);
            }
        }

        public static void GetFood(Cell cell) {
            int i = 0;
            int CellX = cell.GetCenter().X;
            int CellY = cell.GetCenter().Y;
            int CellW = cell.Size.Width;
            int CellH = cell.Size.Height;
            int FoodX, FoodY, FoodW, FoodH;

            foreach (Food f in foods) {
                FoodX = f.GetCenter().X; FoodY = f.GetCenter().Y;
                FoodW = f.Size.Width; FoodH = f.Size.Height;

                if (Math.Abs(FoodX - CellX) <= (FoodW + CellW) / 4) {
                    if (Math.Abs(FoodY - CellY) <= (FoodH + CellH) / 4) {
                        if (cell is ICollideFood) {
                            ICollideFood c = cell as ICollideFood;
                            c.CollideFood();
                        }
                        foods[i].Collide();
                        return;
                    }
                }
                i++;
            }
        }

        public static void GetOrganelle() {
            int i = 0;
            int playerX = player.GetCenter().X;
            int playerY = player.GetCenter().Y;
            int playerW = player.Size.Width;
            int playerH = player.Size.Height;
            int organelleX, organelleY, organelleW, organelleH;

            foreach (Organelle o in organella.ToArray()) {
                organelleX = o.GetCenter().X; organelleY = o.GetCenter().Y;
                organelleW = o.Size.Width; organelleH = o.Size.Height;

                if (Math.Abs(organelleX - playerX) <= (organelleW + playerW) / 4) {
                    if (Math.Abs(organelleY - playerY) <= (organelleH + playerH) / 4) {
                        o.Collide(i);
                        player.CollideOrganelle(o);
                        return;
                    }
                }
                i++;
            }
        }

        public static void CompetitorCollide() {
            int i = 0;
            int playerX = player.GetCenter().X;
            int playerY = player.GetCenter().Y;
            int playerW = player.Size.Width;
            int playerH = player.Size.Height;
            int competitorX, competitorY, competitorW, competitorH;

            foreach (Competitor c in competitors.ToArray()) {
                competitorX = c.GetCenter().X; competitorY = c.GetCenter().Y;
                competitorW = c.Size.Width; competitorH = c.Size.Height;

                if (Math.Abs(competitorX - playerX) <= (competitorW + playerW) / 4) {
                    if (Math.Abs(competitorY - playerY) <= (competitorH + playerH) / 4) {
                        player.CollideCompetitor(c);
                        c.CollidePlayer(i);
                        return;
                    }
                }
                i++;
            }
        }

        public static void OtherCellCollide() {
            int i = 0;
            int playerX = player.GetCenter().X;
            int playerY = player.GetCenter().Y;
            int playerW = player.Size.Width;
            int playerH = player.Size.Height;
            int cellX, cellY, cellW, cellH;

            foreach (Cell c in otherCells.ToArray()) {
                cellX = c.GetCenter().X; cellY = c.GetCenter().Y;
                cellW = c.Size.Width; cellH = c.Size.Height;

                if (Math.Abs(cellX - playerX) <= (cellW + playerW) / 3) {
                    if (Math.Abs(cellY - playerY) <= (cellH + playerH) / 3) {
                        if (c is Virus) {
                            player.CollideVirus();
                            c.Collide(i);
                        } else if (c is Predator) {
                            player.CollidePredator(c);
                        } else if (c is Shocker) {
                            player.CollideShocker(c);
                        } else if (c is Tracker) {
                            player.CollideTracker(c);
                            c.Collide();
                        } else if (c is PlantWall) {
                            player.CollidePlantWall(c);
                        }
                        return;
                    }
                }
                i++;
            }
        }

        public static void CheckPlayerInMap() {
            int height = screen.Height;
            int width = screen.Width;
            if (picBoxStage.Top == 0 && picBoxStage.Left == 0) {
                formStage.picBoxMap.Image = Resources.Map1;
            } else if (picBoxStage.Top == 0 && picBoxStage.Left == -width) {
                formStage.picBoxMap.Image = Resources.Map2;
            } else if (picBoxStage.Top == 0 && picBoxStage.Left == -2 * width) {
                formStage.picBoxMap.Image = Resources.Map3;
            } else if (picBoxStage.Top == -height && picBoxStage.Left == 0) {
                formStage.picBoxMap.Image = Resources.Map4;
            } else if (picBoxStage.Top == -height && picBoxStage.Left == -width) {
                formStage.picBoxMap.Image = Resources.Map5;
            } else if (picBoxStage.Top == -height && picBoxStage.Left == -2 * width) {
                formStage.picBoxMap.Image = Resources.Map6;
            } else if (picBoxStage.Top == - 2 * height && picBoxStage.Left == 0) {
                formStage.picBoxMap.Image = Resources.Map7;
            } else if (picBoxStage.Top == -2 * height && picBoxStage.Left == -width) {
                formStage.picBoxMap.Image = Resources.Map8;
            } else if (picBoxStage.Top == -2 * height && picBoxStage.Left == -2 * width) {
                formStage.picBoxMap.Image = Resources.Map9;
            }
        }

        public static double getDistance(Point p1, Point p2) {
            return Math.Sqrt(
                Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }

        public static void SetControlSize(Control control, Size ClientSize, double ratioX, double ratioY, double ratioW, double ratioH) {
            control.Width = Convert.ToInt32(ClientSize.Width * ratioW);
            control.Height = Convert.ToInt32(ClientSize.Height * ratioH);
            control.Left = Convert.ToInt32(ClientSize.Width * ratioX) - (control.Width / 2);
            control.Top = Convert.ToInt32(ClientSize.Height * ratioY) - (control.Height / 2);
        }

        public static void SetSquareControlSize(Control control, Size ClientSize, double ratioX, double ratioY, double ratioW) {
            control.Width = Convert.ToInt32(ClientSize.Width * ratioW);
            control.Height = control.Width;
            control.Left = Convert.ToInt32(ClientSize.Width * ratioX) - (control.Width / 2);
            control.Top = Convert.ToInt32(ClientSize.Height * ratioY) - (control.Height / 2);
        }

        public static Size SetSize(double ratioW, double ratioH) {
            int W = Convert.ToInt32(screen.Width * ratioW);
            int H = Convert.ToInt32(screen.Height * ratioH);
            return new Size(W, H);
        }

        public static Point SetPosition(double ratioX, double ratioY) {
            int X = Convert.ToInt32(screen.Width * ratioX);
            int Y = Convert.ToInt32(screen.Height * ratioY);
            return new Point(X, Y);
        }

        public static void SetPainterSize(Painter painter, double ratioW, double ratioH) {
            int W = Convert.ToInt32(screen.Width * ratioW);
            int H = Convert.ToInt32(screen.Height * ratioH);
            painter.Size = new Size(W, H);
        }

        public static void SetPainterPosition(Painter painter, double ratioX, double ratioY) {
            int W = painter.Size.Width;
            int H = painter.Size.Height;
            int X = Convert.ToInt32(screen.Width * ratioX) - (W / 2);
            int Y = Convert.ToInt32(screen.Height * ratioY) - (H / 2);
            painter.Position = new Point(X, Y);
        }
    }
}
