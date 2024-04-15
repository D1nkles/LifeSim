using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSimWinForms
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private GameLogic gameLogic;
        private int cellSize;
        private bool isPaused;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void StartGame() 
        {
            if (gameTimer.Enabled) 
            {
                return;
            }

            bStart.Enabled = false;
            bStart.BackColor = Color.LightGreen;

            bStop.Enabled = true;
            bStop.BackColor = Color.FromArgb(255, 68, 68);

            bPause.Enabled = true;
            bPause.BackColor = Color.Yellow;

            numPopulationSize.Enabled = false;
            numCellSize.Enabled = false;

            cellSize = (int)numCellSize.Value;

            gameLogic = new GameLogic
                (
                    rows: gameWorld.Height / cellSize,
                    columns: gameWorld.Width / cellSize,
                    populationSize: (int)numPopulationSize.Value
                );

            gameWorld.Image = new Bitmap(gameWorld.Width, gameWorld.Height);
            graphics = Graphics.FromImage(gameWorld.Image);
            gameTimer.Start();
        }

        private void PauseGame() 
        {
            gameTimer.Stop();
            isPaused = true;
            bPause.Text = "Продолжить";
        }

        private void UnpauseGame() 
        {
            gameTimer.Start();
            isPaused = false;
            bPause.Text = "Пауза";
        }

        private void StopGame() 
        {
            if ( isPaused ) 
            {
                UnpauseGame();
            }

            graphics.Clear(gameWorld.BackColor);
            gameWorld.Refresh();

            gameTimer.Stop();

            numCellSize.Enabled = true;
            numPopulationSize.Enabled = true;

            bStart.BackColor = Color.LimeGreen;
            bStart.Enabled = true;

            bPause.BackColor = Color.FromArgb(255, 255, 128);
            bPause.Enabled = false;

            bStop.BackColor = Color.FromArgb(255, 128, 128);
            bStop.Enabled = false;

            labGenerationNum.Text = $"Номер поколения: 0";
        }

        private void DrawNextGeneration() 
        {
            graphics.Clear(gameWorld.BackColor);

            var gameField = gameLogic.GetGameField();
            for (int y = 0; y < gameField.GetLength(1); y++) 
            {
                for (int x = 0; x < gameField.GetLength(0); x++)
                {
                    if (gameField[x,y]) 
                    {
                        graphics.FillRectangle(Brushes.Orange, x * cellSize, y * cellSize, cellSize, cellSize);
                    }
                }
            }
            labGenerationNum.Text = $"Номер поколения: {gameLogic.currentGeneration}";
            gameWorld.Refresh();
            gameLogic.NextGeneration();
        }
        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            if (!isPaused) 
            {
                PauseGame();
            }

            else 
            {
                UnpauseGame();
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void gameWorld_MouseMove(object sender, MouseEventArgs e)
        {
            if (!gameTimer.Enabled)
            {
                return;
            }
            
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / cellSize;
                var y = e.Location.Y / cellSize;
                gameLogic.AddCell(x, y);
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / cellSize;
                var y = e.Location.Y / cellSize;
                gameLogic.RemoveCell(x, y);
            }
        }

        private void numGameSpeed_Changed(object sender, EventArgs e)
        {
            gameTimer.Interval = 500 / (int)numGameSpeed.Value;
        }
    }
}
