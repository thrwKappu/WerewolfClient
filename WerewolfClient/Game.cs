using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventEnum = WerewolfClient.WerewolfModel.EventEnum;
using CommandEnum = WerewolfClient.WerewolfCommand.CommandEnum;
using WerewolfAPI.Model;
using Role = WerewolfAPI.Model.Role;

namespace WerewolfClient
{
    public partial class Game : Form, View
    {
        private Timer _updateTimer;
        private WerewolfController controller;
        private WerewolfAPI.Model.Game.PeriodEnum _currentPeriod;
        private int _currentDay;
        private int _currentTime;
        private bool _voteActivated;
        private bool _actionActivated;
        private string _myRole;
        private bool _isDead;
        private List<Player> players = null;
        private System.Drawing.Image _dayBG;
        private Form _mainMenu;
        private int _myGID = 0;

        public Game()
        {
            InitializeComponent();

            _dayBG = this.GBPlayers.BackgroundImage;

            foreach (int i in Enumerable.Range(0, 16))
            {
                this.Controls["GBPlayers"].Controls["BtnPlayer" + i].Click += new System.EventHandler(this.BtnPlayerX_Click);
                this.Controls["GBPlayers"].Controls["BtnPlayer" + i].Tag = i;
            }

            _updateTimer = new Timer();
            _voteActivated = false;
            _actionActivated = false;
            EnableButton(btnLeave, true);
            EnableButton(BtnAction, false);
            EnableButton(BtnVote, false);
            _myRole = null;
            _isDead = false;
        }
        
        public void SetMainMenu(Form _f)
        {
            _mainMenu = _f;
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            WerewolfCommand wcmd = new WerewolfCommand
            {
                Action = CommandEnum.RequestUpdate
            };
            controller.ActionPerformed(wcmd);
        }

        public void AddChatMessage(string str)
        {
            AddChatMessage(str, "[System]");
        }

        public void AddChatMessage(string str, string owner)
        {
            if (owner.Equals("[System]"))
                TbChatBox.SelectionColor = Color.DarkGray;

            if (Controls["GBPlayers"].Controls["BtnPlayer" + _myGID].Text.Contains(owner))
                TbChatBox.SelectionColor = Color.DarkGreen;

            DateTime _curTime = DateTime.Now;
            TbChatBox.AppendText("[" + _curTime.ToLocalTime().ToShortTimeString() + "] " + str + Environment.NewLine);
            TbChatBox.SelectionColor = TbChatBox.ForeColor;
        }

        public void EnableButton(Button btn, bool state)
        {
            btn.Visible = btn.Enabled = state;
        }

