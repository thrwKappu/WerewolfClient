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

            _MMTimer = new Timer();
        }

        public void SetLoginForm(Form _lf)
        {
            _loginForm = _lf;
        }

        public void setController(Controller c)
        {
            controller = (WerewolfController)c;
        }

        private void BtnMM_Click(object sender, EventArgs e)
        {
            if (!_isMM)
            {
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = WerewolfCommand.CommandEnum.JoinGame
                };
                controller.ActionPerformed(wcmd);
            }
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = WerewolfCommand.CommandEnum.CancelJoin
                };
                controller.ActionPerformed(wcmd);
            }
        }

        private void BtnLogoff_Click(object sender, EventArgs e)
        {
            if (_isMM)
            {
                BtnMM_Click(sender, e);
            }

            WerewolfCommand wcmd = new WerewolfCommand
            {
                Action = WerewolfCommand.CommandEnum.SignOut
            };
            controller.ActionPerformed(wcmd);
        }

        private void ShowPlayerInfo(WerewolfModel wm)
        {
            //there's should be better detection somewhere, we'll see.
            if ( wm != null && wm.Player != null && wm.Player.Name != null)
            {
                tbUID.Text = wm.Player.Id.ToString();
                tbUsername.Text = wm.Player.Name.ToString();

                var _regisDate = wm.Player.Regisdate.ToString();
                tbRegisDate.Text = _regisDate;
            }
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            WerewolfCommand wcmd = new WerewolfCommand
            {
                Action = WerewolfCommand.CommandEnum.RequestUpdate
            };
            controller.ActionPerformed(wcmd);
        }

        public void Notify(Model m)
        {
            if (m is WerewolfModel wm)
            {
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

                            BtnMM.Text = "Cancel";

                            _isMM = true;
                        }
                        break;
                    case WerewolfModel.EventEnum.CancelJoin:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            BtnMM.Text = "Auto Matchmaking";

                            _isMM = false;

                            _MMTimer.Enabled = false;
                            _MMTimer.Dispose();
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
            //Call logout event
            BtnLogoff_Click(sender, e);
        }
    }
}
