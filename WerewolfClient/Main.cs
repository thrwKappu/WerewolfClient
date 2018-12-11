using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class Main : Form, View
    {
        private WerewolfController controller;
        private Form _gameForm;
        private Form _loginForm;

        private Timer _MMTimer;

        private bool _isMM = false;
        

        public Main(Form game)
        {
            InitializeComponent();
            _gameForm = game;
        }

        public void setLoginForm(Form _lf)
        {
            _loginForm = _lf;
        }

        public void setController(Controller c)
        {
            controller = (WerewolfController)c;
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            _MMTimer = new Timer();

            if (!_isMM)
            {
                WerewolfCommand wcmd = new WerewolfCommand();
                wcmd.Action = WerewolfCommand.CommandEnum.JoinGame;
                controller.ActionPerformed(wcmd);
            }
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand();
                wcmd.Action = WerewolfCommand.CommandEnum.CancelJoin;
                controller.ActionPerformed(wcmd);

                _isMM = false;
                _MMTimer.Dispose();
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            if (_isMM)
            {
                btnMM_Click(sender, e);
            }

            WerewolfCommand wcmd = new WerewolfCommand();
            wcmd.Action = WerewolfCommand.CommandEnum.SignOut;
            controller.ActionPerformed(wcmd);
        }

        private void ShowPlayerInfo(WerewolfModel wm)
        {
            //there's should be better detection somewhere, we'll see.
            if ( wm != null && wm.Player != null && wm.Player.Name != null)
            {
                tbUID.Text = wm.Player.Id.ToString();
                tbUsername.Text = wm.Player.Name.ToString();
            }
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            WerewolfCommand wcmd = new WerewolfCommand();
            wcmd.Action = WerewolfCommand.CommandEnum.RequestUpdate;
            controller.ActionPerformed(wcmd);
        }

        public void Notify(Model m)
        {
            if (m is WerewolfModel)
            {
                WerewolfModel wm = (WerewolfModel)m;
                switch (wm.Event)
                {
                    case WerewolfModel.EventEnum.SignOut:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            _loginForm.Visible = true;
                            this.Visible = false;
                        }
                        break;
                    
                    case WerewolfModel.EventEnum.JoinGame:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            _MMTimer.Interval = 1000;
                            _MMTimer.Tick += new EventHandler(OnTimerEvent);
                            _MMTimer.Enabled = true;

                            btnMM.Text = "Joining Room #" + wm.EventPayloads["Game.Id"] + "\r\n(Queuing: " + wm.EventPayloads["Game.Count"] + "Players)";

                            _isMM = true;
                        }
                        break;
                    case WerewolfModel.EventEnum.CancelJoin:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            btnMM.Text = "Auto Matchmaking";
                            _isMM = false;
                        }
                        break;
                    case WerewolfModel.EventEnum.GameStarted:
                        _gameForm.Visible = true;
                        this.Visible = false;
                        _isMM = false;
                        _MMTimer.Dispose();
                        break;
                }

                ShowPlayerInfo(wm);
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Exit?");

            //Call logout event
            btnLogoff_Click(sender, e);

            Environment.Exit(0);
        }
    }
}