        private void UpdateAvatar(WerewolfModel wm)
        {
            int i = 0;
            foreach (Player player in wm.Players)
            {
                var _cpBtn = Controls["GBPlayers"].Controls["BtnPlayer" + i];

                EnableButton((Button)_cpBtn, true);
                _cpBtn.Text = (i+1) + ". " + player.Name;
                _cpBtn.ForeColor = Color.Black;

                //Custom for self
                if (player.Name == wm.Player.Name)
                {
                    _cpBtn.Text += "\n(You)";
                    _cpBtn.ForeColor = Color.DarkGreen;
                }

                if (player.Name == wm.Player.Name || player.Status != Player.StatusEnum.Alive)
                {
                    // FIXME, need to optimize this
                    Image img = Properties.Resources.Icon_villager;
                    string role;
                    if (player.Name == wm.Player.Name)
                    {
                        role = _myRole;
                        _myGID = i;
                    }
                    else if (player.Role != null)
                    {
                        role = player.Role.Name;
                    }
                    else
                    {
                        continue;
                    }
                    switch (role)
                    {
                        case WerewolfModel.ROLE_SEER:
                            img = Properties.Resources.Icon_seer;
                            break;
                        case WerewolfModel.ROLE_AURA_SEER:
                            img = Properties.Resources.Icon_aura_seer;
                            break;
                        case WerewolfModel.ROLE_PRIEST:
                            img = Properties.Resources.Icon_priest;
                            break;
                        case WerewolfModel.ROLE_DOCTOR:
                            img = Properties.Resources.Icon_doctor;
                            break;
                        case WerewolfModel.ROLE_WEREWOLF:
                            img = Properties.Resources.Icon_werewolf;
                            break;
                        case WerewolfModel.ROLE_WEREWOLF_SEER:
                            img = Properties.Resources.Icon_wolf_seer;
                            break;
                        case WerewolfModel.ROLE_ALPHA_WEREWOLF:
                            img = Properties.Resources.Icon_alpha_werewolf;
                            break;
                        case WerewolfModel.ROLE_WEREWOLF_SHAMAN:
                            img = Properties.Resources.Icon_wolf_shaman;
                            break;
                        case WerewolfModel.ROLE_MEDIUM:
                            img = Properties.Resources.Icon_medium;
                            break;
                        case WerewolfModel.ROLE_BODYGUARD:
                            img = Properties.Resources.Icon_bodyguard;
                            break;
                        case WerewolfModel.ROLE_JAILER:
                            img = Properties.Resources.Icon_jailer;
                            break;
                        case WerewolfModel.ROLE_FOOL:
                            img = Properties.Resources.Icon_fool;
                            break;
                        case WerewolfModel.ROLE_HEAD_HUNTER:
                            img = Properties.Resources.Icon_head_hunter;
                            break;
                        case WerewolfModel.ROLE_SERIAL_KILLER:
                            img = Properties.Resources.Icon_serial_killer;
                            break;
                        case WerewolfModel.ROLE_GUNNER:
                            img = Properties.Resources.Icon_gunner;
                            break;
                    }
                    ((Button)Controls["GBPlayers"].Controls["BtnPlayer" + i]).Image = img;
                }
                i++;
            }
        }
        public void Notify(Model m)
        {
            if (m is WerewolfModel wm)
            {
                switch (wm.Event)
                {
                    case WerewolfModel.EventEnum.CancelJoin:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            this.Visible = false;
                            _mainMenu.Visible = true;
                        }
                        break;
                    case EventEnum.GameStopped:
                        AddChatMessage("Game is finished, outcome is " + wm.EventPayloads["Game.Outcome"]);
                        _updateTimer.Enabled = false;
                        break;
                    case EventEnum.GameStarted:
                        //Hide all players
                        foreach (var plrBtn in Controls["GBPlayers"].Controls.OfType<Button>())
                        {
                            EnableButton(plrBtn, !(plrBtn.Name.StartsWith("BtnPlayer")));
                        }

                        AddChatMessage("Joined Game #" + wm.EventPayloads["Game.Id"]);
                        _updateTimer.Interval = 1000;
                        _updateTimer.Tick += new EventHandler(OnTimerEvent);
                        _updateTimer.Enabled = true;

                        players = wm.Players;
                        _myRole = wm.EventPayloads["Player.Role.Name"];
                        AddChatMessage("Your role is " + _myRole + ".");
                        _currentPeriod = WerewolfAPI.Model.Game.PeriodEnum.Night;
                        EnableButton(BtnAction, true);
                        switch (_myRole)
                        {
                            case WerewolfModel.ROLE_PRIEST:
                                BtnAction.Text = WerewolfModel.ACTION_HOLYWATER;
                                break;
                            case WerewolfModel.ROLE_GUNNER:
                                BtnAction.Text = WerewolfModel.ACTION_SHOOT;
                                break;
                            case WerewolfModel.ROLE_JAILER:
                                BtnAction.Text = WerewolfModel.ACTION_JAIL;
                                break;
                            case WerewolfModel.ROLE_WEREWOLF_SHAMAN:
                                BtnAction.Text = WerewolfModel.ACTION_ENCHANT;
                                break;
                            case WerewolfModel.ROLE_BODYGUARD:
                                BtnAction.Text = WerewolfModel.ACTION_GUARD;
                                break;
                            case WerewolfModel.ROLE_DOCTOR:
                                BtnAction.Text = WerewolfModel.ACTION_HEAL;
                                break;
                            case WerewolfModel.ROLE_SERIAL_KILLER:
                                BtnAction.Text = WerewolfModel.ACTION_KILL;
                                break;
                            case WerewolfModel.ROLE_SEER:
                            case WerewolfModel.ROLE_WEREWOLF_SEER:
                                BtnAction.Text = WerewolfModel.ACTION_REVEAL;
                                break;
                            case WerewolfModel.ROLE_AURA_SEER:
                                BtnAction.Text = WerewolfModel.ACTION_AURA;
                                break;
                            case WerewolfModel.ROLE_MEDIUM:
                                BtnAction.Text = WerewolfModel.ACTION_REVIVE;
                                break;
                            default:
                                EnableButton(BtnAction, false);
                                break;
                        }
                        EnableButton(BtnVote, true);
                        UpdateAvatar(wm);
                        break;
                    case EventEnum.SwitchToDayTime:
                        AddChatMessage("Switch to day time of day #" + wm.EventPayloads["Game.Current.Day"] + ".");
                        _currentPeriod = WerewolfAPI.Model.Game.PeriodEnum.Day;
                        
                        this.GBPlayers.BackgroundImage = _dayBG;
                        break;
                    case EventEnum.SwitchToNightTime:
                        AddChatMessage("Switch to night time of day #" + wm.EventPayloads["Game.Current.Day"] + ".");
                        _currentPeriod = WerewolfAPI.Model.Game.PeriodEnum.Night;

                        break;
                    case EventEnum.UpdateDay:
                        // TODO  catch parse exception here
                        string tempDay = wm.EventPayloads["Game.Current.Day"];
                        _currentDay = int.Parse(tempDay);

                        break;
                    case EventEnum.UpdateTime:
                        string tempTime = wm.EventPayloads["Game.Current.Time"];
                        _currentTime = int.Parse(tempTime);
                        
                        UpdateAvatar(wm);
                        break;
                    case EventEnum.Vote:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            AddChatMessage("Your vote is registered.");
                        }
                        else
                        {
                            AddChatMessage("You can't vote now.");
                        }
                        break;
                    case EventEnum.Action:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            AddChatMessage("Your action is registered.");
                        }
                        else
                        {
                            AddChatMessage("You can't perform action now.");
                        }
                        break;
                    case EventEnum.YouShotDead:
                        AddChatMessage("You're shot dead by gunner.");
                        _isDead = true;
                        break;
                    case EventEnum.OtherShotDead:
                        AddChatMessage(wm.EventPayloads["Game.Target.Name"] + " was shot dead by gunner.");
                        break;
                    case EventEnum.Alive:
                        AddChatMessage(wm.EventPayloads["Game.Target.Name"] + " has been revived by medium.");
                        if (wm.EventPayloads["Game.Target.Id"] == null)
                        {
                            _isDead = false;
                        }
                        break;
                    case EventEnum.ChatMessage:
                        if (wm.EventPayloads["Success"] == WerewolfModel.TRUE)
                        {
                            AddChatMessage(wm.EventPayloads["Game.ChatMessage"], wm.EventPayloads["Game.Chatter"]);
                        }
                        break;
                    case EventEnum.Chat:
                        if (wm.EventPayloads["Success"] == WerewolfModel.FALSE)
                        {
                            switch (wm.EventPayloads["Error"])
                            {
                                case "403":
                                    AddChatMessage("You're not alive, can't talk now.");
                                    break;
                                case "404":
                                    AddChatMessage("You're not existed, can't talk now.");
                                    break;
                                case "405":
                                    AddChatMessage("You're not in a game, can't talk now.");
                                    break;
                                case "406":
                                    AddChatMessage("You're not allow to talk now, go to sleep.");
                                    break;
                            }
                        }
                        break;
                }

