/*namespace BostonCodeCampSessionTracker
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
            tbOverview = new TabPage();
            lblOverviewRoomName = new Label();
            lblOverviewTimeDuration = new Label();
            cmbOverviewTimeSlots = new ComboBox();
            btnOverviewExitApplication = new Button();
            btnGoToNewSession = new Button();
            btnGoToSpeakerForm = new Button();
            lblRoomID = new Label();
            lblSessionTimeDuration = new Label();
            lblOverviewTimeSlot = new Label();
            cmbOverviewSessionNames = new ComboBox();
            lblSessionSpeakerName = new Label();
            cmbOverviewSpeakerName = new ComboBox();
            lblOverviewSpeakerName = new Label();
            lblOverviewForm = new Label();
            tbSessionInfo = new TabPage();
            btnRemoveTimeSlot = new Button();
            btnClearSessionFields = new Button();
            cmbSessionTimeSlots = new ComboBox();
            txtBoxSessionName = new TextBox();
            btnSessionExitApplication = new Button();
            btnRemoveSession = new Button();
            btnCreateSession = new Button();
            cmbTimeSlot = new Label();
            cmbRoomName = new Label();
            cmbSessionRoomName = new ComboBox();
            cmbSpeakerName = new ComboBox();
            lblSpeakerName = new Label();
            lblSessionName = new Label();
            lblSessionForm = new Label();
            tbTimeSlotInfo = new TabPage();
            btnTimeSlotExitApplication = new Button();
            btnCreateTimeSlot = new Button();
            btnClearTimeSlotFields = new Button();
            lblSessionDate = new Label();
            dpSessionDate = new DateTimePicker();
            tmpEndTime = new DateTimePicker();
            lblEndTime = new Label();
            tmpStartTime = new DateTimePicker();
            lblStartTime = new Label();
            label15 = new Label();
            tbRoomInfo = new TabPage();
            lblRoomRequiredFieldNotice = new Label();
            btnClearRoomFields = new Button();
            btnRoomExitApplication = new Button();
            txtBoxMaxCapacity = new TextBox();
            txtBoxRoomID = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnRemoveRoom = new Button();
            btnCreateRoom = new Button();
            label11 = new Label();
            tbSpeakerInfo = new TabPage();
            lblShortBioOptionalNotice = new Label();
            lblPastTalksOptionalNotice = new Label();
            lblSpeakerRequiredFieldsNotice = new Label();
            btnSpeakerExitApplication = new Button();
            btnRemoveSpeaker = new Button();
            btnCreateSpeaker = new Button();
            btnClearSpeakerFields = new Button();
            txtBoxShortBio = new TextBox();
            txtBoxPastTalksGiven = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxDayOfContactPhoneNumber = new TextBox();
            txtBoxPhoneNumber = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            lblShortBio = new Label();
            lblPastTalksGiven = new Label();
            lblEmail = new Label();
            lblDayOfContact = new Label();
            lblPhoneNumber = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblSpeakersForm = new Label();
            tbcSessionTracker = new TabControl();
            tabPassword = new TabPage();
            txtPassword = new TextBox();
            lblPassword = new Label();
            tabAttendance = new TabPage();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbOverview.SuspendLayout();
            tbSessionInfo.SuspendLayout();
            tbTimeSlotInfo.SuspendLayout();
            tbRoomInfo.SuspendLayout();
            tbSpeakerInfo.SuspendLayout();
            tbcSessionTracker.SuspendLayout();
            tabPassword.SuspendLayout();
            tabAttendance.SuspendLayout();
            SuspendLayout();
            // 
            // tbOverview
            // 
            tbOverview.Controls.Add(lblOverviewRoomName);
            tbOverview.Controls.Add(lblOverviewTimeDuration);
            tbOverview.Controls.Add(cmbOverviewTimeSlots);
            tbOverview.Controls.Add(btnOverviewExitApplication);
            tbOverview.Controls.Add(btnGoToNewSession);
            tbOverview.Controls.Add(btnGoToSpeakerForm);
            tbOverview.Controls.Add(lblRoomID);
            tbOverview.Controls.Add(lblSessionTimeDuration);
            tbOverview.Controls.Add(lblOverviewTimeSlot);
            tbOverview.Controls.Add(cmbOverviewSessionNames);
            tbOverview.Controls.Add(lblSessionSpeakerName);
            tbOverview.Controls.Add(cmbOverviewSpeakerName);
            tbOverview.Controls.Add(lblOverviewSpeakerName);
            tbOverview.Controls.Add(lblOverviewForm);
            tbOverview.Location = new Point(4, 29);
            tbOverview.Name = "tbOverview";
            tbOverview.Size = new Size(581, 498);
            tbOverview.TabIndex = 4;
            tbOverview.Text = "Overview";
            tbOverview.UseVisualStyleBackColor = true;
            // 
            // lblOverviewRoomName
            // 
            lblOverviewRoomName.BackColor = SystemColors.Window;
            lblOverviewRoomName.BorderStyle = BorderStyle.FixedSingle;
            lblOverviewRoomName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewRoomName.ForeColor = SystemColors.ControlText;
            lblOverviewRoomName.Location = new Point(10, 347);
            lblOverviewRoomName.Name = "lblOverviewRoomName";
            lblOverviewRoomName.Size = new Size(212, 39);
            lblOverviewRoomName.TabIndex = 47;
            lblOverviewRoomName.TextAlign = ContentAlignment.MiddleLeft;
            lblOverviewRoomName.Click += lblOverviewRoomName_Click;
            // 
            // lblOverviewTimeDuration
            // 
            lblOverviewTimeDuration.BackColor = SystemColors.Window;
            lblOverviewTimeDuration.BorderStyle = BorderStyle.FixedSingle;
            lblOverviewTimeDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewTimeDuration.ForeColor = SystemColors.ControlText;
            lblOverviewTimeDuration.Location = new Point(10, 283);
            lblOverviewTimeDuration.Name = "lblOverviewTimeDuration";
            lblOverviewTimeDuration.Size = new Size(212, 39);
            lblOverviewTimeDuration.TabIndex = 46;
            lblOverviewTimeDuration.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbOverviewTimeSlots
            // 
            cmbOverviewTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverviewTimeSlots.FormattingEnabled = true;
            cmbOverviewTimeSlots.Location = new Point(10, 220);
            cmbOverviewTimeSlots.Margin = new Padding(3, 4, 3, 4);
            cmbOverviewTimeSlots.Name = "cmbOverviewTimeSlots";
            cmbOverviewTimeSlots.Size = new Size(212, 28);
            cmbOverviewTimeSlots.TabIndex = 45;
            cmbOverviewTimeSlots.SelectionChangeCommitted += cmbOverviewTimeSlots_SelectionChangeCommitted;
            // 
            // btnOverviewExitApplication
            // 
            btnOverviewExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOverviewExitApplication.Location = new Point(10, 448);
            btnOverviewExitApplication.Name = "btnOverviewExitApplication";
            btnOverviewExitApplication.Size = new Size(213, 40);
            btnOverviewExitApplication.TabIndex = 44;
            btnOverviewExitApplication.Text = "Exit Application";
            btnOverviewExitApplication.UseVisualStyleBackColor = true;
            btnOverviewExitApplication.Click += btnOverviewExitApplication_Click;
            // 
            // btnGoToNewSession
            // 
            btnGoToNewSession.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoToNewSession.Location = new Point(363, 451);
            btnGoToNewSession.Name = "btnGoToNewSession";
            btnGoToNewSession.Size = new Size(213, 40);
            btnGoToNewSession.TabIndex = 43;
            btnGoToNewSession.Text = "New Session";
            btnGoToNewSession.UseVisualStyleBackColor = true;
            btnGoToNewSession.Click += btnGoToNewSession_Click;
            // 
            // btnGoToSpeakerForm
            // 
            btnGoToSpeakerForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoToSpeakerForm.Location = new Point(363, 403);
            btnGoToSpeakerForm.Name = "btnGoToSpeakerForm";
            btnGoToSpeakerForm.Size = new Size(213, 40);
            btnGoToSpeakerForm.TabIndex = 42;
            btnGoToSpeakerForm.Text = "New Speaker";
            btnGoToSpeakerForm.UseVisualStyleBackColor = true;
            btnGoToSpeakerForm.Click += btnGoToSpeakerForm_Click;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRoomID.Location = new Point(10, 319);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(92, 28);
            lblRoomID.TabIndex = 40;
            lblRoomID.Text = "Room ID:";
            // 
            // lblSessionTimeDuration
            // 
            lblSessionTimeDuration.AutoSize = true;
            lblSessionTimeDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionTimeDuration.Location = new Point(10, 255);
            lblSessionTimeDuration.Name = "lblSessionTimeDuration";
            lblSessionTimeDuration.Size = new Size(93, 28);
            lblSessionTimeDuration.TabIndex = 38;
            lblSessionTimeDuration.Text = "Duration:";
            // 
            // lblOverviewTimeSlot
            // 
            lblOverviewTimeSlot.AutoSize = true;
            lblOverviewTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewTimeSlot.Location = new Point(10, 188);
            lblOverviewTimeSlot.Name = "lblOverviewTimeSlot";
            lblOverviewTimeSlot.Size = new Size(98, 28);
            lblOverviewTimeSlot.TabIndex = 34;
            lblOverviewTimeSlot.Text = "Time Slot:";
            // 
            // cmbOverviewSessionNames
            // 
            cmbOverviewSessionNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverviewSessionNames.FormattingEnabled = true;
            cmbOverviewSessionNames.Location = new Point(10, 155);
            cmbOverviewSessionNames.Name = "cmbOverviewSessionNames";
            cmbOverviewSessionNames.Size = new Size(212, 28);
            cmbOverviewSessionNames.TabIndex = 30;
            cmbOverviewSessionNames.SelectionChangeCommitted += cmbOverviewSession_SelectionChangeCommitted;
            // 
            // lblSessionSpeakerName
            // 
            lblSessionSpeakerName.AutoSize = true;
            lblSessionSpeakerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionSpeakerName.Location = new Point(10, 123);
            lblSessionSpeakerName.Name = "lblSessionSpeakerName";
            lblSessionSpeakerName.Size = new Size(81, 28);
            lblSessionSpeakerName.TabIndex = 29;
            lblSessionSpeakerName.Text = "Session:";
            // 
            // cmbOverviewSpeakerName
            // 
            cmbOverviewSpeakerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverviewSpeakerName.FormattingEnabled = true;
            cmbOverviewSpeakerName.Location = new Point(10, 89);
            cmbOverviewSpeakerName.Name = "cmbOverviewSpeakerName";
            cmbOverviewSpeakerName.Size = new Size(212, 28);
            cmbOverviewSpeakerName.TabIndex = 28;
            cmbOverviewSpeakerName.SelectionChangeCommitted += cmbOverviewSpeakerName_SelectionChangeCommitted;
            // 
            // lblOverviewSpeakerName
            // 
            lblOverviewSpeakerName.AutoSize = true;
            lblOverviewSpeakerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewSpeakerName.Location = new Point(10, 59);
            lblOverviewSpeakerName.Name = "lblOverviewSpeakerName";
            lblOverviewSpeakerName.Size = new Size(143, 28);
            lblOverviewSpeakerName.TabIndex = 27;
            lblOverviewSpeakerName.Text = "Speaker Name:";
            // 
            // lblOverviewForm
            // 
            lblOverviewForm.AutoSize = true;
            lblOverviewForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewForm.Location = new Point(186, 0);
            lblOverviewForm.Name = "lblOverviewForm";
            lblOverviewForm.Size = new Size(217, 41);
            lblOverviewForm.TabIndex = 4;
            lblOverviewForm.Text = "Overview Form";
            // 
            // tbSessionInfo
            // 
            tbSessionInfo.Controls.Add(btnRemoveTimeSlot);
            tbSessionInfo.Controls.Add(btnClearSessionFields);
            tbSessionInfo.Controls.Add(cmbSessionTimeSlots);
            tbSessionInfo.Controls.Add(txtBoxSessionName);
            tbSessionInfo.Controls.Add(btnSessionExitApplication);
            tbSessionInfo.Controls.Add(btnRemoveSession);
            tbSessionInfo.Controls.Add(btnCreateSession);
            tbSessionInfo.Controls.Add(cmbTimeSlot);
            tbSessionInfo.Controls.Add(cmbRoomName);
            tbSessionInfo.Controls.Add(cmbSessionRoomName);
            tbSessionInfo.Controls.Add(cmbSpeakerName);
            tbSessionInfo.Controls.Add(lblSpeakerName);
            tbSessionInfo.Controls.Add(lblSessionName);
            tbSessionInfo.Controls.Add(lblSessionForm);
            tbSessionInfo.Location = new Point(4, 29);
            tbSessionInfo.Name = "tbSessionInfo";
            tbSessionInfo.Size = new Size(581, 498);
            tbSessionInfo.TabIndex = 3;
            tbSessionInfo.Text = "Session Info";
            tbSessionInfo.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTimeSlot
            // 
            btnRemoveTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveTimeSlot.Location = new Point(357, 444);
            btnRemoveTimeSlot.Name = "btnRemoveTimeSlot";
            btnRemoveTimeSlot.Size = new Size(213, 40);
            btnRemoveTimeSlot.TabIndex = 42;
            btnRemoveTimeSlot.Text = "Remove Time Slot";
            btnRemoveTimeSlot.UseVisualStyleBackColor = true;
            // 
            // btnClearSessionFields
            // 
            btnClearSessionFields.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearSessionFields.Location = new Point(357, 308);
            btnClearSessionFields.Name = "btnClearSessionFields";
            btnClearSessionFields.Size = new Size(213, 40);
            btnClearSessionFields.TabIndex = 41;
            btnClearSessionFields.Text = "Clear Fields";
            btnClearSessionFields.UseVisualStyleBackColor = true;
            btnClearSessionFields.Click += btnClearSessionFields_Click;
            // 
            // cmbSessionTimeSlots
            // 
            cmbSessionTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSessionTimeSlots.FormattingEnabled = true;
            cmbSessionTimeSlots.Location = new Point(10, 277);
            cmbSessionTimeSlots.Margin = new Padding(3, 4, 3, 4);
            cmbSessionTimeSlots.Name = "cmbSessionTimeSlots";
            cmbSessionTimeSlots.Size = new Size(212, 28);
            cmbSessionTimeSlots.TabIndex = 39;
            // 
            // txtBoxSessionName
            // 
            txtBoxSessionName.Location = new Point(10, 120);
            txtBoxSessionName.Margin = new Padding(3, 4, 3, 4);
            txtBoxSessionName.Name = "txtBoxSessionName";
            txtBoxSessionName.Size = new Size(212, 27);
            txtBoxSessionName.TabIndex = 38;
            txtBoxSessionName.KeyPress += txtBoxSessionName_KeyPress;
            // 
            // btnSessionExitApplication
            // 
            btnSessionExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSessionExitApplication.Location = new Point(10, 444);
            btnSessionExitApplication.Name = "btnSessionExitApplication";
            btnSessionExitApplication.Size = new Size(213, 40);
            btnSessionExitApplication.TabIndex = 37;
            btnSessionExitApplication.Text = "Exit Application";
            btnSessionExitApplication.UseVisualStyleBackColor = true;
            btnSessionExitApplication.Click += btnSessionExitApplication_Click;
            // 
            // btnRemoveSession
            // 
            btnRemoveSession.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveSession.Location = new Point(357, 399);
            btnRemoveSession.Name = "btnRemoveSession";
            btnRemoveSession.Size = new Size(213, 40);
            btnRemoveSession.TabIndex = 36;
            btnRemoveSession.Text = "Remove Session";
            btnRemoveSession.UseVisualStyleBackColor = true;
            btnRemoveSession.Click += btnRemoveSession_Click;
            // 
            // btnCreateSession
            // 
            btnCreateSession.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSession.Location = new Point(357, 353);
            btnCreateSession.Name = "btnCreateSession";
            btnCreateSession.Size = new Size(213, 40);
            btnCreateSession.TabIndex = 35;
            btnCreateSession.Text = "Create Session";
            btnCreateSession.UseVisualStyleBackColor = true;
            btnCreateSession.Click += btnCreateSession_Click;
            // 
            // cmbTimeSlot
            // 
            cmbTimeSlot.AutoSize = true;
            cmbTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTimeSlot.Location = new Point(10, 245);
            cmbTimeSlot.Name = "cmbTimeSlot";
            cmbTimeSlot.Size = new Size(98, 28);
            cmbTimeSlot.TabIndex = 31;
            cmbTimeSlot.Text = "Time Slot:";
            // 
            // cmbRoomName
            // 
            cmbRoomName.AutoSize = true;
            cmbRoomName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoomName.Location = new Point(361, 88);
            cmbRoomName.Name = "cmbRoomName";
            cmbRoomName.Size = new Size(125, 28);
            cmbRoomName.TabIndex = 28;
            cmbRoomName.Text = "Room Name:";
            // 
            // cmbSessionRoomName
            // 
            cmbSessionRoomName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSessionRoomName.FormattingEnabled = true;
            cmbSessionRoomName.Location = new Point(361, 120);
            cmbSessionRoomName.Name = "cmbSessionRoomName";
            cmbSessionRoomName.Size = new Size(212, 28);
            cmbSessionRoomName.TabIndex = 27;
            // 
            // cmbSpeakerName
            // 
            cmbSpeakerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpeakerName.FormattingEnabled = true;
            cmbSpeakerName.Location = new Point(10, 192);
            cmbSpeakerName.Name = "cmbSpeakerName";
            cmbSpeakerName.Size = new Size(212, 28);
            cmbSpeakerName.TabIndex = 26;
            cmbSpeakerName.SelectedIndexChanged += cmbSpeakerName_SelectedIndexChanged;
            // 
            // lblSpeakerName
            // 
            lblSpeakerName.AutoSize = true;
            lblSpeakerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeakerName.Location = new Point(10, 161);
            lblSpeakerName.Name = "lblSpeakerName";
            lblSpeakerName.Size = new Size(143, 28);
            lblSpeakerName.TabIndex = 25;
            lblSpeakerName.Text = "Speaker Name:";
            // 
            // lblSessionName
            // 
            lblSessionName.AutoSize = true;
            lblSessionName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionName.Location = new Point(10, 88);
            lblSessionName.Name = "lblSessionName";
            lblSessionName.Size = new Size(138, 28);
            lblSessionName.TabIndex = 23;
            lblSessionName.Text = "Session Name:";
            // 
            // lblSessionForm
            // 
            lblSessionForm.AutoSize = true;
            lblSessionForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionForm.Location = new Point(201, 0);
            lblSessionForm.Name = "lblSessionForm";
            lblSessionForm.Size = new Size(195, 41);
            lblSessionForm.TabIndex = 3;
            lblSessionForm.Text = "Session Form";
            // 
            // tbTimeSlotInfo
            // 
            tbTimeSlotInfo.Controls.Add(btnTimeSlotExitApplication);
            tbTimeSlotInfo.Controls.Add(btnCreateTimeSlot);
            tbTimeSlotInfo.Controls.Add(btnClearTimeSlotFields);
            tbTimeSlotInfo.Controls.Add(lblSessionDate);
            tbTimeSlotInfo.Controls.Add(dpSessionDate);
            tbTimeSlotInfo.Controls.Add(tmpEndTime);
            tbTimeSlotInfo.Controls.Add(lblEndTime);
            tbTimeSlotInfo.Controls.Add(tmpStartTime);
            tbTimeSlotInfo.Controls.Add(lblStartTime);
            tbTimeSlotInfo.Controls.Add(label15);
            tbTimeSlotInfo.Location = new Point(4, 29);
            tbTimeSlotInfo.Name = "tbTimeSlotInfo";
            tbTimeSlotInfo.Size = new Size(581, 498);
            tbTimeSlotInfo.TabIndex = 2;
            tbTimeSlotInfo.Text = "Time Slot Info";
            tbTimeSlotInfo.UseVisualStyleBackColor = true;
            // 
            // btnTimeSlotExitApplication
            // 
            btnTimeSlotExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimeSlotExitApplication.Location = new Point(10, 448);
            btnTimeSlotExitApplication.Name = "btnTimeSlotExitApplication";
            btnTimeSlotExitApplication.Size = new Size(213, 40);
            btnTimeSlotExitApplication.TabIndex = 38;
            btnTimeSlotExitApplication.Text = "Exit Application";
            btnTimeSlotExitApplication.UseVisualStyleBackColor = true;
            btnTimeSlotExitApplication.Click += btnTimeSlotExitApplication_Click;
            // 
            // btnCreateTimeSlot
            // 
            btnCreateTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTimeSlot.Location = new Point(357, 447);
            btnCreateTimeSlot.Name = "btnCreateTimeSlot";
            btnCreateTimeSlot.Size = new Size(213, 40);
            btnCreateTimeSlot.TabIndex = 31;
            btnCreateTimeSlot.Text = "Create Time Slot";
            btnCreateTimeSlot.UseVisualStyleBackColor = true;
            btnCreateTimeSlot.Click += btnCreateTimeSlot_Click;
            // 
            // btnClearTimeSlotFields
            // 
            btnClearTimeSlotFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearTimeSlotFields.Location = new Point(357, 401);
            btnClearTimeSlotFields.Name = "btnClearTimeSlotFields";
            btnClearTimeSlotFields.Size = new Size(213, 40);
            btnClearTimeSlotFields.TabIndex = 30;
            btnClearTimeSlotFields.Text = "New Time Slot";
            btnClearTimeSlotFields.UseVisualStyleBackColor = true;
            btnClearTimeSlotFields.Click += btnClearTimeSlotFields_Click;
            // 
            // lblSessionDate
            // 
            lblSessionDate.AutoSize = true;
            lblSessionDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionDate.Location = new Point(3, 267);
            lblSessionDate.Name = "lblSessionDate";
            lblSessionDate.Size = new Size(127, 28);
            lblSessionDate.TabIndex = 29;
            lblSessionDate.Text = "Session Date:";
            // 
            // dpSessionDate
            // 
            dpSessionDate.CustomFormat = "dd/mm/yyyy";
            dpSessionDate.Format = DateTimePickerFormat.Short;
            dpSessionDate.Location = new Point(3, 299);
            dpSessionDate.Name = "dpSessionDate";
            dpSessionDate.Size = new Size(250, 27);
            dpSessionDate.TabIndex = 28;
            dpSessionDate.Value = new DateTime(2023, 4, 14, 0, 0, 0, 0);
            // 
            // tmpEndTime
            // 
            tmpEndTime.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tmpEndTime.CustomFormat = "hh:mm tt";
            tmpEndTime.Format = DateTimePickerFormat.Custom;
            tmpEndTime.Location = new Point(3, 216);
            tmpEndTime.Name = "tmpEndTime";
            tmpEndTime.ShowUpDown = true;
            tmpEndTime.Size = new Size(105, 27);
            tmpEndTime.TabIndex = 25;
            tmpEndTime.Value = new DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndTime.Location = new Point(3, 185);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(96, 28);
            lblEndTime.TabIndex = 24;
            lblEndTime.Text = "End Time:";
            // 
            // tmpStartTime
            // 
            tmpStartTime.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tmpStartTime.CustomFormat = "hh:mm tt";
            tmpStartTime.Format = DateTimePickerFormat.Custom;
            tmpStartTime.Location = new Point(3, 127);
            tmpStartTime.Name = "tmpStartTime";
            tmpStartTime.ShowUpDown = true;
            tmpStartTime.Size = new Size(105, 27);
            tmpStartTime.TabIndex = 23;
            tmpStartTime.Value = new DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartTime.Location = new Point(3, 96);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(104, 28);
            lblStartTime.TabIndex = 22;
            lblStartTime.Text = "Start Time:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(200, 0);
            label15.Name = "label15";
            label15.Size = new Size(219, 41);
            label15.TabIndex = 2;
            label15.Text = "Time Slot Form";
            // 
            // tbRoomInfo
            // 
            tbRoomInfo.Controls.Add(lblRoomRequiredFieldNotice);
            tbRoomInfo.Controls.Add(btnClearRoomFields);
            tbRoomInfo.Controls.Add(btnRoomExitApplication);
            tbRoomInfo.Controls.Add(txtBoxMaxCapacity);
            tbRoomInfo.Controls.Add(txtBoxRoomID);
            tbRoomInfo.Controls.Add(label9);
            tbRoomInfo.Controls.Add(label10);
            tbRoomInfo.Controls.Add(btnRemoveRoom);
            tbRoomInfo.Controls.Add(btnCreateRoom);
            tbRoomInfo.Controls.Add(label11);
            tbRoomInfo.Location = new Point(4, 29);
            tbRoomInfo.Name = "tbRoomInfo";
            tbRoomInfo.Padding = new Padding(3);
            tbRoomInfo.Size = new Size(581, 498);
            tbRoomInfo.TabIndex = 1;
            tbRoomInfo.Text = "Room Info";
            tbRoomInfo.UseVisualStyleBackColor = true;
            // 
            // lblRoomRequiredFieldNotice
            // 
            lblRoomRequiredFieldNotice.AutoSize = true;
            lblRoomRequiredFieldNotice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRoomRequiredFieldNotice.Location = new Point(10, 48);
            lblRoomRequiredFieldNotice.Name = "lblRoomRequiredFieldNotice";
            lblRoomRequiredFieldNotice.Size = new Size(374, 23);
            lblRoomRequiredFieldNotice.TabIndex = 40;
            lblRoomRequiredFieldNotice.Text = "(All fields are required unless stated as optional)";
            // 
            // btnClearRoomFields
            // 
            btnClearRoomFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearRoomFields.Location = new Point(363, 365);
            btnClearRoomFields.Margin = new Padding(3, 4, 3, 4);
            btnClearRoomFields.Name = "btnClearRoomFields";
            btnClearRoomFields.Size = new Size(213, 40);
            btnClearRoomFields.TabIndex = 39;
            btnClearRoomFields.Text = "Clear Fields";
            btnClearRoomFields.UseVisualStyleBackColor = true;
            btnClearRoomFields.Click += btnClearRoomFields_Click;
            // 
            // btnRoomExitApplication
            // 
            btnRoomExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoomExitApplication.Location = new Point(10, 449);
            btnRoomExitApplication.Name = "btnRoomExitApplication";
            btnRoomExitApplication.Size = new Size(213, 40);
            btnRoomExitApplication.TabIndex = 38;
            btnRoomExitApplication.Text = "Exit Application";
            btnRoomExitApplication.UseVisualStyleBackColor = true;
            btnRoomExitApplication.Click += btnRoomExitApplication_Click;
            // 
            // txtBoxMaxCapacity
            // 
            txtBoxMaxCapacity.Location = new Point(10, 163);
            txtBoxMaxCapacity.Name = "txtBoxMaxCapacity";
            txtBoxMaxCapacity.Size = new Size(212, 27);
            txtBoxMaxCapacity.TabIndex = 24;
            txtBoxMaxCapacity.KeyPress += txtBoxMaxCapacity_KeyPress;
            // 
            // txtBoxRoomID
            // 
            txtBoxRoomID.Location = new Point(10, 99);
            txtBoxRoomID.Name = "txtBoxRoomID";
            txtBoxRoomID.Size = new Size(212, 27);
            txtBoxRoomID.TabIndex = 22;
            txtBoxRoomID.KeyPress += txtBoxRoomID_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 137);
            label9.Name = "label9";
            label9.Size = new Size(129, 28);
            label9.TabIndex = 23;
            label9.Text = "Max Capacity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 73);
            label10.Name = "label10";
            label10.Size = new Size(92, 28);
            label10.TabIndex = 21;
            label10.Text = "Room ID:";
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveRoom.Location = new Point(363, 449);
            btnRemoveRoom.Name = "btnRemoveRoom";
            btnRemoveRoom.Size = new Size(213, 40);
            btnRemoveRoom.TabIndex = 20;
            btnRemoveRoom.Text = "Remove Room";
            btnRemoveRoom.UseVisualStyleBackColor = true;
            btnRemoveRoom.Click += btnRemoveRoom_Click;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateRoom.Location = new Point(363, 407);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(213, 40);
            btnCreateRoom.TabIndex = 19;
            btnCreateRoom.Text = "Create Room";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(226, 8);
            label11.Name = "label11";
            label11.Size = new Size(174, 41);
            label11.TabIndex = 1;
            label11.Text = "Room Form";
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
            tbSpeakerInfo.Controls.Add(txtBoxPastTalksGiven);
            tbSpeakerInfo.Controls.Add(txtBoxEmail);
            tbSpeakerInfo.Controls.Add(txtBoxDayOfContactPhoneNumber);
            tbSpeakerInfo.Controls.Add(txtBoxPhoneNumber);
            tbSpeakerInfo.Controls.Add(txtBoxLastName);
            tbSpeakerInfo.Controls.Add(txtBoxFirstName);
            tbSpeakerInfo.Controls.Add(lblShortBio);
            tbSpeakerInfo.Controls.Add(lblPastTalksGiven);
            tbSpeakerInfo.Controls.Add(lblEmail);
            tbSpeakerInfo.Controls.Add(lblDayOfContact);
            tbSpeakerInfo.Controls.Add(lblPhoneNumber);
            tbSpeakerInfo.Controls.Add(lblLastName);
            tbSpeakerInfo.Controls.Add(lblFirstName);
            tbSpeakerInfo.Controls.Add(lblSpeakersForm);
            tbSpeakerInfo.Location = new Point(4, 29);
            tbSpeakerInfo.Name = "tbSpeakerInfo";
            tbSpeakerInfo.Padding = new Padding(3);
            tbSpeakerInfo.Size = new Size(581, 498);
            tbSpeakerInfo.TabIndex = 0;
            tbSpeakerInfo.Text = "Speaker Info";
            tbSpeakerInfo.UseVisualStyleBackColor = true;
            // 
            // lblShortBioOptionalNotice
            // 
            lblShortBioOptionalNotice.AutoSize = true;
            lblShortBioOptionalNotice.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortBioOptionalNotice.Location = new Point(152, 321);
            lblShortBioOptionalNotice.Name = "lblShortBioOptionalNotice";
            lblShortBioOptionalNotice.Size = new Size(70, 19);
            lblShortBioOptionalNotice.TabIndex = 41;
            lblShortBioOptionalNotice.Text = "(Optional)";
            // 
            // lblPastTalksOptionalNotice
            // 
            lblPastTalksOptionalNotice.AutoSize = true;
            lblPastTalksOptionalNotice.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPastTalksOptionalNotice.Location = new Point(505, 207);
            lblPastTalksOptionalNotice.Name = "lblPastTalksOptionalNotice";
            lblPastTalksOptionalNotice.Size = new Size(70, 19);
            lblPastTalksOptionalNotice.TabIndex = 40;
            lblPastTalksOptionalNotice.Text = "(Optional)";
            // 
            // lblSpeakerRequiredFieldsNotice
            // 
            lblSpeakerRequiredFieldsNotice.AutoSize = true;
            lblSpeakerRequiredFieldsNotice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeakerRequiredFieldsNotice.Location = new Point(10, 61);
            lblSpeakerRequiredFieldsNotice.Name = "lblSpeakerRequiredFieldsNotice";
            lblSpeakerRequiredFieldsNotice.Size = new Size(374, 23);
            lblSpeakerRequiredFieldsNotice.TabIndex = 39;
            lblSpeakerRequiredFieldsNotice.Text = "(All fields are required unless stated as optional)";
            // 
            // btnSpeakerExitApplication
            // 
            btnSpeakerExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpeakerExitApplication.Location = new Point(7, 447);
            btnSpeakerExitApplication.Name = "btnSpeakerExitApplication";
            btnSpeakerExitApplication.Size = new Size(213, 40);
            btnSpeakerExitApplication.TabIndex = 38;
            btnSpeakerExitApplication.Text = "Exit Application";
            btnSpeakerExitApplication.UseVisualStyleBackColor = true;
            btnSpeakerExitApplication.Click += btnSpeakerExitApplication_Click;
            // 
            // btnRemoveSpeaker
            // 
            btnRemoveSpeaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveSpeaker.Location = new Point(361, 447);
            btnRemoveSpeaker.Name = "btnRemoveSpeaker";
            btnRemoveSpeaker.Size = new Size(213, 40);
            btnRemoveSpeaker.TabIndex = 17;
            btnRemoveSpeaker.Text = "Remove Speaker";
            btnRemoveSpeaker.UseVisualStyleBackColor = true;
            btnRemoveSpeaker.Click += btnRemoveSpeaker_Click;
            // 
            // btnCreateSpeaker
            // 
            btnCreateSpeaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSpeaker.Location = new Point(361, 403);
            btnCreateSpeaker.Name = "btnCreateSpeaker";
            btnCreateSpeaker.Size = new Size(213, 40);
            btnCreateSpeaker.TabIndex = 16;
            btnCreateSpeaker.Text = "Create Speaker";
            btnCreateSpeaker.UseVisualStyleBackColor = true;
            btnCreateSpeaker.Click += btnCreateSpeaker_Click;
            // 
            // btnClearSpeakerFields
            // 
            btnClearSpeakerFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearSpeakerFields.Location = new Point(361, 359);
            btnClearSpeakerFields.Name = "btnClearSpeakerFields";
            btnClearSpeakerFields.Size = new Size(213, 40);
            btnClearSpeakerFields.TabIndex = 15;
            btnClearSpeakerFields.Text = "Clear Fields";
            btnClearSpeakerFields.UseVisualStyleBackColor = true;
            btnClearSpeakerFields.Click += btnClearSpeakerFields_Click;
            // 
            // txtBoxShortBio
            // 
            txtBoxShortBio.Location = new Point(7, 341);
            txtBoxShortBio.Multiline = true;
            txtBoxShortBio.Name = "txtBoxShortBio";
            txtBoxShortBio.Size = new Size(212, 99);
            txtBoxShortBio.TabIndex = 14;
            txtBoxShortBio.KeyPress += txtBoxShortBio_KeyPress;
            // 
            // txtBoxPastTalksGiven
            // 
            txtBoxPastTalksGiven.Location = new Point(361, 224);
            txtBoxPastTalksGiven.Multiline = true;
            txtBoxPastTalksGiven.Name = "txtBoxPastTalksGiven";
            txtBoxPastTalksGiven.Size = new Size(212, 99);
            txtBoxPastTalksGiven.TabIndex = 12;
            txtBoxPastTalksGiven.KeyPress += txtBoxPastTalksGiven_KeyPress;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(7, 269);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(212, 27);
            txtBoxEmail.TabIndex = 9;
            txtBoxEmail.KeyPress += txtBoxEmail_KeyPress;
            // 
            // txtBoxDayOfContactPhoneNumber
            // 
            txtBoxDayOfContactPhoneNumber.Location = new Point(361, 156);
            txtBoxDayOfContactPhoneNumber.Name = "txtBoxDayOfContactPhoneNumber";
            txtBoxDayOfContactPhoneNumber.Size = new Size(212, 27);
            txtBoxDayOfContactPhoneNumber.TabIndex = 7;
            txtBoxDayOfContactPhoneNumber.KeyPress += txtBoxDayOfContactPhoneNumber_KeyPress;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(361, 83);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(212, 27);
            txtBoxPhoneNumber.TabIndex = 6;
            txtBoxPhoneNumber.KeyPress += txtBoxPhoneNumber_KeyPress;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(7, 201);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(212, 27);
            txtBoxLastName.TabIndex = 4;
            txtBoxLastName.KeyPress += txtBoxLastName_KeyPress;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(7, 128);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(212, 27);
            txtBoxFirstName.TabIndex = 2;
            txtBoxFirstName.KeyPress += txtBoxFirstName_KeyPress;
            // 
            // lblShortBio
            // 
            lblShortBio.AutoSize = true;
            lblShortBio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortBio.Location = new Point(14, 316);
            lblShortBio.Name = "lblShortBio";
            lblShortBio.Size = new Size(97, 28);
            lblShortBio.TabIndex = 13;
            lblShortBio.Text = "Short Bio:";
            // 
            // lblPastTalksGiven
            // 
            lblPastTalksGiven.AutoSize = true;
            lblPastTalksGiven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPastTalksGiven.Location = new Point(368, 199);
            lblPastTalksGiven.Name = "lblPastTalksGiven";
            lblPastTalksGiven.Size = new Size(152, 28);
            lblPastTalksGiven.TabIndex = 11;
            lblPastTalksGiven.Text = "Past Talks Given:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(14, 244);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblDayOfContact
            // 
            lblDayOfContact.AutoSize = true;
            lblDayOfContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDayOfContact.Location = new Point(368, 131);
            lblDayOfContact.Name = "lblDayOfContact";
            lblDayOfContact.Size = new Size(226, 28);
            lblDayOfContact.TabIndex = 8;
            lblDayOfContact.Text = "Day Of Contact Number:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(368, 57);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(148, 28);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(14, 176);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(102, 28);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(14, 103);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(105, 28);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "FirstName:";
            // 
            // lblSpeakersForm
            // 
            lblSpeakersForm.AutoSize = true;
            lblSpeakersForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeakersForm.Location = new Point(205, 5);
            lblSpeakersForm.Name = "lblSpeakersForm";
            lblSpeakersForm.Size = new Size(201, 41);
            lblSpeakersForm.TabIndex = 0;
            lblSpeakersForm.Text = "Speaker Form";
            // 
            // tbcSessionTracker
            // 
            tbcSessionTracker.Controls.Add(tabPassword);
            tbcSessionTracker.Controls.Add(tbSpeakerInfo);
            tbcSessionTracker.Controls.Add(tbRoomInfo);
            tbcSessionTracker.Controls.Add(tbTimeSlotInfo);
            tbcSessionTracker.Controls.Add(tbSessionInfo);
            tbcSessionTracker.Controls.Add(tbOverview);
            tbcSessionTracker.Controls.Add(tabAttendance);
            tbcSessionTracker.Location = new Point(1, 0);
            tbcSessionTracker.Name = "tbcSessionTracker";
            tbcSessionTracker.SelectedIndex = 0;
            tbcSessionTracker.Size = new Size(644, 531);
            tbcSessionTracker.TabIndex = 2;
            tbcSessionTracker.Click += tbcSessionTracker_Click;
            // 
            // tabPassword
            // 
            tabPassword.Controls.Add(txtPassword);
            tabPassword.Controls.Add(lblPassword);
            tabPassword.Location = new Point(4, 29);
            tabPassword.Name = "tabPassword";
            tabPassword.Size = new Size(636, 498);
            tabPassword.TabIndex = 6;
            tabPassword.Text = "Password";
            tabPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(189, 242);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox6_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(31, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(138, 38);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // tabAttendance
            // 
            tabAttendance.Controls.Add(button1);
            tabAttendance.Controls.Add(textBox5);
            tabAttendance.Controls.Add(textBox4);
            tabAttendance.Controls.Add(textBox3);
            tabAttendance.Controls.Add(textBox2);
            tabAttendance.Controls.Add(textBox1);
            tabAttendance.Controls.Add(label5);
            tabAttendance.Controls.Add(label4);
            tabAttendance.Controls.Add(label3);
            tabAttendance.Controls.Add(label2);
            tabAttendance.Controls.Add(label1);
            tabAttendance.Location = new Point(4, 29);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Size = new Size(581, 498);
            tabAttendance.TabIndex = 5;
            tabAttendance.Text = "Attendance";
            tabAttendance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(443, 434);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(36, 164);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(36, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 379);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 125);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 4;
            label5.Text = "Room:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 194);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 3;
            label4.Text = "Beginning Count:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 268);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 2;
            label3.Text = "Middle Count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 333);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "End Count:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 54);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Session:";
            // 
            // SessionTrackerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 528);
            Controls.Add(tbcSessionTracker);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SessionTrackerForm";
            Text = "Session Tracker Form";
            tbOverview.ResumeLayout(false);
            tbOverview.PerformLayout();
            tbSessionInfo.ResumeLayout(false);
            tbSessionInfo.PerformLayout();
            tbTimeSlotInfo.ResumeLayout(false);
            tbTimeSlotInfo.PerformLayout();
            tbRoomInfo.ResumeLayout(false);
            tbRoomInfo.PerformLayout();
            tbSpeakerInfo.ResumeLayout(false);
            tbSpeakerInfo.PerformLayout();
            tbcSessionTracker.ResumeLayout(false);
            tabPassword.ResumeLayout(false);
            tabPassword.PerformLayout();
            tabAttendance.ResumeLayout(false);
            tabAttendance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tbOverview;
        private Button btnOverviewExitApplication;
        private Button btnGoToNewSession;
        private Button btnGoToSpeakerForm;
        private Label lblRoomID;
        private Label lblSessionTimeDuration;
        private Label lblOverviewTimeSlot;
        private ComboBox cmbOverviewSessionNames;
        private Label lblSessionSpeakerName;
        private ComboBox cmbOverviewSpeakerName;
        private Label lblOverviewSpeakerName;
        private Label lblOverviewForm;
        private TabPage tbSessionInfo;
        private Button btnClearSessionFields;
        private ComboBox cmbSessionTimeSlots;
        private TextBox txtBoxSessionName;
        private TextBox txtSessionTimeDuration;
        private Button btnSessionExitApplication;
        private Button btnRemoveSession;
        private Button btnCreateSession;
        private Label cmbTimeSlot;
        private Label cmbRoomName;
        private ComboBox cmbSessionRoomName;
        private ComboBox cmbSpeakerName;
        private Label lblSpeakerName;
        private Label lblSessionName;
        private Label lblSessionForm;
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
        private TabPage tbRoomInfo;
        private Label lblRoomRequiredFieldNotice;
        private Button btnClearRoomFields;
        private Button btnRoomExitApplication;
        private TextBox txtBoxMaxCapacity;
        private TextBox txtBoxRoomID;
        private Label label9;
        private Label label10;
        private Button btnRemoveRoom;
        private Button btnCreateRoom;
        private Label label11;
        private TabPage tbSpeakerInfo;
        private Label lblShortBioOptionalNotice;
        private Label lblPastTalksOptionalNotice;
        private Label lblSpeakerRequiredFieldsNotice;
        private Button btnSpeakerExitApplication;
        private Button btnRemoveSpeaker;
        private Button btnCreateSpeaker;
        private Button btnClearSpeakerFields;
        private TextBox txtBoxShortBio;
        private TextBox txtBoxPastTalksGiven;
        private TextBox txtBoxEmail;
        private TextBox txtBoxDayOfContactPhoneNumber;
        private TextBox txtBoxPhoneNumber;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private Label lblShortBio;
        private Label lblPastTalksGiven;
        private Label lblEmail;
        private Label lblDayOfContact;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblSpeakersForm;
        private TabControl tbcSessionTracker;
        private ComboBox cmbOverviewTimeSlots;
        private Label lblOverviewRoomName;
        private Label lblOverviewTimeDuration;
        private TabPage tabPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TabPage tabAttendance;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}*/