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

        public static Form currentForm;
        public static Player currentPlayer;
        public static List<ICollide> allSquares;
        public static List<ICollide> allRectangles;
        public static bool isCollided;

        public static void Act() {
            while (true) {
                currentPlayer.NextStep();
                Thread.Sleep(100);
            }
        }

        public static void CollisionDetect() {
            SquareDetect();
            RectangleDectect();
            Thread.Sleep(100);
        }

        public static void SquareDetect() {
            int i = 0;
            double distance;
            int minDistance;
            foreach (var square in allSquares) {
                distance = getDistance(currentPlayer.GetCenter(), square.GetCenter());
                minDistance = (currentPlayer.GetSize().Width + square.GetSize().Width) / 2;
                if (distance < minDistance) {
                    isCollided = true;
                    OnSquareCollide(i);
                    return;
                }
                i++;
            }
        }

        public static void RectangleDectect() {
            int i = 0;
            int rectangleX, rectangleY, rectangleW, rectangleH;
            int playerX, playerY, playerW, playerH;
            playerX = currentPlayer.GetCenter().X;
            playerY = currentPlayer.GetCenter().Y;
            playerW = currentPlayer.GetSize().Width;
            playerH = currentPlayer.GetSize().Height;

            foreach (var rectangle in allRectangles) {
                rectangleX = rectangle.GetCenter().X;
                rectangleY = rectangle.GetCenter().Y;
                rectangleW = rectangle.GetSize().Width;
                rectangleH = rectangle.GetSize().Height;
                if (Math.Abs(rectangleX - playerX) <= (rectangleW + playerW) / 2.4) {
                    if (Math.Abs(rectangleY - playerY) <= (rectangleH + playerH) / 2.4) {
                        isCollided = true;
                        OnRectangleCollide(i);
                        return;
                    }
                }
                i++;
            }
        }

        public static void OnSquareCollide(int i) {
            if (allSquares[i] is Algae) {
                currentPlayer.Collide();
            } else if (allSquares[i] is Charophyta) {

            } else if (allSquares[i] is Lysosome) {

            } else if (allSquares[i] is PlantWall) {

            } else if (allSquares[i] is Predator) {

            } else if (allSquares[i] is ER) {

            } else if (allSquares[i] is Centromere) {

            }
        }

        public static void OnRectangleCollide(int i) {
            if (allRectangles[i] is Competitor) {
                currentPlayer.Collide();
            } else if (allRectangles[i] is Tracker) {

            } else if (allRectangles[i] is Virus) {

            } else if (allRectangles[i] is Mitochondrion) {

            }
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

        public static void SetFrame(IPainting painter, Size ClientSize, double ratioX, double ratioY, double ratioW, double ratioH) {
            int W = Convert.ToInt32(ClientSize.Width * ratioW);
            int H = Convert.ToInt32(ClientSize.Height * ratioH);
            int X = Convert.ToInt32(ClientSize.Width * ratioX) - (W / 2);
            int Y = Convert.ToInt32(ClientSize.Height * ratioY) - (H / 2);
            painter.Frame = new Rectangle(X, Y, W, H);
        }

        public static void SetSquareFrame(IPainting painter, Size ClientSize, double ratioX, double ratioY, double ratioW) {
            int W = Convert.ToInt32(ClientSize.Width * ratioW);
            int H = W;
            int X = Convert.ToInt32(ClientSize.Width * ratioX) - (W / 2);
            int Y = Convert.ToInt32(ClientSize.Height * ratioY) - (H / 2);
            painter.Frame = new Rectangle(X, Y, W, H);
        }
    }
}
