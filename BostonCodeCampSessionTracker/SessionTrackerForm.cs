using BostonCodeCampSessionTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            db.addSpeaker(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, txtBoxPhoneNumber.Text, txtBoxDayOfContact.Text, txtBoxShortBio.Text, txtBoxPastTalksGiven.Text);

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

            db.addTimeSlot(TimeSpan.Parse(tmpStartTime.Text), TimeSpan.Parse(tmpEndTime.Text), TimeSpan.Parse(dpSessionDate.Text));
        }

        private void updateTimeSlotComboBoxes()
        {
            DataAccess db = new DataAccess();

            List<String> times = db.retrieveAFullTimeSlot();
            cmbTimeSlots.Items.Clear();

            foreach (String time in times)
            {
                cmbTimeSlots.Items.Add(time);
            }
        }

        private void btnRemoveTimeSlot_Click(object sender, EventArgs e)
        {

        }

        private void btnTimeSlotExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
