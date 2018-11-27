using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheEvolution.Properties;

namespace TheEvolution.Core {
    static class ImageContainer {

        static private Size size;
        static public List<Bitmap> imgBackground;
        static public List<Bitmap> imgPlayer;
        static public List<Bitmap> imgPlayer2;
        static public List<Bitmap> imgPlayerEat;
        static public List<Bitmap> imgPlayerEat2;
        static public List<Bitmap> imgPlayerMito;
        static public List<Bitmap> imgPlayerMitoLyso;
        static public List<Bitmap> imgPlayerMitoLysoER;
        static public List<Bitmap> imgPlayerComplete;
        static public List<Bitmap> imgPlayerFinal;
        static public List<Bitmap> imgPlayerFinalEat;
        static public List<Bitmap> imgPlayerSick;
        static public List<Bitmap> imgPlayerSickEat;
        static public List<Bitmap> imgPlayerShocked;
        static public List<Bitmap> imgPredator;
        static public List<Bitmap> imgPredatorEat;
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
        static public List<Bitmap> imgChloroplast;

        static public void PrepareImage() {
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
            SetImgChloroplast();
        }

        static public void SetImgBackground() {
            size = new Size(3 * GameSystem.screen.Width, 3 * GameSystem.screen.Height);
            imgBackground = new List<Bitmap>() {
                new Bitmap(Resources.bg1, size),
                new Bitmap(Resources.bg2, size),
                new Bitmap(Resources.TutorialScreen, size),
                new Bitmap(Resources.DemoScreen, size)
            };
        }

        static public void SetImgPlayer() {
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
            imgPlayerMitoLysoER = new List<Bitmap>() {
                new Bitmap(Resources.PlayerMitoLysoER1, size),
                new Bitmap(Resources.PlayerMitoLysoER2, size),
                new Bitmap(Resources.PlayerMitoLysoER3, size),
                new Bitmap(Resources.PlayerMitoLysoER4, size),
                new Bitmap(Resources.PlayerMitoLysoER5, size)};
            imgPlayerComplete = new List<Bitmap>() {
                new Bitmap(Resources.PlayerComplete1, size),
                new Bitmap(Resources.PlayerComplete2, size),
                new Bitmap(Resources.PlayerComplete3, size),
                new Bitmap(Resources.PlayerComplete4, size),
                new Bitmap(Resources.PlayerComplete5, size)};
            imgPlayerSick = new List<Bitmap>() {
                new Bitmap(Resources.SickPlayer1, size),
                new Bitmap(Resources.SickPlayer2, size),
                new Bitmap(Resources.SickPlayer3, size),
                new Bitmap(Resources.SickPlayer4, size),
                new Bitmap(Resources.SickPlayer5, size)};
            imgPlayerSickEat = new List<Bitmap>() {
                new Bitmap(Resources.SickPlayerEat1, size),
                new Bitmap(Resources.SickPlayerEat2, size),
                new Bitmap(Resources.SickPlayerEat3, size),
                new Bitmap(Resources.SickPlayerEat4, size),
                new Bitmap(Resources.SickPlayerEat5, size)};
            imgPlayerShocked = new List<Bitmap>() {
                new Bitmap(Resources.ShokedState1, size),
                new Bitmap(Resources.ShokedState2, size),
                new Bitmap(Resources.ShokedState3, size),
                new Bitmap(Resources.ShokedState4, size),
                new Bitmap(Resources.ShokedState5, size)};
            imgPlayerFinal = new List<Bitmap>() {
                new Bitmap(Resources.PlayerFinal1, size),
                new Bitmap(Resources.PlayerFinal2, size),
                new Bitmap(Resources.PlayerFinal3, size),
                new Bitmap(Resources.PlayerFinal4, size),
                new Bitmap(Resources.PlayerFinal5, size)};
            imgPlayerFinalEat = new List<Bitmap>() {
                new Bitmap(Resources.PlayerFinalEat1, size),
                new Bitmap(Resources.PlayerFinalEat2, size),
                new Bitmap(Resources.PlayerFinalEat3, size),
                new Bitmap(Resources.PlayerFinalEat4, size),
                new Bitmap(Resources.PlayerFinalEat5, size)};
        }

