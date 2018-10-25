using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheEvolution.Properties;

namespace TheEvolution.Stage {
    class ImageContainer {
        public List<Bitmap> imgBackground;
        public List<Bitmap> imgPlayer;
        public List<Bitmap> imgPlayer2;
        public List<Bitmap> imgPlayerEat;
        public List<Bitmap> imgPredator;
        public List<Bitmap> imgCompetitor;
        public List<Bitmap> imgShocker;
        public List<Bitmap> imgTracker;
        public List<Bitmap> imgPlantWall;
        public List<Bitmap> imgVirus;
        public List<Bitmap> imgAlgae;
        public List<Bitmap> imgCharophyta;
        public List<Bitmap> imgJunk;
        public List<Bitmap> imgFlagellum;
        public List<Bitmap> imgPump;
        public List<Bitmap> imgCentromere;
        public List<Bitmap> imgER;
        public List<Bitmap> imgLysosome;
        public List<Bitmap> imgMitochondria;
        public List<Bitmap> imgChoroplast;

        public ImageContainer() {
            imgPlayer = new List<Bitmap>() {
                new Bitmap(Resources.P1, imgSize), new Bitmap(Resources.P2,imgSize),
                new Bitmap(Resources.P3, imgSize), new Bitmap(Resources.P4, imgSize),
                new Bitmap(Resources.P5, imgSize)};
            imgPlayerEat = new List<Bitmap>() {
                new Bitmap(Resources.PlayerCellEat1, imgSize), new Bitmap(Resources.PlayerCellEat2,imgSize),
                new Bitmap(Resources.PlayerCellEat3, imgSize), new Bitmap(Resources.PlayerCellEat4, imgSize),
                new Bitmap(Resources.PlayerCellEat5, imgSize)};
            imgPlayer2 = new List<Bitmap>() {
                new Bitmap(Resources.OP1, imgSize), new Bitmap(Resources.OP2,imgSize),
                new Bitmap(Resources.OP3, imgSize), new Bitmap(Resources.OP4, imgSize),
                new Bitmap(Resources.OP5, imgSize)};
        }
    }
}
