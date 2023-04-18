using BostonCodeCampSessionTracker;
using BostonCodeCampSessionTracker.Data;
using BostonCodeCampSessionTracker.Models;
using Microsoft.Identity.Client;

namespace BostonCodeCampSessionTracker
{
    public partial class ConferenceInformationForm : Form
    {
        public ConferenceInformationForm()
        {
            InitializeComponent();
        }

        private void btnSaveSpeaker_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addSpeaker(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, txtBoxPhoneNumber.Text, txtBoxDayOfContact.Text);

            updateSpeakerComboBoxes();
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addRoom(Convert.ToInt32(txtBoxMaxCapacity.Text), txtBoxRoomID.Text);
        }

        private void btnSaveTimeSlot_Click(object sender, EventArgs e)
        {
            //DataAccess db = new DataAccess();

            //db.addTimeSlot(TimeSpan.Parse(lblStartTime.Text), TimeSpan.Parse(lblEndTime.Text), decimal.Parse(lblDurationSession.Text));
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {

        }

        private void btnNewSession_Click(object sender, EventArgs e)
        {
            txtBoxSessionName.Text = "";
            cmbBoxSpeakerName.Text = "";
            cmbSessionStartTime.Text = "";
            cmbSessionEndTime.Text = "";
            cmbBoxRoomName.Text = "";
        }
        private void testSpeaker()
        {
            Test t = new Test();
            txtBoxFirstName.Text = t.testForStudentFName();
            txtBoxLastName.Text = t.testForStudentLName() ;
            txtBoxEmail.Text = t.testForStudentEmail();
            txtBoxShortBio.Text = t.testForStudentBio();
            txtBoxPhoneNumber.Text = t.testForStudentPhoneNumber() ;
            txtBoxDayOfContact.Text = t.testForStudentDayOfContact() ;
            txtBoxPastTalksGiven.Text = t.testForStudentPastTalksGiven();
        }
        public void testRooms()
        {
            Test tr = new Test();
            txtBoxRoomID.Text = tr.testForRoomID();
            txtBoxMaxCapacity.Text = tr.testForRoomCapacity();
        }
        public void testTime()
        {
            Test tr = new Test();
            timePickerStartTime.Text = tr.testForTimeSlotsStart();
            timePickerEndTime.Text = tr.testForTimeSlotsEnd();
            datePickerSessionDate.Text = tr.testForDate();

        }
        public void testSessions()
        {
            Test tr = new Test();
            cmbSessionStartTime.Text = tr.testForSessionStartTime();
            cmbSessionEndTime.Text = tr.testForSessionEndTime();    
            txtBoxSessionName.Text = tr.testForSessionName();
            cmbBoxSpeakerName.Text = tr.testForSpeakerFullName();
            txtBoxDurationOfSession.Text = tr.testForDurationOfSession();

        }
        public void testOverview()
        {
            Test tr = new Test();
            txtBoxStartTimeOverview.Text = tr.testForSessionStartTime();
            txtBoxEndtimeOverview.Text = tr.testForSessionEndTime();
            txtBoxDurationOverview.Text = tr.testForDurationOfSession();
            txtBoxRoomOverview.Text = tr.testForRoomName();

        }
        public void testAttendance()
        {
            Test tr = new Test();
            txtCountBefore.Text = tr.testForStartCount();
            txtMiddleCount.Text = tr.testForMiddleCount();
            txtEndCount.Text = tr.testForEndCount();
        }
        
            
        

        private void btnNewSpeaker_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEmail.Text = "";
            txtBoxShortBio.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxDayOfContact.Text = "";
            txtBoxPastTalksGiven.Text = "";
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            txtBoxRoomID.Text = "";
            txtBoxMaxCapacity.Text = "";
        }

        private void btnNewTimeSlot_Click(object sender, EventArgs e)
        {
            timePickerStartTime.Text = "12:00 AM";
            timePickerEndTime.Text = "12:00 AM";
            datePickerSessionDate.Text = "";
        }

        private void ConferenceInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void updateSpeakerComboBoxes()
        {
            DataAccess db = new DataAccess();

            List<String> speakerNames = db.retrieveSpeakerNames();
            cmbBoxSpeakerName.Items.Clear();

            foreach (String speakerName in speakerNames)
            {
                cmbBoxSpeakerName.Items.Add(speakerName);
            }
        }

        private void updateComboBoxes()
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            testSpeaker();
        }

        private void btnRoomTest_Click(object sender, EventArgs e)
        {
            testRooms();    
        }

        private void tabSessionInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnTimeTest_Click(object sender, EventArgs e)
        {
            testTime();

        }

        private void cmbSessionStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSessionTest_Click(object sender, EventArgs e)
        {
            testSessions();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar= '*';
        }

        private void tabPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnOverviewTest_Click(object sender, EventArgs e)
        {
            testOverview();
        }

        private void btnAttendTest_Click(object sender, EventArgs e)
        {
            testAttendance();
        }
    }
}