                LBPeriod.Text = (_currentPeriod == WerewolfAPI.Model.Game.PeriodEnum.Day) ? "Day" : (_currentPeriod == WerewolfAPI.Model.Game.PeriodEnum.Night) ? "Night" : "N/A";
                LBDay.Text = "#" + _currentDay + "/10";
                LBTime.Text = _currentTime + "/30";
                // need to reset event
                wm.Event = EventEnum.NOP;
            }
        }

        public void setController(Controller c)
        {
            controller = (WerewolfController)c;
        }

        private void LeaveGame()
        {
            _updateTimer.Stop();
            _updateTimer.Dispose();

            WerewolfCommand wcmd = new WerewolfCommand
            {
                Action = WerewolfCommand.CommandEnum.CancelJoin
            };
            controller.ActionPerformed(wcmd);
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave the game?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);

            LeaveGame();
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            if (_voteActivated)
            {
                BtnVote.BackColor = Button.DefaultBackColor;
            }
            else
            {
                BtnVote.BackColor = Color.Red;
            }
            _voteActivated = !_voteActivated;
            if (_actionActivated)
            {
                BtnAction.BackColor = Button.DefaultBackColor;
                _actionActivated = false;
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (_isDead)
            {
                AddChatMessage("You're dead!!");
                return;
            }
            if (_actionActivated)
            {
                BtnAction.BackColor = Button.DefaultBackColor;
            }
            else
            {
                BtnAction.BackColor = Color.Red;
            }
            _actionActivated = !_actionActivated;
            if (_voteActivated)
            {
                BtnVote.BackColor = Button.DefaultBackColor;
                _voteActivated = false;
            }
        }

        private void BtnPlayerX_Click(object sender, EventArgs e)
        {
            Button btnPlayer = (Button)sender;
            int index = (int) btnPlayer.Tag;
            if (players == null)
            {
                // Nothing to do here;
                return;
            }
            if (_actionActivated)
            {
                _actionActivated = false;
                BtnAction.BackColor = Button.DefaultBackColor;
                AddChatMessage("You perform [" + BtnAction.Text + "] on " + players[index].Name);
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = CommandEnum.Action,
                    Payloads = new Dictionary<string, string>() { { "Target", players[index].Id.ToString() } }
                };
                controller.ActionPerformed(wcmd);
            }
            if (_voteActivated)
            {
                _voteActivated = false;
                BtnVote.BackColor = Button.DefaultBackColor;
                AddChatMessage("You vote on " + players[index].Name);
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = CommandEnum.Vote,
                    Payloads = new Dictionary<string, string>() { { "Target", players[index].Id.ToString() } }
                };
                controller.ActionPerformed(wcmd);
            }
        }

        private void TbChatInput_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && TbChatInput.Text != "")
            {
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = CommandEnum.Chat,
                    Payloads = new Dictionary<string, string>() { { "Message", TbChatInput.Text } }
                };
                TbChatInput.Text = "";
                controller.ActionPerformed(wcmd);
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            LeaveGame();
        }
    }
}
