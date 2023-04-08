using BostonCodeCampSessionTracker;
using BostonCodeCampSessionTracker.Data;
using BostonCodeCampSessionTracker.Models;

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
    }
}