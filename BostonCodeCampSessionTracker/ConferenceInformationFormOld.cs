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

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //db.addSession(txtBoxSessionName)
        }

        /*private void btnNewSession_Click(object sender, EventArgs e)
        {
            txtBoxSessionName.Text = "";
            cmbBoxSpeakerName.Text = "";
            cmbSessionStartTime.Text = "";
            cmbSessionEndTime.Text = "";
            cmbBoxRoomName.Text = "";
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            txtBoxRoomID.Text = "";
            txtBoxMaxCapacity.Text = "";
        }

        private void btnNewTimeSlot_Click(object sender, EventArgs e)
        {
            tmprStartTime.Text = "12:00 AM";
            tmprEndTime.Text = "12:00 AM";
            dprSessionDate.Text = "";
        }*/

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

        private void updateRoomComboBoxes()
        {
            DataAccess db = new DataAccess();

            List<String> rooms = db.retrieveRoomNames();
            cmbBoxRoomName.Items.Clear();

            foreach (String room in rooms)
            {
                cmbBoxSpeakerName.Items.Add(room);
            }

        }

        private void updateTimeSlotComboBoxes()
        {
        }

        private void updateComboBoxes()
        {

        }

        private void btnCreateSpeaker_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addSpeaker(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, txtBoxPhoneNumber.Text, txtBoxDayOfContact.Text, txtBoxShortBio.Text, txtBoxPastTalksGiven.Text);

            updateSpeakerComboBoxes();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addRoom(Convert.ToInt32(txtBoxMaxCapacity.Text), txtBoxRoomID.Text);

            updateRoomComboBoxes();
        }

        private void btnCreateTimeSlot_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addTimeSlot(TimeSpan.Parse(tmpStartTime.Text), TimeSpan.Parse(tmpEndTime.Text), TimeSpan.Parse(dpSessionDate.Text));
        }

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.addSession(txtBoxSessionName.Text, txtBoxRoomID.Text, cmbBoxSpeakerName.Text, cmbTimeSlots.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearSpeakerFields_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEmail.Text = "";
            txtBoxShortBio.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxDayOfContact.Text = "";
            txtBoxPastTalksGiven.Text = "";
        }

        private void btnANewSession_Click(object sender, EventArgs e)
        {

        }
    }
}
