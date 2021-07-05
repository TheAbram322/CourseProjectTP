using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CloneOSU2
{
    public partial class MainForm : Form
    {
        
        public string playerName;
        public bool isMusicOn;
        public string pathToMusic;
        public string pathToBackground;
        private GameForm gameForm;
        public SerializingClass serializer;
        
        public MainForm()
        {

            InitializeComponent();
            isMusicOn = true;
            pathToBackground = "";
            pathToMusic = "";
            
            serializer = new SerializingClass();

            if (!File.Exists("CurrentNumber.txt"))
            {
                StreamWriter firstNumWriter = new StreamWriter("CurrentNumber.txt");
                firstNumWriter.Write("1");
                firstNumWriter.Close();
            }

            StreamReader numReader = new StreamReader("CurrentNumber.txt");
            int num = Convert.ToInt32(numReader.ReadToEnd());
            playerName = "Player" + num;
            
            serializer.Deserializing();
            
            HashSet<string> names = new HashSet<string>();
            foreach (Player player in serializer.content.listPlayers)
            {
                names.Add(player.name);
            }

            while (names.Contains(playerName))
            {
                num += 1;
                playerName = "Player" + num;
            }

            name_tb.Text = playerName;
            numReader.Close();
        }

        //Main Panel Buttons

        private void info_btn_Click(object sender, EventArgs e)
        {
            mainPanel_pnl.Visible = false;
            this.Size = new Size(infoPanel_pnl.Width + 20, infoPanel_pnl.Height + 40);
            infoPanel_pnl.Location = new Point(0, 0);
            infoPanel_pnl.Visible = true;
            this.Text = "Справка";
        }

        private void rating_btn_Click(object sender, EventArgs e)
        {
            mainPanel_pnl.Visible = false;
            this.Size = new Size(ratingPanel_pnl.Width + 20, ratingPanel_pnl.Height + 40);
            ratingPanel_pnl.Location = new Point(0, 0);
            ratingPanel_pnl.Visible = true;
            this.Text = "Рейтинг";

            serializer.Deserializing();
            serializer.content.listPlayers.Sort();
            serializer.content.listPlayers.Reverse();
            int n = serializer.content.listPlayers.Count;
            string rating = "";
            for (int i = 0; i < n; i++)
            {
                Player player = serializer.content.listPlayers[i];
                rating += (i + 1).ToString() + ". " + player.name + " " + player.scores.ToString() + '\n';
            }
            rating_rtb.Text = rating;
        }

        private void setup_btn_Click(object sender, EventArgs e)
        {
            mainPanel_pnl.Visible = false;
            this.Size = new Size(setupPanel_pnl.Width + 20, setupPanel_pnl.Height + 40);
            setupPanel_pnl.Location = new Point(0, 0);
            setupPanel_pnl.Visible = true;
            this.Text = "Настройки";
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (name_tb.Text == "")
            {
                StreamReader numReader = new StreamReader("CurrentNumber.txt");
                string num = numReader.ReadToEnd();
                numReader.Close();

                playerName = "Player" + num;
                name_tb.Text = playerName;

                StreamWriter numWriter = new StreamWriter("CurrentNumber.txt");
                numWriter.Write((Convert.ToInt32(num) + 1).ToString());
                numWriter.Close();

                addPlayer(playerName);
            }
            else
            {
                playerName = name_tb.Text;
                if (playerName.Length > 20) 
                {
                    MessageBox.Show("Имя должно быть не длиннее 20 символов!");
                    return;
                }
                
                addPlayer(playerName);
            }

            gameForm = new GameForm(this);
            this.Hide();
            gameForm.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Info Panel Button

        private void exitInfo_btn_Click(object sender, EventArgs e)
        {
            showMainMenuPanel(infoPanel_pnl);
        }

        //Rating Panel Button;

        private void exitRating_btn_Click(object sender, EventArgs e)
        {
            showMainMenuPanel(ratingPanel_pnl);
        }

        // Setup Panel Buttons

        private void turnOnOffMusic_btn_Click(object sender, EventArgs e)
        {
            if (isMusicOn)
            {
                musicMode_lbl.Text = "Выкл";
                turnOnOffMusic_btn.Text = "Вкл";
            }
            else 
            {
                musicMode_lbl.Text = "Вкл";
                turnOnOffMusic_btn.Text = "Выкл";
            }

            isMusicOn = !isMusicOn;
        }

        private void changeMusic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open soundtrack file";
            openFileDialog.Filter = "Wav file|*.wav|Mp3 file|*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
           
            pathToMusic = openFileDialog.FileName;
            musicPath_tb.Text = openFileDialog.FileName;
        }

        private void changeBackground_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open background image file";
            openFileDialog.Filter = "Png file|*.png|Jpg file|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            
            pathToBackground = openFileDialog.FileName;
            backgroundPath_tb.Text = openFileDialog.FileName;
        }

        private void exitSetup_btn_Click(object sender, EventArgs e)
        {
            showMainMenuPanel(setupPanel_pnl);
        }

        // Using methods
        
        private void showMainMenuPanel(Panel toClose)
        {
            toClose.Visible = false;
            this.Size = new Size(mainPanel_pnl.Width + 20, mainPanel_pnl.Height + 40);
            mainPanel_pnl.Location = new Point(0, 0);
            mainPanel_pnl.Visible = true;
            this.Text = "Главное меню";
        }

        private void addPlayer(string name) 
        {
            serializer.Deserializing();
            foreach (Player player in serializer.content.listPlayers)
            {
                if (player.name == name) return;
            }
            serializer.content.listPlayers.Add(new Player(name, 0));
            serializer.Serializing();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!mainPanel_pnl.Visible) 
            {
                if (infoPanel_pnl.Visible) showMainMenuPanel(infoPanel_pnl);
                else if (ratingPanel_pnl.Visible) showMainMenuPanel(ratingPanel_pnl);
                else showMainMenuPanel(setupPanel_pnl);

            }  
        }
    }
}
