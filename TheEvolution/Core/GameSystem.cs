using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using TheEvolution.Stage.Cells;
using TheEvolution.Stage.Foods;
using TheEvolution.Stage.Organella;

namespace TheEvolution.Core {
    static class GameSystem {

        public static Size screen;
        public static Form form;
        public static Player player;
        public static List<Competitor> competitors = new List<Competitor>();
        public static List<Competitor> deadCompetitors = new List<Competitor>();
        public static List<Cell> otherCells = new List<Cell>();
        public static List<Cell> deadOtherCells = new List<Cell>();
        public static List<Food> foods = new List<Food>();
        public static List<Organelle> organella = new List<Organelle>();
        public static List<Organelle> DisposedOrganella = new List<Organelle>();
        public static bool isStart, isPainterGenerated;

        public static void Act() {
            FormStage formStage = form as FormStage;
            while (isStart) {
                formStage.Invoke((Action)delegate () {
                    formStage.label1.Text = player.Hp.ToString();
                    if (player.Hp == 0) {
                        formStage.GameOver();
                    }
                });
                player.NextStep();
                foreach (Competitor c in competitors) {
                    c.NextStep();
                }
                foreach (Cell c in otherCells) {
                    c.NextStep();
                }
                form.Invalidate();
                Thread.Sleep(50);
            }
        }

        public static void CollisionDetect() {
            while (isStart) {
                GetFood(player);
                foreach (Competitor c in competitors) {
                    GetFood(c);
                }
                GetOrganelle();
                CompetitorCollide();
                OtherCellCollide();
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

        }

        public static void CompetitorCollide() {
            int i = 0;
            int playerX = player.GetCenter().X;
            int playerY = player.GetCenter().Y;
            int playerW = player.Size.Width;
            int playerH = player.Size.Height;
            int competitorX, competitorY, competitorW, competitorH;

            foreach (Competitor c in competitors) {
                competitorX = c.GetCenter().X; competitorY = c.GetCenter().Y;
                competitorW = c.Size.Width; competitorH = c.Size.Height;

                if (Math.Abs(competitorX - playerX) <= (competitorW + playerW) / 4) {
                    if (Math.Abs(competitorY - playerY) <= (competitorH + playerH) / 4) {
                        player.CollideCompetitor(competitors[i]);
                        competitors[i].CollidePlayer(i);
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

            foreach (Cell c in otherCells) {
                cellX = c.GetCenter().X; cellY = c.GetCenter().Y;
                cellW = c.Size.Width; cellH = c.Size.Height;

                if (Math.Abs(cellX - playerX) <= (cellW + playerW) / 4) {
                    if (Math.Abs(cellY - playerY) <= (cellH + playerH) / 4) {
                        if (c is Virus) {
                            player.CollideVirus();
                        }
                        c.Collide(i);
                        if (c is Predator) {
                            player.CollidePredator();
                        }
                        c.Collide();
                        if (c is Shocker) {
                            player.CollideShocker(c);
                        }
                        return;
                    }
                }
                i++;
            }
        }

        public static void CheckPainterGenerated() {
            if (form != null) {
                if (player != null) {
                    if (competitors != null) {
                        if (otherCells != null) {
                            if (organella != null) {
                                if (foods != null) {
                                    isPainterGenerated = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            isPainterGenerated = false;
            return;
        }

        public static double getDistance(Point p1, Point p2) {
            return Math.Sqrt(
                Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }

        public static void SetControlSize(Control control, Size ClientSize, double ratioL, double ratioT, double ratioW, double ratioH) {
            control.Width = Convert.ToInt32(ClientSize.Width * ratioW);
            control.Height = Convert.ToInt32(ClientSize.Height * ratioH);
            control.Left = Convert.ToInt32(ClientSize.Width * ratioL) - (control.Width / 2);
            control.Top = Convert.ToInt32(ClientSize.Height * ratioT) - (control.Height / 2);
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
