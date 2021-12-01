using System;
using static FinalPOE.MovementEnum;
using System.Windows.Forms;

namespace FinalPOE
{
    public partial class GameWindow : Form
    {
        GameEngine engine;
        public frmHelp helpForm;
        GameSettings settings;
        
        Hero h;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void RefreshWindow()
        {
            if (h == null)
            {
                h = engine.Map.Hero;
            }

            lblMapDisplay.Text = engine.Map.ToString();
        }

        public void GetGameSetForm(GameSettings settings)
        {
            this.settings = settings;
        }

        private void RefreshHUD()
        {
            if (engine.Map.Hero.HP < 0)
            {
                //Sometimes fails to set itself to 0 so this is just an extra measure.
                engine.Map.Hero.HP = 0;
            }

            if (engine.enemyAttackIndicator != "")

                lblInfo.Text = h.ToString() + engine.enemyAttackIndicator;
            else
                lblInfo.Text = h.ToString();
            
            if (lblSaveState.Text != "")
            {
                lblSaveState.Text = "";
            }
        }

        public void InitialiseGame(int minH, int minW, int MaxH, int MaxW, int numEnemy, int numGold, int numWeapon)
        {
            engine = new GameEngine(minH, minW, MaxH, MaxW, numEnemy, numGold, numWeapon);
            RefreshWindow();
            RefreshHUD();
        }

        public void InitialiseGame(GameEngine e)
        {
            engine = e;
            RefreshWindow();
            RefreshHUD();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            engine.Move(UP);
            RefreshWindow();
            RefreshHUD();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            engine.Move(LEFT);
            RefreshWindow();
            RefreshHUD();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            engine.Move(DOWN);
            RefreshWindow();
            RefreshHUD();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            engine.Move(RIGHT);
            RefreshWindow();
            RefreshHUD();
        }

        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm = new frmHelp();
            helpForm.Show();
        }

        private void btnAttackUp_Click(object sender, EventArgs e)
        {
            Attack(UP);
        }

        private void btnAttackLeft_Click(object sender, EventArgs e)
        {
            Attack(LEFT);
        }

        void Attack(MovementEnum dir)
        {
            Character attackedTarget = engine.PlayerAttack(dir);

            if (attackedTarget != null)
            {
                lblInfo.Text = "Player Attacked:\n" + attackedTarget.ToString()+
                    "\nTarget HP : " + attackedTarget.HP;
            }
            else
            {
                lblInfo.Text = "Attack failed!";
            }

           RefreshWindow();
        }

        private void btnAttackRight_Click(object sender, EventArgs e)
        {
            Attack(RIGHT);
        }

        private void btnAttackDown_Click(object sender, EventArgs e)
        {
            Attack(DOWN);
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            engine.Save();
            lblSaveState.Text = "Game Saved!";
        }
    }
}
