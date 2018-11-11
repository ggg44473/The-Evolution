using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using TheEvolution.Core;
using System.IO;

namespace TheEvolution {
    public partial class FormEnd : Form {

        int survivedTime;
        int playerImageNumber;
        List<Bitmap> playerImages;
        int imgIndex;
        SQLiteConnection conn;
        SQLiteCommand command;
        SQLiteDataReader reader;
        string createTable;
        string select;
        string insert;

        public FormEnd(int survivedTime, List<Bitmap> playerImages) {
            InitializeComponent();
            this.survivedTime = survivedTime;
            this.playerImages = playerImages;
            labelPlayerTime.Text = GetTimeString(survivedTime);
            imgIndex = 0;
            GameSystem.SetControlSize(picBoxGameOver, GameSystem.screen, 0.5, 0.5, 1, 1);

            createTable = "CREATE TABLE rank (name VARCHAR(20), time INT, image INT)";
            select = "SELECT * FROM rank ORDER BY time DESC";

            if (playerImages == ImageContainer.imgPlayer) {
                playerImageNumber = 1;
            } else if (playerImages == ImageContainer.imgPlayerEat) {
                playerImageNumber = 2;
            } else if (playerImages == ImageContainer.imgPlayerMito) {
                playerImageNumber = 3;
            } else if (playerImages == ImageContainer.imgPlayerMitoLyso) {
                playerImageNumber = 4;
            } else if (playerImages == ImageContainer.imgPlayerMitoLysoER) {
                playerImageNumber = 5;
            } else if (playerImages == ImageContainer.imgPlayerComplete) {
                playerImageNumber = 6;
            } else if (playerImages == ImageContainer.imgPlayerSick) {
                playerImageNumber = 7;
            } else if (playerImages == ImageContainer.imgPlayerSickEat) {
                playerImageNumber = 8;
            } else if (playerImages == ImageContainer.imgPlayerShocked) {
                playerImageNumber = 9;
            }

            MCImusic.mciMusic("Musics/End1.mp3", "play", "repeat");
        }

        private void FormEnd_Load(object sender, EventArgs e) {
            GameSystem.SetControlSize(picBoxRestart, ClientSize, 0.974, 0.03, 0.05, 0.06);
            GameSystem.SetControlSize(labelPlayerTime, ClientSize, 0.5, 0.74, 0.1, 0.1);
            GameSystem.SetControlSize(picBoxPlayerImage, ClientSize, 0.36, 0.8, 0.11, 0.14);
            GameSystem.SetControlSize(textBoxName, ClientSize, 0.5, 0.81, 0.1, 0.2);
            GameSystem.SetControlSize(labelConfirm, ClientSize, 0.64, 0.8, 0.1, 0.2);
            GameSystem.SetControlSize(labelName, ClientSize, 0.37, 0.3, 0.35, 0.6);
            GameSystem.SetControlSize(labelTime, ClientSize, 0.62, 0.3, 0.3, 0.6);

            if (!File.Exists("Evo.sqlite")) {
                SQLiteConnection.CreateFile("Evo.sqlite");
                conn = new SQLiteConnection("Data Source=Evo.sqlite;Version=3;");
                conn.Open();
                command = new SQLiteCommand(createTable, conn);
                command.ExecuteNonQuery();
            } else {
                conn = new SQLiteConnection("Data Source=Evo.sqlite;Version=3;");
                conn.Open();
            }

            ReadData();
        }

        private void labelConfirm_Click(object sender, EventArgs e) {
            insert = "INSERT INTO rank (name, time, image) values ('" +
                    textBoxName.Text + "', " + survivedTime + ", " + playerImageNumber + ")";
            command = new SQLiteCommand(insert, conn);
            command.ExecuteNonQuery();
            ReadData();
            textBoxName.Hide();
            labelConfirm.Hide();
            labelPlayerTime.Hide();
        }

        private void ReadData() {
            labelName.Text = "";
            labelTime.Text = "";
            command = new SQLiteCommand(select, conn);
            reader = command.ExecuteReader();
            for (int i = 0; i < 8; i++) {
                if (reader.Read()) {
                    labelName.Text += reader["name"] + "\n";
                    labelTime.Text += GetTimeString((int)reader["time"]) + "\n";
                }
            }
        }

        private void FormEnd_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                CloseGameOverPicBox();
            }
        }

        private void picBoxGameOver_Click(object sender, EventArgs e) {
            CloseGameOverPicBox();
        }

        private void CloseGameOverPicBox() {
            if (picBoxGameOver.Visible) {
                picBoxGameOver.Visible = false;
            }
            timerAnimate.Start();
        }

        private void timerAnimate_Tick(object sender, EventArgs e) {
            imgIndex++;
            if (imgIndex == playerImages.Count) {
                imgIndex = 0;
            }
            picBoxPlayerImage.Image = playerImages[imgIndex];
            Invalidate();
        }

        private string GetTimeString(int TotalSeconds) {
            string string_m = (TotalSeconds / 60).ToString();

            int s = TotalSeconds % 60;
            string string_s = s < 10 ? "0" + s.ToString() : s.ToString();

            return string_m + ":" + string_s;
        }

        private void picBoxRestart_Click(object sender, EventArgs e) {
            conn.Close();
            timerAnimate.Stop();
            Application.Restart();
        }
    }
}
