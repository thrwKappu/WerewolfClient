using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Game mGameForm = new Game();
            mGameForm.Visible = false;

            Main mMainForm = new Main(mGameForm);
            mMainForm.Visible = false;

            Login mLogin = new Login(mMainForm);

            UserControl IntroForm = new ctrlIntro(mLogin);

            //Return to lobby
            mGameForm.SetMainMenu(mMainForm);

            //too lazy to figure better solution yet
            mMainForm.SetLoginForm(mLogin);



            WerewolfController mController =  WerewolfController.GetInstance();
            WerewolfModel mModel = new WerewolfModel();

            // View -> Controller
            mMainForm.setController(mController);
            mLogin.setController(mController);
            mGameForm.setController(mController);

            // Controler -> Model
            mController.AddModel(mModel);

            // Model -> View
            mModel.AttachObserver(mLogin);
            mModel.AttachObserver(mMainForm);
            mModel.AttachObserver(mGameForm);

            Application.Run(mLogin);

            //Application.Run(new Main());
        }
    }
}
