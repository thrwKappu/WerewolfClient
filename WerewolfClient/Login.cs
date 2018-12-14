using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WerewolfClient
{

    public partial class Login : Form, View
    {
        //For dealing with JSON
        protected class ServerInfo
        {
            public string Name { get; set; }
            public string Ip { get; set; }
            public bool Enabled { get; set; }
            public bool Legacy { get; set; }
        }

        private WerewolfController controller;
        protected Form _mainForm;
        public Login(Form MainForm)
        {
            InitializeComponent();
            _mainForm = MainForm;

            GenerateServerList();
            
        }

        private void GenerateServerList()
        {
            if (System.IO.File.Exists("server.json"))
            {
                var _svListJSON = JsonConvert.DeserializeObject<List<ServerInfo>>(System.IO.File.ReadAllText("server.json"));
                
                foreach (var data in _svListJSON)
                {
                    var _svt = data.Legacy == true ? "Legacy" : "";
                    cbServerlist.Items.Add(new { Text = data.Name, Value = data.Ip, data.Enabled, Tag = _svt});
                }

                cbServerlist.DisplayMember = "Text";
                cbServerlist.ValueMember = "Value";
                
                cbServerlist.SelectedIndex = 0;

                pnUserAcc.Enabled = true;
                pnUserAcc.Visible = true;
            }
            else
            {
                Console.WriteLine("server.json not found..");
                //TODO: Add server.json generator
            }
        }

        public void Notify(Model m)
        {
            if (m is WerewolfModel wm)
            {
                switch (wm.Event)
                {
                    case WerewolfModel.EventEnum.SignIn:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            //Remove Password after login
                            TbPassword.Text = null;

                            _mainForm.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show(wm.EventPayloads["Error"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case WerewolfModel.EventEnum.SignUp:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            MessageBox.Show("Sign up successfuly, please login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show(wm.EventPayloads["Error"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
        }

        public void setController(Controller c)
        {
            controller = (WerewolfController)c;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (TbLogin.Text.Equals("") || TbPassword.Text.Equals("")) {
                string _missingType = (TbLogin.Text.Equals("") && TbPassword.Text.Equals("")) ? "and" : "or";
                MessageBox.Show("Please input username " + _missingType + " password","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = WerewolfCommand.CommandEnum.SignIn,
                    Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", (cbServerlist.SelectedItem as dynamic).Value } }
                };
                controller.ActionPerformed(wcmd);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (TbLogin.Text.Equals("") || TbPassword.Text.Equals(""))
            {
                string _missingType = (TbLogin.Text.Equals("") && TbPassword.Text.Equals("")) ? "and" : "or";
                MessageBox.Show("Please input username " + _missingType + " password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand
                {
                    Action = WerewolfCommand.CommandEnum.SignUp,
                    Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", (cbServerlist.SelectedItem as dynamic).Value }, { "Type",  (cbServerlist.SelectedItem as dynamic).Tag } }
                };
                controller.ActionPerformed(wcmd);
            }
        }

        private void BtnExit_OnClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Application.Exit();
        }
    }
}
