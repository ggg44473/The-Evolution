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
        static public List<Bitmap> imgPlayerEat2;
        static public List<Bitmap> imgPlayerMito;
        static public List<Bitmap> imgPlayerMitoLyso;
        static public List<Bitmap> imgPlayerComplete;
        static public List<Bitmap> imgPredator;
        static public List<Bitmap> imgPredatorEat;
        static public List<Bitmap> imgCompetitor;
        static public List<Bitmap> imgShocker;
        static public List<Bitmap> imgTracker;
        static public List<Bitmap> imgPlantWall;
        static public List<Bitmap> imgVirus;
        static public List<Bitmap> imgAlgae;
        static public List<Bitmap> imgCharophyta;
        static public List<Bitmap> imgJunk;
        static public List<Bitmap> imgCentromere;
        static public List<Bitmap> imgER;
        static public List<Bitmap> imgLysosome;
        static public List<Bitmap> imgMitochondria;
        static public List<Bitmap> imgChoroplast;
        static public List<Bitmap> imgFlagellum;
        static public List<Bitmap> imgPump;

        public ImageContainer() {
            SetImgBackground();
            SetImgPlayer();
            SetImgPredator();
            SetImgCompetitor();
            SetImgShocker();
            SetImgTracker();
            SetImgPlantWall();
            SetImgVirus();
            SetImgAlgae();
            SetImgCharophyta();
            SetImgCentromere();
            SetImgER();
            SetImgLysosome();
            SetImgMitochondria();
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
            size = GameSystem.SetSize(0.072, 0.12);
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
                new Bitmap(Resources.PlayerEat1, size),
                new Bitmap(Resources.PlayerEat2, size),
                new Bitmap(Resources.PlayerEat3, size),
                new Bitmap(Resources.PlayerEat4, size),
                new Bitmap(Resources.PlayerEat5, size)};
            imgPlayerEat2 = new List<Bitmap>() {
                new Bitmap(Resources.OPlayerEat1, size),
                new Bitmap(Resources.OPlayerEat2, size),
                new Bitmap(Resources.OPlayerEat3, size),
                new Bitmap(Resources.OPlayerEat4, size),
                new Bitmap(Resources.OPlayerEat5, size)};
            imgPlayerMito = new List<Bitmap>() {
                new Bitmap(Resources.PlayerMito1, size),
                new Bitmap(Resources.PlayerMito2, size),
                new Bitmap(Resources.PlayerMito3, size),
                new Bitmap(Resources.PlayerMito4, size),
                new Bitmap(Resources.PlayerMito5, size)};
            imgPlayerMitoLyso = new List<Bitmap>() {
                new Bitmap(Resources.PlayerMitoLyso1, size),
                new Bitmap(Resources.PlayerMitoLyso2, size),
                new Bitmap(Resources.PlayerMitoLyso3, size),
                new Bitmap(Resources.PlayerMitoLyso4, size),
                new Bitmap(Resources.PlayerMitoLyso5, size)};
            imgPlayerComplete = new List<Bitmap>() {
                new Bitmap(Resources.PlayerComplete1, size),
                new Bitmap(Resources.PlayerComplete2, size),
                new Bitmap(Resources.PlayerComplete3, size),
                new Bitmap(Resources.PlayerComplete4, size),
                new Bitmap(Resources.PlayerComplete5, size)};
        }

        public void SetImgPredator() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgPredator = new List<Bitmap>() {
                new Bitmap(Resources.Predator1, size),
                new Bitmap(Resources.Predator2, size)};
            imgPredatorEat = new List<Bitmap>() {
                new Bitmap(Resources.PredatorEat, size)};
        }

        public void SetImgCompetitor() {
            size = GameSystem.SetSize(0.12, 0.12);
            imgCompetitor = new List<Bitmap>() {
                new Bitmap(Resources.Competitor1, size),
                new Bitmap(Resources.Competitor2, size)};
        }

        public void SetImgShocker() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgShocker = new List<Bitmap>() {
                new Bitmap(Resources.Shocker1, size),
                new Bitmap(Resources.Shocker2, size)};
        }

        public void SetImgTracker() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgTracker = new List<Bitmap>() {
                new Bitmap(Resources.Tracker1, size),
                new Bitmap(Resources.Tracker2, size),
                new Bitmap(Resources.Tracker3, size),
                new Bitmap(Resources.Tracker4, size)};
        }

        public void SetImgPlantWall() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgPlantWall = new List<Bitmap>() {
                new Bitmap(Resources.PlantWall1, size),
                new Bitmap(Resources.PlantWall2, size),
                new Bitmap(Resources.PlantWall3, size),
                new Bitmap(Resources.PlantWall4, size)};
        }

        public void SetImgVirus() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgVirus = new List<Bitmap>() { new Bitmap(Resources.Virus, size) };
        }

        public void SetImgAlgae() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgAlgae = new List<Bitmap>() { new Bitmap(Resources.Algae, size) };
        }

        public void SetImgCharophyta() {
            size = GameSystem.SetSize(0.035, 0.055);
            imgCharophyta = new List<Bitmap>() {
                new Bitmap(Resources.Charophyta, size)};
        }

        public void SetImgCentromere() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgCentromere = new List<Bitmap>() {
                new Bitmap(Resources.Centromere, size)};
        }

        public void SetImgER() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgER = new List<Bitmap>() {
                new Bitmap(Resources.ER1, size),
                new Bitmap(Resources.ER2, size),
                new Bitmap(Resources.ER3, size)};
        }

        public void SetImgLysosome() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgLysosome = new List<Bitmap>() {
                new Bitmap(Resources.Lysosome1, size),
                new Bitmap(Resources.Lysosome2, size),
                new Bitmap(Resources.Lysosome3, size)};
        }

        public void SetImgMitochondria() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgMitochondria = new List<Bitmap>() {
                new Bitmap(Resources.Mitochondria, size)};
        }
    }
}
