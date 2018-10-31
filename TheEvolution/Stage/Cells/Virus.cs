using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class Virus : Cell {

        private Point direction;
        private double distanceToPlayer;

        public Virus(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgVirus;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            moveSpeed = (int)(0.1 * size.Width);
            direction = new Point();
        }

        public override void Paint(object sender, PaintEventArgs e) {
            lock (rotation) {
                e.Graphics.Transform = rotation;
                e.Graphics.DrawImage(images[imgIndex],
                    position.X, position.Y, size.Width, size.Height);
                rotation.Reset();
                e.Graphics.Transform = rotation;
            }
        }

        public void VirusMove() {
            direction = GetDirectionToTarget(GameSystem.player);
            GetDistanceToPlayer();
            if (distanceToPlayer <= 4 * size.Width) {
                position.X += direction.X * moveSpeed;
                position.Y += direction.Y * moveSpeed;              
            } else {
                position.X += random.Next(-5, 5);
                position.Y += random.Next(-5, 5);
            }
        }

        public void GetDistanceToPlayer() {
            distanceToPlayer = GameSystem.getDistance(
                GameSystem.player.GetCenter(), GetCenter());
        }

        public override int GetAngle() {
            int playerX = GameSystem.player.GetCenter().X;
            int playerY = GameSystem.player.GetCenter().Y;
            if (playerY >= GetCenter().Y) {
                return AngleToPlayer();
            } else {
                return AngleToPlayer() * (-1) ;
            }
        }

        public int AngleToPlayer() {
            int dirX = GameSystem.player.GetCenter().X - GetCenter().X;
            int dirY = GameSystem.player.GetCenter().Y - GetCenter().Y;
            double R = Math.Sqrt((dirX * dirX) + (dirY * dirY));
            return (int)(Math.Acos(dirX / R) / Math.PI * 180);          
        }

        public override void NextStep() {
            Rotate();
            VirusMove();          
        }

        public void CollidePlayer() {

        }
    }
}
