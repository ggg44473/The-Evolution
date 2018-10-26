using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution.Stage {
    class ImageContainer {
        private Size size;
        static public List<Bitmap> imgBackground;
        static public List<Bitmap> imgPlayer;
        static public List<Bitmap> imgPlayer2;
        static public List<Bitmap> imgPlayerEat;
        static public List<Bitmap> imgPredator;
        static public List<Bitmap> imgCompetitor;
        static public List<Bitmap> imgShocker;
        static public List<Bitmap> imgTracker;
        static public List<Bitmap> imgPlantWall;
        static public List<Bitmap> imgVirus;
        static public List<Bitmap> imgAlgae;
        static public List<Bitmap> imgCharophyta;
        static public List<Bitmap> imgJunk;
        static public List<Bitmap> imgFlagellum;
        static public List<Bitmap> imgPump;
        static public List<Bitmap> imgCentromere;
        static public List<Bitmap> imgER;
        static public List<Bitmap> imgLysosome;
        static public List<Bitmap> imgMitochondria;
        static public List<Bitmap> imgChoroplast;

        public ImageContainer() {
            SetImgBackground();
            SetImgPlayer();
            SetImgAlgae();
            SetImgCharophyta();
        }

        public void SetImgBackground() {
            size = GameSystem.screen;
            imgBackground = new List<Bitmap>() {
                new Bitmap(Resources.bg1, size),
                new Bitmap(Resources.bg2, size),
                new Bitmap(Resources.bg3, size)
            };
        }

        public void SetImgPlayer() {
            size = GameSystem.SetSize(0.06, 0.1);
            imgPlayer = new List<Bitmap>() {
                new Bitmap(Resources.P1, size),
                new Bitmap(Resources.P2, size),
                new Bitmap(Resources.P3, size),
                new Bitmap(Resources.P4, size),
                new Bitmap(Resources.P5, size)};
            imgPlayer2 = new List<Bitmap>() {
                new Bitmap(Resources.OP1, size),
                new Bitmap(Resources.OP2, size),
                new Bitmap(Resources.OP3, size),
                new Bitmap(Resources.OP4, size),
                new Bitmap(Resources.OP5, size)};
            imgPlayerEat = new List<Bitmap>() {
                new Bitmap(Resources.PlayerCellEat1, size),
                new Bitmap(Resources.PlayerCellEat2, size),
                new Bitmap(Resources.PlayerCellEat3, size),
                new Bitmap(Resources.PlayerCellEat4, size),
                new Bitmap(Resources.PlayerCellEat5, size)};
        }

        public void SetImgAlgae() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgAlgae = new List<Bitmap>() {
                new Bitmap(Resources.Algae, size)};
        }

        public void SetImgCharophyta() {
            size = GameSystem.SetSize(0.035, 0.055);
            imgCharophyta = new List<Bitmap>() {
                new Bitmap(Resources.Charophyta, size) };
        }
    }
}
