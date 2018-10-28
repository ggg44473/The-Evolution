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
        static public List<Bitmap> imgPlayerEat2;      //Add
        static public List<Bitmap> imgPlayerWMito;     //Add
        static public List<Bitmap> imgPlayerWMitoLyso; //Add
        static public List<Bitmap> imgPlayerComplete;  //Add
        static public List<Bitmap> imgPredator;
        static public List<Bitmap> imgPredatorEat;     //Add
        static public List<Bitmap> imgCompetitor;
        static public List<Bitmap> imgShocker;
        static public List<Bitmap> imgTracker;
        static public List<Bitmap> imgPlantWall;
        static public List<Bitmap> imgVirus;
        static public List<Bitmap> imgAlgae;
        static public List<Bitmap> imgCharophyta;       
        static public List<Bitmap> imgCentromere;
        static public List<Bitmap> imgER;
        static public List<Bitmap> imgLysosome;
        static public List<Bitmap> imgMitochondria;
        static public List<Bitmap> imgChoroplast;      //not yet
        static public List<Bitmap> imgJunk;            //not yet
        static public List<Bitmap> imgFlagellum;       //not yet
        static public List<Bitmap> imgPump;            //not yet

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
            imgPlayerEat2 = new List<Bitmap>() {
                new Bitmap(Resources.OPlayerCellEat1, size),
                new Bitmap(Resources.OPlayerCellEat2, size),
                new Bitmap(Resources.OPlayerCellEat3, size),
                new Bitmap(Resources.OPlayerCellEat4, size),
                new Bitmap(Resources.OPlayerCellEat5, size)};
            imgPlayerWMito = new List<Bitmap>() {
                new Bitmap(Resources.PlayerWMito1, size),
                new Bitmap(Resources.PlayerWMito2, size),
                new Bitmap(Resources.PlayerWMito3, size),
                new Bitmap(Resources.PlayerWMito4, size),
                new Bitmap(Resources.PlayerWMito5, size)};
            imgPlayerWMitoLyso = new List<Bitmap>() {
                new Bitmap(Resources.PlayerWMitoLyso1, size),
                new Bitmap(Resources.PlayerWMitoLyso2, size),
                new Bitmap(Resources.PlayerWMitoLyso3, size),
                new Bitmap(Resources.PlayerWMitoLyso4, size),
                new Bitmap(Resources.PlayerWMitoLyso5, size)};
            imgPlayerComplete = new List<Bitmap>() {
                new Bitmap(Resources.PlayerComplete1, size),
                new Bitmap(Resources.PlayerComplete2, size),
                new Bitmap(Resources.PlayerComplete3, size),
                new Bitmap(Resources.PlayerComplete4, size),
                new Bitmap(Resources.PlayerComplete5, size)};
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

        public void SetImgPredator() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgPredator = new List<Bitmap>() {
                new Bitmap(Resources.Predator1, size),
                new Bitmap(Resources.Predator2, size)};
            imgPredatorEat = new List<Bitmap>() { new Bitmap(Resources.PredatorEat) };
        }

        public void SetImgCompetitor() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgCompetitor = new List<Bitmap>() {
                new Bitmap(Resources.Competitor1),
                new Bitmap(Resources.Competitor2)};
        }

        public void SetImgShocker() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgShocker = new List<Bitmap>() {
                new Bitmap(Resources.Shocker1),
                new Bitmap(Resources.Shocker2)};
        }

        public void SetImgTracker() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgTracker = new List<Bitmap>() {
                new Bitmap(Resources.Tracker1),
                new Bitmap(Resources.Tracker2),
                new Bitmap(Resources.Tracker3),
                new Bitmap(Resources.Tracker4)};
        }

        public void SetImgPlantWall() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgPlantWall = new List<Bitmap>() {
                new Bitmap(Resources.PlantWall1),
                new Bitmap(Resources.PlantWall2),
                new Bitmap(Resources.PlantWall3),
                new Bitmap(Resources.PlantWall4)};
            imgVirus = new List<Bitmap>() { new Bitmap(Resources.Virus) };
        }

        public void SetImgVirus() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgVirus = new List<Bitmap>() { new Bitmap(Resources.Virus) };
        }

        public void SetImgCentromere() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgCentromere = new List<Bitmap>() { new Bitmap(Resources.Centromere) };
        }

        public void SetImgER() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgER = new List<Bitmap>() {
                new Bitmap(Resources.ER1),
                new Bitmap(Resources.ER2),
                new Bitmap(Resources.ER3)};
        }

        public void SetImgLysosome() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgER = new List<Bitmap>() {
                new Bitmap(Resources.Lysosome1),
                new Bitmap(Resources.Lysosome2),
                new Bitmap(Resources.Lysosome3)};         
        }
        public void SetImgMitochondria() {
            size = GameSystem.SetSize(0.025, 0.045);    //size need to be set
            imgER = new List<Bitmap>() { new Bitmap(Resources.Mitochondria) };               
        }
    }
}
