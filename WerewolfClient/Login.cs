using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            public string name { get; set; }
            public string ip { get; set; }
            public bool enabled { get; set; }
            public bool legacy { get; set; }
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
                    cbServerlist.Items.Add(new { Text = data.name, Value = data.ip, Enabled = data.enabled });
                }

                cbServerlist.DisplayMember = "Text";
                cbServerlist.ValueMember = "Value";
                cbServerlist.SelectedIndex = 0;
            }
            else
            {
                Console.WriteLine("server.json not found..");
                //TODO: Add server.json generator
            }
        }

        public void Notify(Model m)
        {
            if (m is WerewolfModel)
            {
                WerewolfModel wm = (WerewolfModel)m;
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
                            MessageBox.Show("Login or password incorrect, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (TbLogin.Text.Equals("") || TbPassword.Text.Equals(""))
                MessageBox.Show("Please input username and/or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand();
                wcmd.Action = WerewolfCommand.CommandEnum.SignIn;
                wcmd.Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", (cbServerlist.SelectedItem as dynamic).Value } };
                controller.ActionPerformed(wcmd);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (TbLogin.Text.Equals("") || TbPassword.Text.Equals(""))
                MessageBox.Show("Please input username and/or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand();
                wcmd.Action = WerewolfCommand.CommandEnum.SignUp;
                wcmd.Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", (cbServerlist.SelectedItem as dynamic).Value } };
                controller.ActionPerformed(wcmd);
            }
        }

        private void btnExit_OnClicked(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Environment.Exit(0);
        }
    }
}
