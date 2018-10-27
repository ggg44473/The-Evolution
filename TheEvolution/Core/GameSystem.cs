﻿using System;
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
        public static Form currentForm;
        public static Player currentPlayer;
        public static List<Competitor> competitors = new List<Competitor>();
        public static List<Cell> otherCells = new List<Cell>();
        public static List<Food> foods = new List<Food>();
        public static List<Organelle> organella = new List<Organelle>();
        public static bool isStart, isPainterGenerated;

        public static void Act() {
            while (isStart) {
                currentPlayer.NextStep();
                currentForm.Invalidate();
                Thread.Sleep(50);
            }
        }

        public static void CollisionDetect() {
            while (isStart) {
                GetFood(currentPlayer);
                foreach (Competitor c in competitors) {
                    GetFood(c);
                }
                GetOrganelle();
                CellCollide();
                Thread.Sleep(50);
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

                if (Math.Abs(FoodX - CellX) <= (FoodW + CellW) / 4.5) {
                    if (Math.Abs(FoodY - CellY) <= (FoodH + CellH) / 4.5) {
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

        public static void CellCollide() {

        }

        public static void CompetitorCollide() {

        }

        public static void CheckPainterGenerated() {
            if (currentForm != null) {
                if (currentPlayer != null) {
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

        public static void SetPainterSize(IPainting painter, double ratioW, double ratioH) {
            int W = Convert.ToInt32(screen.Width * ratioW);
            int H = Convert.ToInt32(screen.Height * ratioH);
            painter.Size = new Size(W, H);
        }

        public static void SetPainterPosition(IPainting painter, double ratioX, double ratioY) {
            int W = painter.Size.Width;
            int H = painter.Size.Height;
            int X = Convert.ToInt32(screen.Width * ratioX) - (W / 2);
            int Y = Convert.ToInt32(screen.Height * ratioY) - (H / 2);
            painter.Position = new Point(X, Y);
        }
    }
}
