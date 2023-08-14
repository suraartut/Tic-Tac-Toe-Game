namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Pink;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void RestartGameButton(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {

        }

        private void RestartGame()
        {
            buttons = new List<Button> {button1,button2,button3,button4,button5,button6,button7,button8,button9 };

            foreach(Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}