        static public void SetImgPredator() {
            size = GameSystem.SetSize(0.09, 0.13);
            imgPredator = new List<Bitmap>() {
                new Bitmap(Resources.Predator1, size),
                new Bitmap(Resources.Predator2, size)};
            imgPredatorEat = new List<Bitmap>() {
                new Bitmap(Resources.PredatorEat, size)};
        }

        static public void SetImgCompetitor() {
            size = GameSystem.SetSize(0.12, 0.12);
            imgCompetitor = new List<Bitmap>() {
                new Bitmap(Resources.Competitor1, size),
                new Bitmap(Resources.Competitor2, size)};
        }

        static public void SetImgShocker() {
            size = GameSystem.SetSize(0.07, 0.12);
            imgShocker = new List<Bitmap>() {
                new Bitmap(Resources.Shocker1, size),
                new Bitmap(Resources.Shocker2, size)};
        }

        static public void SetImgTracker() {
            size = GameSystem.SetSize(0.05, 0.09);
            imgTracker = new List<Bitmap>() {
                new Bitmap(Resources.Tracker1, size),
                new Bitmap(Resources.Tracker2, size),
                new Bitmap(Resources.Tracker3, size),
                new Bitmap(Resources.Tracker4, size)};
        }

        static public void SetImgPlantWall() {
            size = GameSystem.SetSize(0.225, 0.28);
            imgPlantWall = new List<Bitmap>() {
                new Bitmap(Resources.PlantWall1, size),
                new Bitmap(Resources.PlantWall2, size),
                new Bitmap(Resources.PlantWall3, size),
                new Bitmap(Resources.PlantWall4, size)};
        }

        static public void SetImgVirus() {
            size = GameSystem.SetSize(0.035, 0.025);
            imgVirus = new List<Bitmap>() { new Bitmap(Resources.Virus, size) };
        }

        static public void SetImgAlgae() {
            size = GameSystem.SetSize(0.025, 0.045);
            imgAlgae = new List<Bitmap>() {
                new Bitmap(Resources.Algae1, size),
                new Bitmap(Resources.Algae2, size) };
        }

        static public void SetImgCharophyta() {
            size = GameSystem.SetSize(0.035, 0.055);
            imgCharophyta = new List<Bitmap>() {
                new Bitmap(Resources.Charophyta1, size),
                new Bitmap(Resources.Charophyta2, size)};
        }

        static public void SetImgCentromere() {
            size = GameSystem.SetSize(0.05, 0.09);
            imgCentromere = new List<Bitmap>() {
                new Bitmap(Resources.Centromere, size)};
        }

        static public void SetImgER() {
            size = GameSystem.SetSize(0.08, 0.12);
            imgER = new List<Bitmap>() {
                new Bitmap(Resources.ER, size)};
        }

        static public void SetImgLysosome() {
            size = GameSystem.SetSize(0.04, 0.09);
            imgLysosome = new List<Bitmap>() {
                new Bitmap(Resources.Lysosome1, size),
                new Bitmap(Resources.Lysosome2, size),
                new Bitmap(Resources.Lysosome3, size)};
        }

        static public void SetImgMitochondria() {
            size = GameSystem.SetSize(0.026, 0.066);
            imgMitochondria = new List<Bitmap>() {
                new Bitmap(Resources.Mitochondria, size)};
        }

        static public void SetImgChloroplast() {
            size = GameSystem.SetSize(0.045, 0.065);
            imgChloroplast = new List<Bitmap>() {
                new Bitmap(Resources.Chloroplast, size)
            };
        }
    }
}
