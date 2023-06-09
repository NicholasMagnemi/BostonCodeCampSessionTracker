﻿using BostonCodeCampSessionTracker.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SemesterProjectTest;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BostonCodeCampSessionTracker
{
    public partial class frmSessionTrackerForm : Form
    {
        public event EventHandler UserInactive;

        public frmSessionTrackerForm()
        {
            InitializeComponent();
        }

        public void ResetInactivityTimer()
        {
            tmrInactivity.Stop();
            tmrInactivity.Start();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEMOVE = 0x0200;
            const int WM_KEYDOWN = 0x0100;

            if (m.Msg == WM_MOUSEMOVE || m.Msg == WM_KEYDOWN)
            {
                ResetInactivityTimer();
            }

            base.WndProc(ref m);
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

            db.addSession(txtBoxSessionName.Text, cmbSessionRoomName.Text, cmbSpeakerName.Text, cmbSessionTimeSlots.Text, "0", "0", "0");
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
            updateCountSessionNamesComboBox();
            updateTimeSlotTimeSlotsComboBox();
        }

        private void tbcSessionTracker_Click(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void updateOverviewSpeakerNamesComboBox()
        {
            DataAccess db = new DataAccess();

            cmbOverviewSpeakerName.Items.Clear();

            List<String> speakerNames = db.retrieveSpeakerNames();

            foreach (String speakerName in speakerNames)
            {
                cmbOverviewSpeakerName.Items.Add(speakerName);
            }
        }

        private void updateOverviewSessionsComboBox()
        {
            DataAccess db = new DataAccess();

            cmbOverviewSessionNames.Items.Clear();

            int speakerId = db.retrieveSpeakerId(cmbOverviewSpeakerName.Text);

            List<String> speakerSessions = db.retrieveSpeakersSessions(speakerId);

            foreach (String speakerSession in speakerSessions)
            {
                cmbOverviewSessionNames.Items.Add(speakerSession);
            }
        }

        private void updateCountSessionNamesComboBox()
        {
            DataAccess db = new DataAccess();

            cmbAttendanceSessionNames.Items.Clear();

            List<String> sessionNames = db.retrieveSessionNames();

            foreach (String sessionName in sessionNames)
            {
                cmbAttendanceSessionNames.Items.Add(sessionName);
            }
        }

        private void updateOverviewTimeSlotsComboBox()
        {
            DataAccess db = new DataAccess();

            cmbOverviewTimeSlots.Items.Clear();

            int aTimeSlotId = db.retrieveSessionTimeSlotId(cmbOverviewSessionNames.Text);

            List<String> sessionTimeSlots = db.retrieveSessionTimeSlots(aTimeSlotId);

            foreach (String sessionTimeSlot in sessionTimeSlots)
            {
                cmbOverviewTimeSlots.Items.Add(sessionTimeSlot);
            }
        }

        private void updateTimeSlotTimeSlotsComboBox()
        {
            DataAccess db = new DataAccess();

            cmbTimeFormFullTimeSlots.Items.Clear();

            List<String> fullTimeSlots = db.retrieveAllTimeSlots();

            foreach (String fullTimeSlot in fullTimeSlots)
            {
                cmbTimeFormFullTimeSlots.Items.Add(fullTimeSlot);
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

            int roomId = db.retieveRoomId(cmbOverviewSessionNames.Text);

            String roomName = db.retrieveSpeakersRoomName(roomId);

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

        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '@' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxEmail.Text.Length == 40)
            {
                e.Handled = true;
            }
        }

        private void txtBoxShortBio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\u0008')
            {
                e.Handled = false;
            }
            else if (txtBoxShortBio.Text.Length == 500)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (txtBoxPhoneNumber.Text.Length == 20)
            {
                e.Handled = true;
            }
        }

        private void txtBoxDayOfContactPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (txtBoxPhoneNumber.Text.Length == 20)
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

            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
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

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (txtBoxMaxCapacity.Text.Length == 4)
            {
                e.Handled = true;
            }
        }

        private void txtBoxSessionName_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void btnSaveCount_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            InputValidation validNumber = new InputValidation();

            db.updateSessionCounts(db.retrieveSessionId(cmbAttendanceSessionNames.Text), txtBeginningCount.Text, txtMiddleCount.Text, txtEndingCount.Text);
        }

        private void updatecmbAttendanceSessionNames()
        {
            DataAccess db = new DataAccess();

            List<String> roomNames = db.retrieveSessionNames();

            foreach (String roomName in roomNames)
            {
                cmbAttendanceSessionNames.Items.Add(roomName);
            }
        }

        private void cmbSessionTimeSlots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBeginningCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (txtBoxMaxCapacity.Text.Length == 4)
            {
                e.Handled = true;
            }
        }

        private void txtMiddleCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (txtBoxMaxCapacity.Text.Length == 4)
            {
                e.Handled = true;
            }
        }

        private void txtEndingCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndingCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (txtBoxMaxCapacity.Text.Length == 4)
            {
                e.Handled = true;
            }
        }

        private void BtnAttendanceExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbcSessionTracker_Selecting(object sender, TabControlCancelEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            List<string> sessionInfoList = dataAccess.ListSessionsWithAttendanceCounts();

            lbxSessionsWithAttendanceCount.DataSource = sessionInfoList;
        }

        private void tbcSessionTracker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            List<string> sessionInfoList = dataAccess.ListSessionsWithAttendanceCounts();

            lbxSessionsWithAttendanceCount.DataSource = sessionInfoList;
        }

        private void lblPrintAttendanceList_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += prntSessionsAttendance_PrintPage;

            // Set the PrintPreviewDialog's Document property and show the dialog
            prndPreviewPrint.Document = printDocument;
            DialogResult result = prndPreviewPrint.ShowDialog();

            // If the user clicks the Print button in the PrintPreviewDialog, then print the document
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void prntSessionsAttendance_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(graphics);
            float leftBounds = e.MarginBounds.Left;
            float rightBounds = e.MarginBounds.Top;

            for (int count = 0; count < lbxSessionsWithAttendanceCount.Items.Count; count++)
            {
                string line = lbxSessionsWithAttendanceCount.Items[count].ToString();
                graphics.DrawString(line, font, Brushes.Black, leftBounds, rightBounds);
                rightBounds += lineHeight;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrInactivity_Tick(object sender, EventArgs e)
        {
            UserInactive?.Invoke(this, EventArgs.Empty);
        }

        private void lblSessionsAttenance_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTimeSlot_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int timeSlotId = db.retrieveTimeId(cmbTimeFormFullTimeSlots.Text);

            db.deleteTimeSlot(timeSlotId);

            UpdateComboBoxes();
        }
    }
}

