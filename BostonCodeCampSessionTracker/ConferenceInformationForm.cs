using BostonCodeCampSessionTracker;
using BostonCodeCampSessionTracker.Data;
using BostonCodeCampSessionTracker.Models;

namespace SemesterProjectTest
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

            db.addSpeaker(txtBoxFirstName.Text, lblLastName.Text, lblEmail.Text, lblDayOfContact.Text);
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            //DataAccess db = new DataAccess();

            //db.addRoom(Convert.ToInt32(lblMaxCapacity.Text), lblRoomName.Text);
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
    }
}