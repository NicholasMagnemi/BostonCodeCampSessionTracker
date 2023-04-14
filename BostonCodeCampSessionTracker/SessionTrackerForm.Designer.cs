namespace BostonCodeCampSessionTracker
{
    partial class SessionTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcSessionTracker = new TabControl();
            tbSpeakerInfo = new TabPage();
            lblShortBioOptionalNotice = new Label();
            lblPastTalksOptionalNotice = new Label();
            lblSpeakerRequiredFieldsNotice = new Label();
            btnSpeakerExitApplication = new Button();
            btnRemoveSpeaker = new Button();
            btnCreateSpeaker = new Button();
            btnClearSpeakerFields = new Button();
            txtBoxShortBio = new TextBox();
            lblShortBio = new Label();
            txtBoxPastTalksGiven = new TextBox();
            lblPastTalksGiven = new Label();
            lblEmail = new Label();
            txtBoxEmail = new TextBox();
            lblDayOfContact = new Label();
            txtBoxDayOfContactPhoneNumber = new TextBox();
            txtBoxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxFirstName = new TextBox();
            lblFirstName = new Label();
            lblSpeakersForm = new Label();
            tbRoomInfo = new TabPage();
            lblRoomRequiredFieldNotice = new Label();
            btnClearRoomFields = new Button();
            btnRoomExitApplication = new Button();
            txtBoxMaxCapacity = new TextBox();
            label9 = new Label();
            txtBoxRoomID = new TextBox();
            label10 = new Label();
            btnRemoveRoom = new Button();
            btnCreateRoom = new Button();
            label11 = new Label();
            tbTimeSlotInfo = new TabPage();
            btnTimeSlotExitApplication = new Button();
            btnRemoveTimeSlot = new Button();
            btnCreateTimeSlot = new Button();
            btnClearTimeSlotFields = new Button();
            lblSessionDate = new Label();
            dpSessionDate = new DateTimePicker();
            tmpEndTime = new DateTimePicker();
            lblEndTime = new Label();
            tmpStartTime = new DateTimePicker();
            lblStartTime = new Label();
            label15 = new Label();
            tbSessionInfo = new TabPage();
            btnClearSessionFields = new Button();
            cmbTimeSlots = new ComboBox();
            txtBoxSessionName = new TextBox();
            btnSessionExitApplication = new Button();
            btnRemoveSession = new Button();
            btnCreateSession = new Button();
            cmbTimeSlot = new Label();
            textBox11 = new TextBox();
            lblSessionDuration = new Label();
            cmbRoomName = new Label();
            cmbSessionRoomName = new ComboBox();
            cmbSpeakerName = new ComboBox();
            lblSpeakerName = new Label();
            lblSessionName = new Label();
            lblSessionForm = new Label();
            tbOverview = new TabPage();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            textBox12 = new TextBox();
            label22 = new Label();
            textBox13 = new TextBox();
            label23 = new Label();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label24 = new Label();
            comboBox5 = new ComboBox();
            label25 = new Label();
            comboBox6 = new ComboBox();
            label26 = new Label();
            label27 = new Label();
            tbcSessionTracker.SuspendLayout();
            tbSpeakerInfo.SuspendLayout();
            tbRoomInfo.SuspendLayout();
            tbTimeSlotInfo.SuspendLayout();
            tbSessionInfo.SuspendLayout();
            tbOverview.SuspendLayout();
            SuspendLayout();
            // 
            // tbcSessionTracker
            // 
            tbcSessionTracker.Controls.Add(tbSpeakerInfo);
            tbcSessionTracker.Controls.Add(tbRoomInfo);
            tbcSessionTracker.Controls.Add(tbTimeSlotInfo);
            tbcSessionTracker.Controls.Add(tbSessionInfo);
            tbcSessionTracker.Controls.Add(tbOverview);
            tbcSessionTracker.Location = new Point(1, 0);
            tbcSessionTracker.Margin = new Padding(3, 2, 3, 2);
            tbcSessionTracker.Name = "tbcSessionTracker";
            tbcSessionTracker.SelectedIndex = 0;
            tbcSessionTracker.Size = new Size(515, 398);
            tbcSessionTracker.TabIndex = 2;
            // 
            // tbSpeakerInfo
            // 
            tbSpeakerInfo.Controls.Add(lblShortBioOptionalNotice);
            tbSpeakerInfo.Controls.Add(lblPastTalksOptionalNotice);
            tbSpeakerInfo.Controls.Add(lblSpeakerRequiredFieldsNotice);
            tbSpeakerInfo.Controls.Add(btnSpeakerExitApplication);
            tbSpeakerInfo.Controls.Add(btnRemoveSpeaker);
            tbSpeakerInfo.Controls.Add(btnCreateSpeaker);
            tbSpeakerInfo.Controls.Add(btnClearSpeakerFields);
            tbSpeakerInfo.Controls.Add(txtBoxShortBio);
            tbSpeakerInfo.Controls.Add(lblShortBio);
            tbSpeakerInfo.Controls.Add(txtBoxPastTalksGiven);
            tbSpeakerInfo.Controls.Add(lblPastTalksGiven);
            tbSpeakerInfo.Controls.Add(lblEmail);
            tbSpeakerInfo.Controls.Add(txtBoxEmail);
            tbSpeakerInfo.Controls.Add(lblDayOfContact);
            tbSpeakerInfo.Controls.Add(txtBoxDayOfContactPhoneNumber);
            tbSpeakerInfo.Controls.Add(txtBoxPhoneNumber);
            tbSpeakerInfo.Controls.Add(lblPhoneNumber);
            tbSpeakerInfo.Controls.Add(txtBoxLastName);
            tbSpeakerInfo.Controls.Add(lblLastName);
            tbSpeakerInfo.Controls.Add(txtBoxFirstName);
            tbSpeakerInfo.Controls.Add(lblFirstName);
            tbSpeakerInfo.Controls.Add(lblSpeakersForm);
            tbSpeakerInfo.Location = new Point(4, 24);
            tbSpeakerInfo.Margin = new Padding(3, 2, 3, 2);
            tbSpeakerInfo.Name = "tbSpeakerInfo";
            tbSpeakerInfo.Padding = new Padding(3, 2, 3, 2);
            tbSpeakerInfo.Size = new Size(507, 370);
            tbSpeakerInfo.TabIndex = 0;
            tbSpeakerInfo.Text = "Speaker Info";
            tbSpeakerInfo.UseVisualStyleBackColor = true;
            // 
            // lblShortBioOptionalNotice
            // 
            lblShortBioOptionalNotice.AutoSize = true;
            lblShortBioOptionalNotice.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortBioOptionalNotice.Location = new Point(133, 241);
            lblShortBioOptionalNotice.Name = "lblShortBioOptionalNotice";
            lblShortBioOptionalNotice.Size = new Size(59, 13);
            lblShortBioOptionalNotice.TabIndex = 41;
            lblShortBioOptionalNotice.Text = "(Optional)";
            // 
            // lblPastTalksOptionalNotice
            // 
            lblPastTalksOptionalNotice.AutoSize = true;
            lblPastTalksOptionalNotice.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPastTalksOptionalNotice.Location = new Point(442, 155);
            lblPastTalksOptionalNotice.Name = "lblPastTalksOptionalNotice";
            lblPastTalksOptionalNotice.Size = new Size(59, 13);
            lblPastTalksOptionalNotice.TabIndex = 40;
            lblPastTalksOptionalNotice.Text = "(Optional)";
            // 
            // lblSpeakerRequiredFieldsNotice
            // 
            lblSpeakerRequiredFieldsNotice.AutoSize = true;
            lblSpeakerRequiredFieldsNotice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeakerRequiredFieldsNotice.Location = new Point(9, 46);
            lblSpeakerRequiredFieldsNotice.Name = "lblSpeakerRequiredFieldsNotice";
            lblSpeakerRequiredFieldsNotice.Size = new Size(300, 19);
            lblSpeakerRequiredFieldsNotice.TabIndex = 39;
            lblSpeakerRequiredFieldsNotice.Text = "(All fields are required unless stated as optional)";
            // 
            // btnSpeakerExitApplication
            // 
            btnSpeakerExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpeakerExitApplication.Location = new Point(6, 335);
            btnSpeakerExitApplication.Margin = new Padding(3, 2, 3, 2);
            btnSpeakerExitApplication.Name = "btnSpeakerExitApplication";
            btnSpeakerExitApplication.Size = new Size(186, 30);
            btnSpeakerExitApplication.TabIndex = 38;
            btnSpeakerExitApplication.Text = "Exit Application";
            btnSpeakerExitApplication.UseVisualStyleBackColor = true;
            btnSpeakerExitApplication.Click += btnSpeakerExitApplication_Click;
            // 
            // btnRemoveSpeaker
            // 
            btnRemoveSpeaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveSpeaker.Location = new Point(316, 335);
            btnRemoveSpeaker.Margin = new Padding(3, 2, 3, 2);
            btnRemoveSpeaker.Name = "btnRemoveSpeaker";
            btnRemoveSpeaker.Size = new Size(186, 30);
            btnRemoveSpeaker.TabIndex = 17;
            btnRemoveSpeaker.Text = "Remove Speaker";
            btnRemoveSpeaker.UseVisualStyleBackColor = true;
            btnRemoveSpeaker.Click += btnRemoveSpeaker_Click;
            // 
            // btnCreateSpeaker
            // 
            btnCreateSpeaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSpeaker.Location = new Point(316, 302);
            btnCreateSpeaker.Margin = new Padding(3, 2, 3, 2);
            btnCreateSpeaker.Name = "btnCreateSpeaker";
            btnCreateSpeaker.Size = new Size(186, 30);
            btnCreateSpeaker.TabIndex = 16;
            btnCreateSpeaker.Text = "Create Speaker";
            btnCreateSpeaker.UseVisualStyleBackColor = true;
            btnCreateSpeaker.Click += btnCreateSpeaker_Click;
            // 
            // btnClearSpeakerFields
            // 
            btnClearSpeakerFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearSpeakerFields.Location = new Point(316, 269);
            btnClearSpeakerFields.Margin = new Padding(3, 2, 3, 2);
            btnClearSpeakerFields.Name = "btnClearSpeakerFields";
            btnClearSpeakerFields.Size = new Size(186, 30);
            btnClearSpeakerFields.TabIndex = 15;
            btnClearSpeakerFields.Text = "Clear Fields";
            btnClearSpeakerFields.UseVisualStyleBackColor = true;
            btnClearSpeakerFields.Click += btnClearSpeakerFields_Click;
            // 
            // txtBoxShortBio
            // 
            txtBoxShortBio.Location = new Point(6, 256);
            txtBoxShortBio.Margin = new Padding(3, 2, 3, 2);
            txtBoxShortBio.Multiline = true;
            txtBoxShortBio.Name = "txtBoxShortBio";
            txtBoxShortBio.Size = new Size(186, 75);
            txtBoxShortBio.TabIndex = 14;
            // 
            // lblShortBio
            // 
            lblShortBio.AutoSize = true;
            lblShortBio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortBio.Location = new Point(12, 237);
            lblShortBio.Name = "lblShortBio";
            lblShortBio.Size = new Size(77, 21);
            lblShortBio.TabIndex = 13;
            lblShortBio.Text = "Short Bio:";
            // 
            // txtBoxPastTalksGiven
            // 
            txtBoxPastTalksGiven.Location = new Point(316, 168);
            txtBoxPastTalksGiven.Margin = new Padding(3, 2, 3, 2);
            txtBoxPastTalksGiven.Multiline = true;
            txtBoxPastTalksGiven.Name = "txtBoxPastTalksGiven";
            txtBoxPastTalksGiven.Size = new Size(186, 75);
            txtBoxPastTalksGiven.TabIndex = 12;
            // 
            // lblPastTalksGiven
            // 
            lblPastTalksGiven.AutoSize = true;
            lblPastTalksGiven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPastTalksGiven.Location = new Point(322, 149);
            lblPastTalksGiven.Name = "lblPastTalksGiven";
            lblPastTalksGiven.Size = new Size(122, 21);
            lblPastTalksGiven.TabIndex = 11;
            lblPastTalksGiven.Text = "Past Talks Given:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 183);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(6, 202);
            txtBoxEmail.Margin = new Padding(3, 2, 3, 2);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(186, 23);
            txtBoxEmail.TabIndex = 9;
            // 
            // lblDayOfContact
            // 
            lblDayOfContact.AutoSize = true;
            lblDayOfContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDayOfContact.Location = new Point(322, 98);
            lblDayOfContact.Name = "lblDayOfContact";
            lblDayOfContact.Size = new Size(180, 21);
            lblDayOfContact.TabIndex = 8;
            lblDayOfContact.Text = "Day Of Contact Number:";
            // 
            // txtBoxDayOfContactPhoneNumber
            // 
            txtBoxDayOfContactPhoneNumber.Location = new Point(316, 117);
            txtBoxDayOfContactPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtBoxDayOfContactPhoneNumber.Name = "txtBoxDayOfContactPhoneNumber";
            txtBoxDayOfContactPhoneNumber.Size = new Size(186, 23);
            txtBoxDayOfContactPhoneNumber.TabIndex = 7;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(316, 62);
            txtBoxPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(186, 23);
            txtBoxPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(322, 43);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(119, 21);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(6, 151);
            txtBoxLastName.Margin = new Padding(3, 2, 3, 2);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(186, 23);
            txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(12, 132);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(83, 21);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "LastName:";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(6, 96);
            txtBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(186, 23);
            txtBoxFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(12, 77);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(85, 21);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "FirstName:";
            // 
            // lblSpeakersForm
            // 
            lblSpeakersForm.AutoSize = true;
            lblSpeakersForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeakersForm.Location = new Point(179, 4);
            lblSpeakersForm.Name = "lblSpeakersForm";
            lblSpeakersForm.Size = new Size(161, 32);
            lblSpeakersForm.TabIndex = 0;
            lblSpeakersForm.Text = "Speaker Form";
            // 
            // tbRoomInfo
            // 
            tbRoomInfo.Controls.Add(lblRoomRequiredFieldNotice);
            tbRoomInfo.Controls.Add(btnClearRoomFields);
            tbRoomInfo.Controls.Add(btnRoomExitApplication);
            tbRoomInfo.Controls.Add(txtBoxMaxCapacity);
            tbRoomInfo.Controls.Add(label9);
            tbRoomInfo.Controls.Add(txtBoxRoomID);
            tbRoomInfo.Controls.Add(label10);
            tbRoomInfo.Controls.Add(btnRemoveRoom);
            tbRoomInfo.Controls.Add(btnCreateRoom);
            tbRoomInfo.Controls.Add(label11);
            tbRoomInfo.Location = new Point(4, 24);
            tbRoomInfo.Margin = new Padding(3, 2, 3, 2);
            tbRoomInfo.Name = "tbRoomInfo";
            tbRoomInfo.Padding = new Padding(3, 2, 3, 2);
            tbRoomInfo.Size = new Size(507, 370);
            tbRoomInfo.TabIndex = 1;
            tbRoomInfo.Text = "Room Info";
            tbRoomInfo.UseVisualStyleBackColor = true;
            // 
            // lblRoomRequiredFieldNotice
            // 
            lblRoomRequiredFieldNotice.AutoSize = true;
            lblRoomRequiredFieldNotice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRoomRequiredFieldNotice.Location = new Point(9, 36);
            lblRoomRequiredFieldNotice.Name = "lblRoomRequiredFieldNotice";
            lblRoomRequiredFieldNotice.Size = new Size(300, 19);
            lblRoomRequiredFieldNotice.TabIndex = 40;
            lblRoomRequiredFieldNotice.Text = "(All fields are required unless stated as optional)";
            // 
            // btnClearRoomFields
            // 
            btnClearRoomFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearRoomFields.Location = new Point(318, 274);
            btnClearRoomFields.Name = "btnClearRoomFields";
            btnClearRoomFields.Size = new Size(186, 30);
            btnClearRoomFields.TabIndex = 39;
            btnClearRoomFields.Text = "Clear Fields";
            btnClearRoomFields.UseVisualStyleBackColor = true;
            btnClearRoomFields.Click += btnClearRoomFields_Click;
            // 
            // btnRoomExitApplication
            // 
            btnRoomExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoomExitApplication.Location = new Point(9, 333);
            btnRoomExitApplication.Margin = new Padding(3, 2, 3, 2);
            btnRoomExitApplication.Name = "btnRoomExitApplication";
            btnRoomExitApplication.Size = new Size(186, 30);
            btnRoomExitApplication.TabIndex = 38;
            btnRoomExitApplication.Text = "Exit Application";
            btnRoomExitApplication.UseVisualStyleBackColor = true;
            btnRoomExitApplication.Click += btnRoomExitApplication_Click;
            // 
            // txtBoxMaxCapacity
            // 
            txtBoxMaxCapacity.Location = new Point(9, 122);
            txtBoxMaxCapacity.Margin = new Padding(3, 2, 3, 2);
            txtBoxMaxCapacity.Name = "txtBoxMaxCapacity";
            txtBoxMaxCapacity.Size = new Size(186, 23);
            txtBoxMaxCapacity.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 103);
            label9.Name = "label9";
            label9.Size = new Size(102, 21);
            label9.TabIndex = 23;
            label9.Text = "Max Capacity";
            // 
            // txtBoxRoomID
            // 
            txtBoxRoomID.Location = new Point(9, 74);
            txtBoxRoomID.Margin = new Padding(3, 2, 3, 2);
            txtBoxRoomID.Name = "txtBoxRoomID";
            txtBoxRoomID.Size = new Size(186, 23);
            txtBoxRoomID.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 55);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 21;
            label10.Text = "Room ID:";
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveRoom.Location = new Point(318, 337);
            btnRemoveRoom.Margin = new Padding(3, 2, 3, 2);
            btnRemoveRoom.Name = "btnRemoveRoom";
            btnRemoveRoom.Size = new Size(186, 30);
            btnRemoveRoom.TabIndex = 20;
            btnRemoveRoom.Text = "Remove Room";
            btnRemoveRoom.UseVisualStyleBackColor = true;
            btnRemoveRoom.Click += btnRemoveRoom_Click;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateRoom.Location = new Point(318, 305);
            btnCreateRoom.Margin = new Padding(3, 2, 3, 2);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(186, 30);
            btnCreateRoom.TabIndex = 19;
            btnCreateRoom.Text = "Create Room";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(198, 6);
            label11.Name = "label11";
            label11.Size = new Size(138, 32);
            label11.TabIndex = 1;
            label11.Text = "Room Form";
            // 
            // tbTimeSlotInfo
            // 
            tbTimeSlotInfo.Controls.Add(btnTimeSlotExitApplication);
            tbTimeSlotInfo.Controls.Add(btnRemoveTimeSlot);
            tbTimeSlotInfo.Controls.Add(btnCreateTimeSlot);
            tbTimeSlotInfo.Controls.Add(btnClearTimeSlotFields);
            tbTimeSlotInfo.Controls.Add(lblSessionDate);
            tbTimeSlotInfo.Controls.Add(dpSessionDate);
            tbTimeSlotInfo.Controls.Add(tmpEndTime);
            tbTimeSlotInfo.Controls.Add(lblEndTime);
            tbTimeSlotInfo.Controls.Add(tmpStartTime);
            tbTimeSlotInfo.Controls.Add(lblStartTime);
            tbTimeSlotInfo.Controls.Add(label15);
            tbTimeSlotInfo.Location = new Point(4, 24);
            tbTimeSlotInfo.Margin = new Padding(3, 2, 3, 2);
            tbTimeSlotInfo.Name = "tbTimeSlotInfo";
            tbTimeSlotInfo.Size = new Size(507, 370);
            tbTimeSlotInfo.TabIndex = 2;
            tbTimeSlotInfo.Text = "Time Slot Info";
            tbTimeSlotInfo.UseVisualStyleBackColor = true;
            // 
            // btnTimeSlotExitApplication
            // 
            btnTimeSlotExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimeSlotExitApplication.Location = new Point(9, 336);
            btnTimeSlotExitApplication.Margin = new Padding(3, 2, 3, 2);
            btnTimeSlotExitApplication.Name = "btnTimeSlotExitApplication";
            btnTimeSlotExitApplication.Size = new Size(130, 26);
            btnTimeSlotExitApplication.TabIndex = 38;
            btnTimeSlotExitApplication.Text = "Exit Application";
            btnTimeSlotExitApplication.UseVisualStyleBackColor = true;
            btnTimeSlotExitApplication.Click += btnTimeSlotExitApplication_Click;
            // 
            // btnRemoveTimeSlot
            // 
            btnRemoveTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveTimeSlot.Location = new Point(335, 336);
            btnRemoveTimeSlot.Margin = new Padding(3, 2, 3, 2);
            btnRemoveTimeSlot.Name = "btnRemoveTimeSlot";
            btnRemoveTimeSlot.Size = new Size(163, 26);
            btnRemoveTimeSlot.TabIndex = 32;
            btnRemoveTimeSlot.Text = "Remove Time Slot";
            btnRemoveTimeSlot.UseVisualStyleBackColor = true;
            btnRemoveTimeSlot.Click += btnRemoveTimeSlot_Click;
            // 
            // btnCreateTimeSlot
            // 
            btnCreateTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTimeSlot.Location = new Point(335, 306);
            btnCreateTimeSlot.Margin = new Padding(3, 2, 3, 2);
            btnCreateTimeSlot.Name = "btnCreateTimeSlot";
            btnCreateTimeSlot.Size = new Size(163, 26);
            btnCreateTimeSlot.TabIndex = 31;
            btnCreateTimeSlot.Text = "Create Time Slot";
            btnCreateTimeSlot.UseVisualStyleBackColor = true;
            btnCreateTimeSlot.Click += btnCreateTimeSlot_Click;
            // 
            // btnClearTimeSlotFields
            // 
            btnClearTimeSlotFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearTimeSlotFields.Location = new Point(335, 276);
            btnClearTimeSlotFields.Margin = new Padding(3, 2, 3, 2);
            btnClearTimeSlotFields.Name = "btnClearTimeSlotFields";
            btnClearTimeSlotFields.Size = new Size(163, 26);
            btnClearTimeSlotFields.TabIndex = 30;
            btnClearTimeSlotFields.Text = "New Time Slot";
            btnClearTimeSlotFields.UseVisualStyleBackColor = true;
            btnClearTimeSlotFields.Click += btnClearTimeSlotFields_Click;
            // 
            // lblSessionDate
            // 
            lblSessionDate.AutoSize = true;
            lblSessionDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionDate.Location = new Point(3, 200);
            lblSessionDate.Name = "lblSessionDate";
            lblSessionDate.Size = new Size(102, 21);
            lblSessionDate.TabIndex = 29;
            lblSessionDate.Text = "Session Date:";
            // 
            // dpSessionDate
            // 
            dpSessionDate.CustomFormat = "dd/mm/yyyy";
            dpSessionDate.Format = DateTimePickerFormat.Custom;
            dpSessionDate.Location = new Point(3, 224);
            dpSessionDate.Margin = new Padding(3, 2, 3, 2);
            dpSessionDate.Name = "dpSessionDate";
            dpSessionDate.Size = new Size(219, 23);
            dpSessionDate.TabIndex = 28;
            // 
            // tmpEndTime
            // 
            tmpEndTime.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tmpEndTime.CustomFormat = "hh:mm tt";
            tmpEndTime.Format = DateTimePickerFormat.Custom;
            tmpEndTime.Location = new Point(3, 162);
            tmpEndTime.Margin = new Padding(3, 2, 3, 2);
            tmpEndTime.Name = "tmpEndTime";
            tmpEndTime.ShowUpDown = true;
            tmpEndTime.Size = new Size(92, 23);
            tmpEndTime.TabIndex = 25;
            tmpEndTime.Value = new DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndTime.Location = new Point(3, 139);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(77, 21);
            lblEndTime.TabIndex = 24;
            lblEndTime.Text = "End Time:";
            // 
            // tmpStartTime
            // 
            tmpStartTime.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tmpStartTime.CustomFormat = "hh:mm tt";
            tmpStartTime.Format = DateTimePickerFormat.Custom;
            tmpStartTime.Location = new Point(3, 95);
            tmpStartTime.Margin = new Padding(3, 2, 3, 2);
            tmpStartTime.Name = "tmpStartTime";
            tmpStartTime.ShowUpDown = true;
            tmpStartTime.Size = new Size(92, 23);
            tmpStartTime.TabIndex = 23;
            tmpStartTime.Value = new DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartTime.Location = new Point(3, 72);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(83, 21);
            lblStartTime.TabIndex = 22;
            lblStartTime.Text = "Start Time:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(175, 0);
            label15.Name = "label15";
            label15.Size = new Size(177, 32);
            label15.TabIndex = 2;
            label15.Text = "Time Slot Form";
            // 
            // tbSessionInfo
            // 
            tbSessionInfo.Controls.Add(btnClearSessionFields);
            tbSessionInfo.Controls.Add(cmbTimeSlots);
            tbSessionInfo.Controls.Add(txtBoxSessionName);
            tbSessionInfo.Controls.Add(btnSessionExitApplication);
            tbSessionInfo.Controls.Add(btnRemoveSession);
            tbSessionInfo.Controls.Add(btnCreateSession);
            tbSessionInfo.Controls.Add(cmbTimeSlot);
            tbSessionInfo.Controls.Add(textBox11);
            tbSessionInfo.Controls.Add(lblSessionDuration);
            tbSessionInfo.Controls.Add(cmbRoomName);
            tbSessionInfo.Controls.Add(cmbSessionRoomName);
            tbSessionInfo.Controls.Add(cmbSpeakerName);
            tbSessionInfo.Controls.Add(lblSpeakerName);
            tbSessionInfo.Controls.Add(lblSessionName);
            tbSessionInfo.Controls.Add(lblSessionForm);
            tbSessionInfo.Location = new Point(4, 24);
            tbSessionInfo.Margin = new Padding(3, 2, 3, 2);
            tbSessionInfo.Name = "tbSessionInfo";
            tbSessionInfo.Size = new Size(507, 370);
            tbSessionInfo.TabIndex = 3;
            tbSessionInfo.Text = "Session Info";
            tbSessionInfo.UseVisualStyleBackColor = true;
            // 
            // btnClearSessionFields
            // 
            btnClearSessionFields.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearSessionFields.Location = new Point(357, 274);
            btnClearSessionFields.Margin = new Padding(3, 2, 3, 2);
            btnClearSessionFields.Name = "btnClearSessionFields";
            btnClearSessionFields.Size = new Size(141, 26);
            btnClearSessionFields.TabIndex = 41;
            btnClearSessionFields.Text = "Clear Fields";
            btnClearSessionFields.UseVisualStyleBackColor = true;
            // 
            // cmbTimeSlots
            // 
            cmbTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimeSlots.FormattingEnabled = true;
            cmbTimeSlots.Location = new Point(9, 208);
            cmbTimeSlots.Name = "cmbTimeSlots";
            cmbTimeSlots.Size = new Size(186, 23);
            cmbTimeSlots.TabIndex = 39;
            // 
            // txtBoxSessionName
            // 
            txtBoxSessionName.Location = new Point(9, 90);
            txtBoxSessionName.Name = "txtBoxSessionName";
            txtBoxSessionName.Size = new Size(186, 23);
            txtBoxSessionName.TabIndex = 38;
            // 
            // btnSessionExitApplication
            // 
            btnSessionExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSessionExitApplication.Location = new Point(9, 333);
            btnSessionExitApplication.Margin = new Padding(3, 2, 3, 2);
            btnSessionExitApplication.Name = "btnSessionExitApplication";
            btnSessionExitApplication.Size = new Size(130, 26);
            btnSessionExitApplication.TabIndex = 37;
            btnSessionExitApplication.Text = "Exit Application";
            btnSessionExitApplication.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSession
            // 
            btnRemoveSession.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveSession.Location = new Point(357, 333);
            btnRemoveSession.Margin = new Padding(3, 2, 3, 2);
            btnRemoveSession.Name = "btnRemoveSession";
            btnRemoveSession.Size = new Size(141, 26);
            btnRemoveSession.TabIndex = 36;
            btnRemoveSession.Text = "Remove Session";
            btnRemoveSession.UseVisualStyleBackColor = true;
            // 
            // btnCreateSession
            // 
            btnCreateSession.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSession.Location = new Point(357, 303);
            btnCreateSession.Margin = new Padding(3, 2, 3, 2);
            btnCreateSession.Name = "btnCreateSession";
            btnCreateSession.Size = new Size(141, 26);
            btnCreateSession.TabIndex = 35;
            btnCreateSession.Text = "Create Session";
            btnCreateSession.UseVisualStyleBackColor = true;
            // 
            // cmbTimeSlot
            // 
            cmbTimeSlot.AutoSize = true;
            cmbTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTimeSlot.Location = new Point(9, 184);
            cmbTimeSlot.Name = "cmbTimeSlot";
            cmbTimeSlot.Size = new Size(78, 21);
            cmbTimeSlot.TabIndex = 31;
            cmbTimeSlot.Text = "Time Slot:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(316, 152);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(186, 23);
            textBox11.TabIndex = 30;
            // 
            // lblSessionDuration
            // 
            lblSessionDuration.AutoSize = true;
            lblSessionDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionDuration.Location = new Point(316, 129);
            lblSessionDuration.Name = "lblSessionDuration";
            lblSessionDuration.Size = new Size(149, 21);
            lblSessionDuration.TabIndex = 29;
            lblSessionDuration.Text = "Duration of Session:";
            // 
            // cmbRoomName
            // 
            cmbRoomName.AutoSize = true;
            cmbRoomName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoomName.Location = new Point(316, 66);
            cmbRoomName.Name = "cmbRoomName";
            cmbRoomName.Size = new Size(101, 21);
            cmbRoomName.TabIndex = 28;
            cmbRoomName.Text = "Room Name:";
            // 
            // cmbSessionRoomName
            // 
            cmbSessionRoomName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSessionRoomName.FormattingEnabled = true;
            cmbSessionRoomName.Location = new Point(316, 90);
            cmbSessionRoomName.Margin = new Padding(3, 2, 3, 2);
            cmbSessionRoomName.Name = "cmbSessionRoomName";
            cmbSessionRoomName.Size = new Size(186, 23);
            cmbSessionRoomName.TabIndex = 27;
            // 
            // cmbSpeakerName
            // 
            cmbSpeakerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpeakerName.FormattingEnabled = true;
            cmbSpeakerName.Location = new Point(9, 144);
            cmbSpeakerName.Margin = new Padding(3, 2, 3, 2);
            cmbSpeakerName.Name = "cmbSpeakerName";
            cmbSpeakerName.Size = new Size(186, 23);
            cmbSpeakerName.TabIndex = 26;
            // 
            // lblSpeakerName
            // 
            lblSpeakerName.AutoSize = true;
            lblSpeakerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeakerName.Location = new Point(9, 121);
            lblSpeakerName.Name = "lblSpeakerName";
            lblSpeakerName.Size = new Size(115, 21);
            lblSpeakerName.TabIndex = 25;
            lblSpeakerName.Text = "Speaker Name:";
            // 
            // lblSessionName
            // 
            lblSessionName.AutoSize = true;
            lblSessionName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionName.Location = new Point(9, 66);
            lblSessionName.Name = "lblSessionName";
            lblSessionName.Size = new Size(112, 21);
            lblSessionName.TabIndex = 23;
            lblSessionName.Text = "Session Name:";
            // 
            // lblSessionForm
            // 
            lblSessionForm.AutoSize = true;
            lblSessionForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionForm.Location = new Point(176, 0);
            lblSessionForm.Name = "lblSessionForm";
            lblSessionForm.Size = new Size(156, 32);
            lblSessionForm.TabIndex = 3;
            lblSessionForm.Text = "Session Form";
            // 
            // tbOverview
            // 
            tbOverview.Controls.Add(button21);
            tbOverview.Controls.Add(button22);
            tbOverview.Controls.Add(button23);
            tbOverview.Controls.Add(textBox12);
            tbOverview.Controls.Add(label22);
            tbOverview.Controls.Add(textBox13);
            tbOverview.Controls.Add(label23);
            tbOverview.Controls.Add(textBox14);
            tbOverview.Controls.Add(textBox15);
            tbOverview.Controls.Add(label24);
            tbOverview.Controls.Add(comboBox5);
            tbOverview.Controls.Add(label25);
            tbOverview.Controls.Add(comboBox6);
            tbOverview.Controls.Add(label26);
            tbOverview.Controls.Add(label27);
            tbOverview.Location = new Point(4, 24);
            tbOverview.Margin = new Padding(3, 2, 3, 2);
            tbOverview.Name = "tbOverview";
            tbOverview.Size = new Size(507, 370);
            tbOverview.TabIndex = 4;
            tbOverview.Text = "Overview";
            tbOverview.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button21.Location = new Point(12, 336);
            button21.Margin = new Padding(3, 2, 3, 2);
            button21.Name = "button21";
            button21.Size = new Size(130, 26);
            button21.TabIndex = 44;
            button21.Text = "Exit Application";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button22.Location = new Point(368, 336);
            button22.Margin = new Padding(3, 2, 3, 2);
            button22.Name = "button22";
            button22.Size = new Size(130, 26);
            button22.TabIndex = 43;
            button22.Text = "New Session";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button23.Location = new Point(368, 306);
            button23.Margin = new Padding(3, 2, 3, 2);
            button23.Name = "button23";
            button23.Size = new Size(130, 26);
            button23.TabIndex = 42;
            button23.Text = "New Speaker";
            button23.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(9, 294);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(126, 23);
            textBox12.TabIndex = 41;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(9, 271);
            label22.Name = "label22";
            label22.Size = new Size(52, 21);
            label22.TabIndex = 40;
            label22.Text = "Room";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(9, 238);
            textBox13.Margin = new Padding(3, 2, 3, 2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(219, 23);
            textBox13.TabIndex = 39;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(9, 215);
            label23.Name = "label23";
            label23.Size = new Size(74, 21);
            label23.TabIndex = 38;
            label23.Text = "Duration:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(72, 181);
            textBox14.Margin = new Padding(3, 2, 3, 2);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(63, 23);
            textBox14.TabIndex = 36;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(9, 181);
            textBox15.Margin = new Padding(3, 2, 3, 2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(63, 23);
            textBox15.TabIndex = 35;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(9, 158);
            label24.Name = "label24";
            label24.Size = new Size(78, 21);
            label24.TabIndex = 34;
            label24.Text = "Time Slot:";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(9, 123);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(133, 23);
            comboBox5.TabIndex = 30;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(9, 99);
            label25.Name = "label25";
            label25.Size = new Size(66, 21);
            label25.TabIndex = 29;
            label25.Text = "Session:";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(9, 62);
            comboBox6.Margin = new Padding(3, 2, 3, 2);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(186, 23);
            comboBox6.TabIndex = 28;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(9, 39);
            label26.Name = "label26";
            label26.Size = new Size(115, 21);
            label26.TabIndex = 27;
            label26.Text = "Speaker Name:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(163, 0);
            label27.Name = "label27";
            label27.Size = new Size(175, 32);
            label27.TabIndex = 4;
            label27.Text = "Overview Form";
            // 
            // SessionTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 396);
            Controls.Add(tbcSessionTracker);
            Name = "SessionTrackerForm";
            Text = "Session Tracker Form";
            tbcSessionTracker.ResumeLayout(false);
            tbSpeakerInfo.ResumeLayout(false);
            tbSpeakerInfo.PerformLayout();
            tbRoomInfo.ResumeLayout(false);
            tbRoomInfo.PerformLayout();
            tbTimeSlotInfo.ResumeLayout(false);
            tbTimeSlotInfo.PerformLayout();
            tbSessionInfo.ResumeLayout(false);
            tbSessionInfo.PerformLayout();
            tbOverview.ResumeLayout(false);
            tbOverview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcSessionTracker;
        private TabPage tbSpeakerInfo;
        private Label lblShortBioOptionalNotice;
        private Label lblPastTalksOptionalNotice;
        private Label lblSpeakerRequiredFieldsNotice;
        private Button btnSpeakerExitApplication;
        private Button btnRemoveSpeaker;
        private Button btnCreateSpeaker;
        private Button btnClearSpeakerFields;
        private TextBox txtBoxShortBio;
        private Label lblShortBio;
        private TextBox txtBoxPastTalksGiven;
        private Label lblPastTalksGiven;
        private Label lblEmail;
        private TextBox txtBoxEmail;
        private Label lblDayOfContact;
        private TextBox txtBoxDayOfContactPhoneNumber;
        private TextBox txtBoxPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxFirstName;
        private Label lblFirstName;
        private Label lblSpeakersForm;
        private TabPage tbRoomInfo;
        private Button btnClearRoomFields;
        private Button btnRoomExitApplication;
        private TextBox txtBoxMaxCapacity;
        private Label label9;
        private TextBox txtBoxRoomID;
        private Label label10;
        private Button btnRemoveRoom;
        private Button btnCreateRoom;
        private Label label11;
        private TabPage tbTimeSlotInfo;
        private Button btnTimeSlotExitApplication;
        private Button btnRemoveTimeSlot;
        private Button btnCreateTimeSlot;
        private Button btnClearTimeSlotFields;
        private Label lblSessionDate;
        private DateTimePicker dpSessionDate;
        private DateTimePicker tmpEndTime;
        private Label lblEndTime;
        private DateTimePicker tmpStartTime;
        private Label lblStartTime;
        private Label label15;
        private TabPage tbSessionInfo;
        private Button btnClearSessionFields;
        private ComboBox cmbTimeSlots;
        private TextBox txtBoxSessionName;
        private Button btnSessionExitApplication;
        private Button btnRemoveSession;
        private Button btnCreateSession;
        private Label cmbTimeSlot;
        private TextBox textBox11;
        private Label lblSessionDuration;
        private Label cmbRoomName;
        private ComboBox cmbSessionRoomName;
        private ComboBox cmbSpeakerName;
        private Label lblSpeakerName;
        private Label lblSessionName;
        private Label lblSessionForm;
        private TabPage tbOverview;
        private Button button21;
        private Button button22;
        private Button button23;
        private TextBox textBox12;
        private Label label22;
        private TextBox textBox13;
        private Label label23;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label24;
        private ComboBox comboBox5;
        private Label label25;
        private ComboBox comboBox6;
        private Label label26;
        private Label label27;
        private Label lblRoomRequiredFieldNotice;
    }
}