using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker
{
    public class LoginApplicationContext : ApplicationContext
    {
        public LoginApplicationContext()
        {
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    ShowMainForm();
                }
                else
                {
                    ExitThread();
                }
            }
        }

        private void ShowMainForm()
        {
            SessionTrackerForm mainForm = new SessionTrackerForm();
            mainForm.FormClosed += (s, e) => ExitThread();
            mainForm.UserInactive += MainForm_UserInactive;
            mainForm.Show();
        }

        private void MainForm_UserInactive(object sender, EventArgs e)
        {
            SessionTrackerForm mainForm = sender as SessionTrackerForm;

            if (mainForm != null)
            {
                mainForm.Close();
                ShowLoginForm();
            }
        }
    }
}
