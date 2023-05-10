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
            using (frmLoginForm loginForm = new frmLoginForm())
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
            frmSessionTrackerForm mainForm = new frmSessionTrackerForm();
            mainForm.FormClosed += (s, e) => ExitThread();
            mainForm.UserInactive += MainForm_UserInactive;
            mainForm.Show();
        }

        private void MainForm_UserInactive(object sender, EventArgs e)
        {
            frmSessionTrackerForm mainForm = sender as frmSessionTrackerForm;

            if (mainForm != null)
            {
                mainForm.Close();
                ShowLoginForm();
            }
        }
    }
}
