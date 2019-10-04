using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE_task_3
{
    public partial class FrmMain : Form
    {

        GameEngine engine;
        Timer timer;
        GameState gameState = GameState.PAUSED;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(int width, int height)
        {

            InitializeComponent();
            engine = new GameEngine(width, height);
            UpdateUI();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick_Tick;
        }

        private void UpdateUI()
        {
            lblMap.Text = engine.MapDisplay;
            lblRoundCount.Text = "Round: " + engine.Round;
            rtbUnitInfo.Text = engine.GetUnitInfo();
            rtbBuildingInfo.Text = engine.GetBuildingsInfo();
            lblUnits.Text = "Units (" + engine.NumUnits + ")";
            lblBuildings.Text = "Buildings (" + engine.NumBuildings + ")";
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            engine.LoadGame();
            lblMap.Text = "GAME LOADED\n" + engine.MapDisplay;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            engine.SaveGame();
            lblMap.Text = "GAME SAVED\n" + lblMap.Text;
        }

        public enum GameState
        {
            RUNNING,
            PAUSED,
            ENDED
        }

        private void cmbBuild_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBuildings_Click(object sender, EventArgs e)
        {

        }

        private void lblUnits_Click(object sender, EventArgs e)
        {

        }

        private void rtbUnitInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (gameState == GameState.RUNNING)
            {
                timer.Stop();
                gameState = GameState.PAUSED;
                btnStart.Text = "START";
            }

            else
            {
                if (gameState == GameState.ENDED)
                {
                    engine.Reset();
                }
                timer.Start();
                gameState = GameState.RUNNING;
                btnStop.Text = "PAUSE";
            }
        }

        private void lblRoundCount_Click(object sender, EventArgs e)
        {

        }

        private void rtbBuildingInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimerTick_Tick(object sender, EventArgs e)
        {
            engine.GameLoop();
            UpdateUI();

            if (engine.IsGameOver)
            {
                timer.Stop();
                UpdateUI();
                lblMap.Text = engine.WinningFaction + " WON!\n" + lblMap.Text;
                gameState = GameState.ENDED;
                btnStart.Text = "RESTART";
            }
        }
    }
}
