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
            tabAttendance = new TabPage();
            txtBeginningCount = new TextBox();
            txtMiddleCount = new TextBox();
            cmbAttendanceRoomName = new ComboBox();
            cmbAttendanceSessionNames = new ComboBox();
            btnSaveCount = new Button();
            txtEndingCount = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblSessionAttendance = new Label();
            lblOverviewBeginningCount = new Label();
            lblOverviewBCount = new Label();
            lblOverviewMCount = new Label();
            lblOverviewMiddleCount = new Label();
            lblOverviewECount = new Label();
            lblOverviewEndingCount = new Label();
            tbOverview.SuspendLayout();
            tbSessionInfo.SuspendLayout();
            tbTimeSlotInfo.SuspendLayout();
            tbRoomInfo.SuspendLayout();
            tbSpeakerInfo.SuspendLayout();
            tbcSessionTracker.SuspendLayout();
            tabAttendance.SuspendLayout();
            SuspendLayout();
            // 
            // tbOverview
            // 
            tbOverview.Controls.Add(lblOverviewECount);
            tbOverview.Controls.Add(lblOverviewEndingCount);
            tbOverview.Controls.Add(lblOverviewMCount);
            tbOverview.Controls.Add(lblOverviewMiddleCount);
            tbOverview.Controls.Add(lblOverviewBCount);
            tbOverview.Controls.Add(lblOverviewBeginningCount);
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
            tbOverview.Location = new Point(4, 24);
            tbOverview.Margin = new Padding(3, 2, 3, 2);
            tbOverview.Name = "tbOverview";
            tbOverview.Size = new Size(522, 370);
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
            lblOverviewRoomName.Location = new Point(9, 260);
            lblOverviewRoomName.Name = "lblOverviewRoomName";
            lblOverviewRoomName.Size = new Size(186, 30);
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
            lblOverviewTimeDuration.Location = new Point(9, 212);
            lblOverviewTimeDuration.Name = "lblOverviewTimeDuration";
            lblOverviewTimeDuration.Size = new Size(186, 30);
            lblOverviewTimeDuration.TabIndex = 46;
            lblOverviewTimeDuration.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbOverviewTimeSlots
            // 
            cmbOverviewTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverviewTimeSlots.FormattingEnabled = true;
            cmbOverviewTimeSlots.Location = new Point(9, 165);
            cmbOverviewTimeSlots.Name = "cmbOverviewTimeSlots";
            cmbOverviewTimeSlots.Size = new Size(186, 23);
            cmbOverviewTimeSlots.TabIndex = 45;
            cmbOverviewTimeSlots.SelectionChangeCommitted += cmbOverviewTimeSlots_SelectionChangeCommitted;
            // 
            // btnOverviewExitApplication
            // 
            btnOverviewExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOverviewExitApplication.Location = new Point(9, 336);
            btnOverviewExitApplication.Margin = new Padding(3, 2, 3, 2);
            btnOverviewExitApplication.Name = "btnOverviewExitApplication";
            btnOverviewExitApplication.Size = new Size(186, 30);
            btnOverviewExitApplication.TabIndex = 44;
            btnOverviewExitApplication.Text = "Exit Application";
            btnOverviewExitApplication.UseVisualStyleBackColor = true;
            btnOverviewExitApplication.Click += btnOverviewExitApplication_Click;
            // 
            // btnGoToNewSession
            // 
            btnGoToNewSession.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoToNewSession.Location = new Point(318, 338);
            btnGoToNewSession.Margin = new Padding(3, 2, 3, 2);
            btnGoToNewSession.Name = "btnGoToNewSession";
            btnGoToNewSession.Size = new Size(186, 30);
            btnGoToNewSession.TabIndex = 43;
            btnGoToNewSession.Text = "New Session";
            btnGoToNewSession.UseVisualStyleBackColor = true;
            btnGoToNewSession.Click += btnGoToNewSession_Click;
            // 
            // btnGoToSpeakerForm
            // 
            btnGoToSpeakerForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoToSpeakerForm.Location = new Point(318, 302);
            btnGoToSpeakerForm.Margin = new Padding(3, 2, 3, 2);
            btnGoToSpeakerForm.Name = "btnGoToSpeakerForm";
            btnGoToSpeakerForm.Size = new Size(186, 30);
            btnGoToSpeakerForm.TabIndex = 42;
            btnGoToSpeakerForm.Text = "New Speaker";
            btnGoToSpeakerForm.UseVisualStyleBackColor = true;
            btnGoToSpeakerForm.Click += btnGoToSpeakerForm_Click;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRoomID.Location = new Point(9, 239);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(74, 21);
            lblRoomID.TabIndex = 40;
            lblRoomID.Text = "Room ID:";
            // 
            // lblSessionTimeDuration
            // 
            lblSessionTimeDuration.AutoSize = true;
            lblSessionTimeDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionTimeDuration.Location = new Point(9, 191);
            lblSessionTimeDuration.Name = "lblSessionTimeDuration";
            lblSessionTimeDuration.Size = new Size(74, 21);
            lblSessionTimeDuration.TabIndex = 38;
            lblSessionTimeDuration.Text = "Duration:";
            // 
            // lblOverviewTimeSlot
            // 
            lblOverviewTimeSlot.AutoSize = true;
            lblOverviewTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewTimeSlot.Location = new Point(9, 141);
            lblOverviewTimeSlot.Name = "lblOverviewTimeSlot";
            lblOverviewTimeSlot.Size = new Size(78, 21);
            lblOverviewTimeSlot.TabIndex = 34;
            lblOverviewTimeSlot.Text = "Time Slot:";
            // 
            // cmbOverviewSessionNames
            // 
            cmbOverviewSessionNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverviewSessionNames.FormattingEnabled = true;
            cmbOverviewSessionNames.Location = new Point(9, 116);
            cmbOverviewSessionNames.Margin = new Padding(3, 2, 3, 2);
            cmbOverviewSessionNames.Name = "cmbOverviewSessionNames";
            cmbOverviewSessionNames.Size = new Size(186, 23);
            cmbOverviewSessionNames.TabIndex = 30;
            cmbOverviewSessionNames.SelectionChangeCommitted += cmbOverviewSession_SelectionChangeCommitted;
            // 
            // lblSessionSpeakerName
            // 
            lblSessionSpeakerName.AutoSize = true;
            lblSessionSpeakerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionSpeakerName.Location = new Point(9, 92);
            lblSessionSpeakerName.Name = "lblSessionSpeakerName";
            lblSessionSpeakerName.Size = new Size(66, 21);
            lblSessionSpeakerName.TabIndex = 29;
            lblSessionSpeakerName.Text = "Session:";
            // 
            // cmbOverviewSpeakerName
            // 
            cmbOverviewSpeakerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverviewSpeakerName.FormattingEnabled = true;
            cmbOverviewSpeakerName.Location = new Point(9, 67);
            cmbOverviewSpeakerName.Margin = new Padding(3, 2, 3, 2);
            cmbOverviewSpeakerName.Name = "cmbOverviewSpeakerName";
            cmbOverviewSpeakerName.Size = new Size(186, 23);
            cmbOverviewSpeakerName.TabIndex = 28;
            cmbOverviewSpeakerName.SelectionChangeCommitted += cmbOverviewSpeakerName_SelectionChangeCommitted;
            // 
            // lblOverviewSpeakerName
            // 
            lblOverviewSpeakerName.AutoSize = true;
            lblOverviewSpeakerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewSpeakerName.Location = new Point(9, 44);
            lblOverviewSpeakerName.Name = "lblOverviewSpeakerName";
            lblOverviewSpeakerName.Size = new Size(115, 21);
            lblOverviewSpeakerName.TabIndex = 27;
            lblOverviewSpeakerName.Text = "Speaker Name:";
            // 
            // lblOverviewForm
            // 
            lblOverviewForm.AutoSize = true;
            lblOverviewForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewForm.Location = new Point(163, 0);
            lblOverviewForm.Name = "lblOverviewForm";
            lblOverviewForm.Size = new Size(175, 32);
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
            tbSessionInfo.Location = new Point(4, 24);
            tbSessionInfo.Margin = new Padding(3, 2, 3, 2);
            tbSessionInfo.Name = "tbSessionInfo";
            tbSessionInfo.Size = new Size(522, 370);
            tbSessionInfo.TabIndex = 3;
            tbSessionInfo.Text = "Session Info";
            tbSessionInfo.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTimeSlot
            // 
            btnRemoveTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveTimeSlot.Location = new Point(312, 333);
            btnRemoveTimeSlot.Margin = new Padding(3, 2, 3, 2);
            btnRemoveTimeSlot.Name = "btnRemoveTimeSlot";
            btnRemoveTimeSlot.Size = new Size(186, 30);
            btnRemoveTimeSlot.TabIndex = 42;
            btnRemoveTimeSlot.Text = "Remove Time Slot";
            btnRemoveTimeSlot.UseVisualStyleBackColor = true;
            // 
            // btnClearSessionFields
            // 
            btnClearSessionFields.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearSessionFields.Location = new Point(312, 231);
            btnClearSessionFields.Margin = new Padding(3, 2, 3, 2);
            btnClearSessionFields.Name = "btnClearSessionFields";
            btnClearSessionFields.Size = new Size(186, 30);
            btnClearSessionFields.TabIndex = 41;
            btnClearSessionFields.Text = "Clear Fields";
            btnClearSessionFields.UseVisualStyleBackColor = true;
            btnClearSessionFields.Click += btnClearSessionFields_Click;
            // 
            // cmbSessionTimeSlots
            // 
            cmbSessionTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSessionTimeSlots.FormattingEnabled = true;
            cmbSessionTimeSlots.Location = new Point(9, 208);
            cmbSessionTimeSlots.Name = "cmbSessionTimeSlots";
            cmbSessionTimeSlots.Size = new Size(186, 23);
            cmbSessionTimeSlots.TabIndex = 39;
            // 
            // txtBoxSessionName
            // 
            txtBoxSessionName.Location = new Point(9, 90);
            txtBoxSessionName.Name = "txtBoxSessionName";
            txtBoxSessionName.Size = new Size(186, 23);
            txtBoxSessionName.TabIndex = 38;
            txtBoxSessionName.KeyPress += txtBoxSessionName_KeyPress;
            // 
            // btnSessionExitApplication
            // 
            btnSessionExitApplication.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSessionExitApplication.Location = new Point(9, 333);
            btnSessionExitApplication.Margin = new Padding(3, 2, 3, 2);
            btnSessionExitApplication.Name = "btnSessionExitApplication";
            btnSessionExitApplication.Size = new Size(186, 30);
            btnSessionExitApplication.TabIndex = 37;
            btnSessionExitApplication.Text = "Exit Application";
            btnSessionExitApplication.UseVisualStyleBackColor = true;
            btnSessionExitApplication.Click += btnSessionExitApplication_Click;
            // 
            // btnRemoveSession
            // 
            btnRemoveSession.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveSession.Location = new Point(312, 299);
            btnRemoveSession.Margin = new Padding(3, 2, 3, 2);
            btnRemoveSession.Name = "btnRemoveSession";
            btnRemoveSession.Size = new Size(186, 30);
            btnRemoveSession.TabIndex = 36;
            btnRemoveSession.Text = "Remove Session";
            btnRemoveSession.UseVisualStyleBackColor = true;
            btnRemoveSession.Click += btnRemoveSession_Click;
            // 
            // btnCreateSession
            // 
            btnCreateSession.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSession.Location = new Point(312, 265);
            btnCreateSession.Margin = new Padding(3, 2, 3, 2);
            btnCreateSession.Name = "btnCreateSession";
            btnCreateSession.Size = new Size(186, 30);
            btnCreateSession.TabIndex = 35;
            btnCreateSession.Text = "Create Session";
            btnCreateSession.UseVisualStyleBackColor = true;
            btnCreateSession.Click += btnCreateSession_Click;
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
            cmbSpeakerName.SelectedIndexChanged += cmbSpeakerName_SelectedIndexChanged;
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
            tbTimeSlotInfo.Location = new Point(4, 24);
            tbTimeSlotInfo.Margin = new Padding(3, 2, 3, 2);
            tbTimeSlotInfo.Name = "tbTimeSlotInfo";
            tbTimeSlotInfo.Size = new Size(522, 370);
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
            btnTimeSlotExitApplication.Size = new Size(186, 30);
            btnTimeSlotExitApplication.TabIndex = 38;
            btnTimeSlotExitApplication.Text = "Exit Application";
            btnTimeSlotExitApplication.UseVisualStyleBackColor = true;
            btnTimeSlotExitApplication.Click += btnTimeSlotExitApplication_Click;
            // 
            // btnCreateTimeSlot
            // 
            btnCreateTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTimeSlot.Location = new Point(312, 335);
            btnCreateTimeSlot.Margin = new Padding(3, 2, 3, 2);
            btnCreateTimeSlot.Name = "btnCreateTimeSlot";
            btnCreateTimeSlot.Size = new Size(186, 30);
            btnCreateTimeSlot.TabIndex = 31;
            btnCreateTimeSlot.Text = "Create Time Slot";
            btnCreateTimeSlot.UseVisualStyleBackColor = true;
            btnCreateTimeSlot.Click += btnCreateTimeSlot_Click;
            // 
            // btnClearTimeSlotFields
            // 
            btnClearTimeSlotFields.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearTimeSlotFields.Location = new Point(312, 301);
            btnClearTimeSlotFields.Margin = new Padding(3, 2, 3, 2);
            btnClearTimeSlotFields.Name = "btnClearTimeSlotFields";
            btnClearTimeSlotFields.Size = new Size(186, 30);
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
            dpSessionDate.Format = DateTimePickerFormat.Short;
            dpSessionDate.Location = new Point(3, 224);
            dpSessionDate.Margin = new Padding(3, 2, 3, 2);
            dpSessionDate.Name = "dpSessionDate";
            dpSessionDate.Size = new Size(219, 23);
            dpSessionDate.TabIndex = 28;
            dpSessionDate.Value = new DateTime(2023, 4, 14, 0, 0, 0, 0);
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
            tbRoomInfo.Location = new Point(4, 24);
            tbRoomInfo.Margin = new Padding(3, 2, 3, 2);
            tbRoomInfo.Name = "tbRoomInfo";
            tbRoomInfo.Padding = new Padding(3, 2, 3, 2);
            tbRoomInfo.Size = new Size(522, 370);
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
            btnRoomExitApplication.Location = new Point(9, 337);
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
            txtBoxMaxCapacity.KeyPress += txtBoxMaxCapacity_KeyPress;
            // 
            // txtBoxRoomID
            // 
            txtBoxRoomID.Location = new Point(9, 74);
            txtBoxRoomID.Margin = new Padding(3, 2, 3, 2);
            txtBoxRoomID.Name = "txtBoxRoomID";
            txtBoxRoomID.Size = new Size(186, 23);
            txtBoxRoomID.TabIndex = 22;
            txtBoxRoomID.KeyPress += txtBoxRoomID_KeyPress;
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
            tbSpeakerInfo.Location = new Point(4, 24);
            tbSpeakerInfo.Margin = new Padding(3, 2, 3, 2);
            tbSpeakerInfo.Name = "tbSpeakerInfo";
            tbSpeakerInfo.Padding = new Padding(3, 2, 3, 2);
            tbSpeakerInfo.Size = new Size(522, 370);
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
            txtBoxShortBio.KeyPress += txtBoxShortBio_KeyPress;
            // 
            // txtBoxPastTalksGiven
            // 
            txtBoxPastTalksGiven.Location = new Point(316, 168);
            txtBoxPastTalksGiven.Margin = new Padding(3, 2, 3, 2);
            txtBoxPastTalksGiven.Multiline = true;
            txtBoxPastTalksGiven.Name = "txtBoxPastTalksGiven";
            txtBoxPastTalksGiven.Size = new Size(186, 75);
            txtBoxPastTalksGiven.TabIndex = 12;
            txtBoxPastTalksGiven.KeyPress += txtBoxPastTalksGiven_KeyPress;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(6, 202);
            txtBoxEmail.Margin = new Padding(3, 2, 3, 2);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(186, 23);
            txtBoxEmail.TabIndex = 9;
            txtBoxEmail.KeyPress += txtBoxEmail_KeyPress;
            // 
            // txtBoxDayOfContactPhoneNumber
            // 
            txtBoxDayOfContactPhoneNumber.Location = new Point(316, 117);
            txtBoxDayOfContactPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtBoxDayOfContactPhoneNumber.Name = "txtBoxDayOfContactPhoneNumber";
            txtBoxDayOfContactPhoneNumber.Size = new Size(186, 23);
            txtBoxDayOfContactPhoneNumber.TabIndex = 7;
            txtBoxDayOfContactPhoneNumber.KeyPress += txtBoxDayOfContactPhoneNumber_KeyPress;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(316, 62);
            txtBoxPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(186, 23);
            txtBoxPhoneNumber.TabIndex = 6;
            txtBoxPhoneNumber.KeyPress += txtBoxPhoneNumber_KeyPress;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(6, 151);
            txtBoxLastName.Margin = new Padding(3, 2, 3, 2);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(186, 23);
            txtBoxLastName.TabIndex = 4;
            txtBoxLastName.KeyPress += txtBoxLastName_KeyPress;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(6, 96);
            txtBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(186, 23);
            txtBoxFirstName.TabIndex = 2;
            txtBoxFirstName.KeyPress += txtBoxFirstName_KeyPress;
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
            // tbcSessionTracker
            // 
            tbcSessionTracker.Controls.Add(tbSpeakerInfo);
            tbcSessionTracker.Controls.Add(tbRoomInfo);
            tbcSessionTracker.Controls.Add(tbTimeSlotInfo);
            tbcSessionTracker.Controls.Add(tbSessionInfo);
            tbcSessionTracker.Controls.Add(tabAttendance);
            tbcSessionTracker.Controls.Add(tbOverview);
            tbcSessionTracker.Location = new Point(1, 0);
            tbcSessionTracker.Margin = new Padding(3, 2, 3, 2);
            tbcSessionTracker.Name = "tbcSessionTracker";
            tbcSessionTracker.SelectedIndex = 0;
            tbcSessionTracker.Size = new Size(530, 398);
            tbcSessionTracker.TabIndex = 2;
            tbcSessionTracker.Click += tbcSessionTracker_Click;
            // 
            // tabAttendance
            // 
            tabAttendance.Controls.Add(txtBeginningCount);
            tabAttendance.Controls.Add(txtMiddleCount);
            tabAttendance.Controls.Add(cmbAttendanceRoomName);
            tabAttendance.Controls.Add(cmbAttendanceSessionNames);
            tabAttendance.Controls.Add(btnSaveCount);
            tabAttendance.Controls.Add(txtEndingCount);
            tabAttendance.Controls.Add(label5);
            tabAttendance.Controls.Add(label4);
            tabAttendance.Controls.Add(label3);
            tabAttendance.Controls.Add(label2);
            tabAttendance.Controls.Add(lblSessionAttendance);
            tabAttendance.Location = new Point(4, 24);
            tabAttendance.Margin = new Padding(3, 2, 3, 2);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Size = new Size(522, 370);
            tabAttendance.TabIndex = 5;
            tabAttendance.Text = "Attendance";
            tabAttendance.UseVisualStyleBackColor = true;
            // 
            // txtBeginningCount
            // 
            txtBeginningCount.Location = new Point(32, 176);
            txtBeginningCount.Margin = new Padding(3, 2, 3, 2);
            txtBeginningCount.Name = "txtBeginningCount";
            txtBeginningCount.Size = new Size(110, 23);
            txtBeginningCount.TabIndex = 14;
            // 
            // txtMiddleCount
            // 
            txtMiddleCount.Location = new Point(32, 225);
            txtMiddleCount.Margin = new Padding(3, 2, 3, 2);
            txtMiddleCount.Name = "txtMiddleCount";
            txtMiddleCount.Size = new Size(110, 23);
            txtMiddleCount.TabIndex = 13;
            // 
            // cmbAttendanceRoomName
            // 
            cmbAttendanceRoomName.FormattingEnabled = true;
            cmbAttendanceRoomName.Location = new Point(32, 120);
            cmbAttendanceRoomName.Name = "cmbAttendanceRoomName";
            cmbAttendanceRoomName.Size = new Size(121, 23);
            cmbAttendanceRoomName.TabIndex = 12;
            // 
            // cmbAttendanceSessionNames
            // 
            cmbAttendanceSessionNames.FormattingEnabled = true;
            cmbAttendanceSessionNames.Location = new Point(32, 64);
            cmbAttendanceSessionNames.Name = "cmbAttendanceSessionNames";
            cmbAttendanceSessionNames.Size = new Size(121, 23);
            cmbAttendanceSessionNames.TabIndex = 11;
            // 
            // btnSaveCount
            // 
            btnSaveCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveCount.Location = new Point(370, 326);
            btnSaveCount.Margin = new Padding(3, 2, 3, 2);
            btnSaveCount.Name = "btnSaveCount";
            btnSaveCount.Size = new Size(100, 28);
            btnSaveCount.TabIndex = 10;
            btnSaveCount.Text = "Save Count";
            btnSaveCount.UseVisualStyleBackColor = true;
            btnSaveCount.Click += btnSaveCount_Click;
            // 
            // txtEndingCount
            // 
            txtEndingCount.Location = new Point(32, 273);
            txtEndingCount.Margin = new Padding(3, 2, 3, 2);
            txtEndingCount.Name = "txtEndingCount";
            txtEndingCount.Size = new Size(110, 23);
            txtEndingCount.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 94);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 4;
            label5.Text = "Room:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 153);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 3;
            label4.Text = "Beginning Count:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 201);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 2;
            label3.Text = "Middle Count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 250);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "End Count:";
            // 
            // lblSessionAttendance
            // 
            lblSessionAttendance.AutoSize = true;
            lblSessionAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionAttendance.Location = new Point(32, 40);
            lblSessionAttendance.Name = "lblSessionAttendance";
            lblSessionAttendance.Size = new Size(66, 21);
            lblSessionAttendance.TabIndex = 0;
            lblSessionAttendance.Text = "Session:";
            // 
            // lblOverviewBeginningCount
            // 
            lblOverviewBeginningCount.AutoSize = true;
            lblOverviewBeginningCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewBeginningCount.Location = new Point(318, 44);
            lblOverviewBeginningCount.Name = "lblOverviewBeginningCount";
            lblOverviewBeginningCount.Size = new Size(129, 21);
            lblOverviewBeginningCount.TabIndex = 48;
            lblOverviewBeginningCount.Text = "Beginning Count:";
            // 
            // lblOverviewBCount
            // 
            lblOverviewBCount.BackColor = SystemColors.Window;
            lblOverviewBCount.BorderStyle = BorderStyle.FixedSingle;
            lblOverviewBCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewBCount.ForeColor = SystemColors.ControlText;
            lblOverviewBCount.Location = new Point(318, 67);
            lblOverviewBCount.Name = "lblOverviewBCount";
            lblOverviewBCount.Size = new Size(186, 30);
            lblOverviewBCount.TabIndex = 49;
            lblOverviewBCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOverviewMCount
            // 
            lblOverviewMCount.BackColor = SystemColors.Window;
            lblOverviewMCount.BorderStyle = BorderStyle.FixedSingle;
            lblOverviewMCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewMCount.ForeColor = SystemColors.ControlText;
            lblOverviewMCount.Location = new Point(318, 120);
            lblOverviewMCount.Name = "lblOverviewMCount";
            lblOverviewMCount.Size = new Size(186, 30);
            lblOverviewMCount.TabIndex = 51;
            lblOverviewMCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOverviewMiddleCount
            // 
            lblOverviewMiddleCount.AutoSize = true;
            lblOverviewMiddleCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewMiddleCount.Location = new Point(318, 97);
            lblOverviewMiddleCount.Name = "lblOverviewMiddleCount";
            lblOverviewMiddleCount.Size = new Size(107, 21);
            lblOverviewMiddleCount.TabIndex = 50;
            lblOverviewMiddleCount.Text = "Middle Count:";
            // 
            // lblOverviewECount
            // 
            lblOverviewECount.BackColor = SystemColors.Window;
            lblOverviewECount.BorderStyle = BorderStyle.FixedSingle;
            lblOverviewECount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewECount.ForeColor = SystemColors.ControlText;
            lblOverviewECount.Location = new Point(318, 173);
            lblOverviewECount.Name = "lblOverviewECount";
            lblOverviewECount.Size = new Size(186, 30);
            lblOverviewECount.TabIndex = 53;
            lblOverviewECount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOverviewEndingCount
            // 
            lblOverviewEndingCount.AutoSize = true;
            lblOverviewEndingCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewEndingCount.Location = new Point(318, 150);
            lblOverviewEndingCount.Name = "lblOverviewEndingCount";
            lblOverviewEndingCount.Size = new Size(85, 21);
            lblOverviewEndingCount.TabIndex = 52;
            lblOverviewEndingCount.Text = "End Count:";
            // 
            // SessionTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 396);
            Controls.Add(tbcSessionTracker);
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
        private TabPage tabAttendance;
        private Button btnSaveCount;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtEndingCount;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblSessionAttendance;
        private ComboBox cmbAttendanceRoomName;
        private ComboBox cmbAttendanceSessionNames;
        private TextBox txtBeginningCount;
        private TextBox txtMiddleCount;
        private Label lblOverviewECount;
        private Label lblOverviewEndingCount;
        private Label lblOverviewMCount;
        private Label lblOverviewMiddleCount;
        private Label lblOverviewBCount;
        private Label lblOverviewBeginningCount;
    }
}*/