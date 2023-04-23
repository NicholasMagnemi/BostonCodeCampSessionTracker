using BostonCodeCampSessionTracker.Data;
using System.Text.RegularExpressions;

namespace BostonCodeCampSessionTracker
{
    public partial class SessionTrackerForm : Form
    {
        public SessionTrackerForm()
        {
            InitializeComponent();
        }

        private void btnCreateSpeaker_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addSpeaker(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, txtBoxPhoneNumber.Text, txtBoxDayOfContactPhoneNumber.Text, txtBoxShortBio.Text, txtBoxPastTalksGiven.Text);

            updateSpeakerComboBoxes();
        }

        private void updateSpeakerComboBoxes()
        {
            DataAccess db = new DataAccess();

            List<String> speakerNames = db.retrieveSpeakerNames();
            cmbSpeakerName.Items.Clear();

            foreach (String speakerName in speakerNames)
            {
                cmbSpeakerName.Items.Add(speakerName);
            }
        }

        private void btnClearSpeakerFields_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEmail.Text = "";
            txtBoxShortBio.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxDayOfContactPhoneNumber.Text = "";
            txtBoxPastTalksGiven.Text = "";
        }

        private void btnRemoveSpeaker_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int speakerId = db.retrieveSpeakerId(txtBoxFirstName.Text + " " + txtBoxLastName.Text);

            db.deleteSpeaker(speakerId);
        }

        private void btnSpeakerExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearRoomFields_Click(object sender, EventArgs e)
        {
            txtBoxRoomID.Text = "";
            txtBoxMaxCapacity.Text = "";
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addRoom(Convert.ToInt32(txtBoxMaxCapacity.Text), txtBoxRoomID.Text);

            updateRoomComboBoxes();
        }

        private void updateRoomComboBoxes()
        {
            DataAccess db = new DataAccess();

            List<String> rooms = db.retrieveRoomNames();

            cmbSessionRoomName.Items.Clear();

            foreach (String room in rooms)
            {
                cmbSessionRoomName.Items.Add(room);
            }
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int roomId = db.retrieveRoomId(txtBoxRoomID.Text);

            db.deleteRoom(roomId);
        }

        private void btnRoomExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearTimeSlotFields_Click(object sender, EventArgs e)
        {
            tmpStartTime.Text = "12:00 AM";
            tmpEndTime.Text = "12:00 AM";
            dpSessionDate.Text = "";
        }

        private void btnCreateTimeSlot_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();


            db.addTimeSlot(tmpStartTime.Value, tmpEndTime.Value);
            updateTimeSlotComboBoxes();
        }

        private void updateTimeSlotComboBoxes()
        {
            DataAccess db = new DataAccess();

            List<String> times = db.retrieveAFullTimeSlot();
            cmbSessionTimeSlots.Items.Clear();

            foreach (String time in times)
            {
                cmbSessionTimeSlots.Items.Add(time);
            }
        }

        private void btnRemoveTimeSlot_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int timeSlotId = db.retrieveTimeId(cmbSessionTimeSlots.Text);

            db.deleteTimeSlot(timeSlotId);
        }

        private void btnTimeSlotExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearSessionFields_Click(object sender, EventArgs e)
        {
            txtBoxSessionName.Text = "";
            cmbSpeakerName.Text = "";
            cmbSessionRoomName.Text = "";
            cmbSessionTimeSlots.Text = "";
            txtSessionTimeDuration.Text = "";
        }

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addSession(txtBoxSessionName.Text, cmbSessionRoomName.Text, cmbSpeakerName.Text, cmbSessionTimeSlots.Text);
        }

        private void btnRemoveSession_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int sessionId = db.retrieveSessionId(txtBoxSessionName.Text);

            db.deleteSession(sessionId);
        }

        private void btnSessionExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateComboBoxes()
        {
            updateSpeakerComboBoxes();
            updateRoomComboBoxes();
            updateTimeSlotComboBoxes();
            updateOverviewSpeakerNamesComboBox();
        }

        private void tbcSessionTracker_Click(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void cmbSpeakerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateOverviewSpeakerNamesComboBox()
        {
            DataAccess db = new DataAccess();

            List<String> speakerNames = db.retrieveSpeakerNames();

            cmbOverviewSpeakerName.Items.Clear();

            foreach (String speakerName in speakerNames)
            {
                cmbOverviewSpeakerName.Items.Add(speakerName);
            }
        }

        private void updateOverviewSessionsComboBox()
        {
            DataAccess db = new DataAccess();

            int speakerId = db.retrieveSpeakerId(cmbOverviewSpeakerName.Text);

            List<String> speakerSessions = db.retrieveSpeakersSessions(speakerId);

            foreach (String speakerSession in speakerSessions)
            {
                cmbOverviewSessionNames.Items.Add(speakerSession);
            }
        }

        private void updateOverviewTimeSlotsComboBox()
        {
            DataAccess db = new DataAccess();

            int sessionId = db.retrieveSessionId(cmbOverviewSessionNames.Text);

            List<String> sessionTimeSlots = db.retrieveSpeakersTimeSlots(sessionId);

            foreach (String sessionTimeSlot in sessionTimeSlots)
            {
                cmbOverviewTimeSlots.Items.Add(sessionTimeSlot);
            }
        }

        private void updateOverviewTimeDurationlbl()
        {
            DataAccess db = new DataAccess();

            int timeSlotId = db.retrieveTimeId(cmbOverviewTimeSlots.Text);

            String timeDuration = db.retrieveSpeakersSessionDuration(timeSlotId);

            lblOverviewTimeDuration.Text = timeDuration;
        }

        private void updateOverviewRoomNamelbl()
        {
            DataAccess db = new DataAccess();

            int sessionId = db.retrieveSessionId(cmbOverviewSessionNames.Text);

            String roomName = db.retrieveSpeakersRoomName(sessionId);

            lblOverviewRoomName.Text = roomName;
        }

        private void cmbOverviewSpeakerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateOverviewSessionsComboBox();
        }

        private void cmbOverviewSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateOverviewTimeSlotsComboBox();
            updateOverviewRoomNamelbl();
        }

        private void cmbOverviewTimeSlots_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateOverviewTimeDurationlbl();
        }

        private void lblOverviewRoomName_Click(object sender, EventArgs e)
        {

        }

        private void txtSessionTimeDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }


            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxFirstName.Text.Length == 25)
            {
                e.Handled = true;
            }
        }

        private void txtBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }


            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxFirstName.Text.Length == 25)
            {
                e.Handled = true;
            }


        }

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '@')
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxEmail.Text.Length == 25)
            {
                e.Handled = true;
            }
        }

        private void txtBoxShortBio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }



            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxShortBio.Text.Length == 500)
            {
                e.Handled = true;
            }
        }

        private void txtBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (!Regex.IsMatch(txtBoxPhoneNumber.Text, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxDayOfContactPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (!Regex.IsMatch(txtBoxDayOfContactPhoneNumber.Text, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtBoxPastTalksGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxShortBio.Text.Length == 500)
            {
                e.Handled = true;
            }
        }

        private void txtBoxRoomID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxRoomID.Text.Length == 25)
            {
                e.Handled = true;
            }
        }

        private void txtBoxMaxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtBoxMaxCapacity.Text.Length == 4)
            {
                e.Handled = true;
            }
        }

        private void txtBoxSessionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar != ' ')
            {
                e.Handled = false;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxSessionName.Text.Length == 15)
            {
                e.Handled = true;
            }
        }

        private void btnOverviewExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToSpeakerForm_Click(object sender, EventArgs e)
        {
            tbcSessionTracker.SelectTab(tbSpeakerInfo);
        }

        private void btnGoToNewSession_Click(object sender, EventArgs e)
        {
            tbcSessionTracker.SelectTab(tbSessionInfo);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
