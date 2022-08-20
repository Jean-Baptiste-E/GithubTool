namespace EtsGitTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RepoListBox = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.FetchTab = new System.Windows.Forms.TabPage();
            this.MyOrganizationLabel = new System.Windows.Forms.Label();
            this.MyOrganizationCombobox = new System.Windows.Forms.ComboBox();
            this.GetListOfOrganizationRepositoryButton = new System.Windows.Forms.Button();
            this.GetOrgButton = new System.Windows.Forms.Button();
            this.GetListOfRepositoryButton = new System.Windows.Forms.Button();
            this.RemoveSelectedReposButton = new System.Windows.Forms.Button();
            this.ForkSelectedRepoButton = new System.Windows.Forms.Button();
            this.SearhTab = new System.Windows.Forms.TabPage();
            this.ReadmeCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentTextbox = new System.Windows.Forms.TextBox();
            this.ClearInputsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchLocationLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfForksMinLabel = new System.Windows.Forms.Label();
            this.ForkLabel = new System.Windows.Forms.Label();
            this.NumberOfForksMaxTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfForksMinTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LastUpdateDateMaxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationDateMaxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastUpdateDateMinLabel = new System.Windows.Forms.Label();
            this.CreationDateMinLabel = new System.Windows.Forms.Label();
            this.LastUpdateDateMinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationDateMinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastUpdateDateLabel = new System.Windows.Forms.Label();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.MinSizeLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.MaxSizeTextbox = new System.Windows.Forms.TextBox();
            this.MaxStarTextbox = new System.Windows.Forms.TextBox();
            this.MinStarsLabel = new System.Windows.Forms.Label();
            this.MinSizeTextbox = new System.Windows.Forms.TextBox();
            this.MinStarTextbox = new System.Windows.Forms.TextBox();
            this.StarsLabel = new System.Windows.Forms.Label();
            this.KeywordLabel = new System.Windows.Forms.Label();
            this.QueryTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfForksMaxLabel = new System.Windows.Forms.Label();
            this.LastUpdateDateMaxLabel = new System.Windows.Forms.Label();
            this.CreationDateMaxLabel = new System.Windows.Forms.Label();
            this.MaxSizeLabel = new System.Windows.Forms.Label();
            this.MaxStarsLabel = new System.Windows.Forms.Label();
            this.ValidationTab = new System.Windows.Forms.TabPage();
            this.SelectInValidRepoButton = new System.Windows.Forms.Button();
            this.SelectValidRepo = new System.Windows.Forms.Button();
            this.TargetFrameworkCombobox = new System.Windows.Forms.ComboBox();
            this.FrameworkLabel = new System.Windows.Forms.Label();
            this.ValidateOnFileNameLabel = new System.Windows.Forms.Label();
            this.ValidateOnFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ValidationResultButton = new System.Windows.Forms.Button();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ProjectPathLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SelectConfigurationFileTypeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FindFileCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.FindFileReactNativeRadioButton = new System.Windows.Forms.RadioButton();
            this.FindFileiOSRadioButton = new System.Windows.Forms.RadioButton();
            this.FindFileAndroidRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteSonarCloudExclusionFileButton = new System.Windows.Forms.Button();
            this.PushExclusionFileButton = new System.Windows.Forms.Button();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.ExtractBugsButtons = new System.Windows.Forms.Button();
            this.ExtractCodeSmellButton = new System.Windows.Forms.Button();
            this.ExtractIssuesButton = new System.Windows.Forms.Button();
            this.FinalStatusReportLabel = new System.Windows.Forms.Label();
            this.FinalStatusReportDisplayLabel = new System.Windows.Forms.Label();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.ReportStatusLabel = new System.Windows.Forms.Label();
            this.ReportStatusDisplayLabel = new System.Windows.Forms.Label();
            this.ClearReportButton = new System.Windows.Forms.Button();
            this.ComponentNumberLabel = new System.Windows.Forms.Label();
            this.ComponentNumberDisplayLabel = new System.Windows.Forms.Label();
            this.GetProjectMeasuresButton = new System.Windows.Forms.Button();
            this.GetListOfSonarCloudProjectsButton = new System.Windows.Forms.Button();
            this.CodigaTab = new System.Windows.Forms.TabPage();
            this.GetCodigaSelectedRepoAnalysis = new System.Windows.Forms.Button();
            this.GetCodigaRepoBtn = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.ClearSelectionButton = new System.Windows.Forms.Button();
            this.StopProcessButton = new System.Windows.Forms.Button();
            this.ResultsCountLabel = new System.Windows.Forms.Label();
            this.TotalItemFoundLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CopyItemAddressButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SelectedCountLabel = new System.Windows.Forms.Label();
            this.SpinnerPictureBox = new System.Windows.Forms.PictureBox();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.FetchTab.SuspendLayout();
            this.SearhTab.SuspendLayout();
            this.ValidationTab.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.ReportTab.SuspendLayout();
            this.CodigaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LoginButton.Location = new System.Drawing.Point(16, 11);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(33, 28);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "🔒";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UserNameLabel.Location = new System.Drawing.Point(55, 16);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(567, 18);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Login to use application.";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RepoListBox
            // 
            this.RepoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.RepoListBox.Font = new System.Drawing.Font("Segoe UI Emoji", 7.25F);
            this.RepoListBox.FormattingEnabled = true;
            this.RepoListBox.ItemHeight = 16;
            this.RepoListBox.Location = new System.Drawing.Point(3, 47);
            this.RepoListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepoListBox.Name = "RepoListBox";
            this.RepoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RepoListBox.Size = new System.Drawing.Size(706, 404);
            this.RepoListBox.TabIndex = 4;
            this.RepoListBox.SelectedIndexChanged += new System.EventHandler(this.RepoListBox_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.FetchTab);
            this.TabControl.Controls.Add(this.SearhTab);
            this.TabControl.Controls.Add(this.ValidationTab);
            this.TabControl.Controls.Add(this.ConfigTab);
            this.TabControl.Controls.Add(this.ReportTab);
            this.TabControl.Controls.Add(this.CodigaTab);
            this.TabControl.Enabled = false;
            this.TabControl.Location = new System.Drawing.Point(16, 47);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(297, 399);
            this.TabControl.TabIndex = 5;
            // 
            // FetchTab
            // 
            this.FetchTab.Controls.Add(this.MyOrganizationLabel);
            this.FetchTab.Controls.Add(this.MyOrganizationCombobox);
            this.FetchTab.Controls.Add(this.GetListOfOrganizationRepositoryButton);
            this.FetchTab.Controls.Add(this.GetOrgButton);
            this.FetchTab.Controls.Add(this.GetListOfRepositoryButton);
            this.FetchTab.Controls.Add(this.RemoveSelectedReposButton);
            this.FetchTab.Controls.Add(this.ForkSelectedRepoButton);
            this.FetchTab.Location = new System.Drawing.Point(4, 25);
            this.FetchTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FetchTab.Name = "FetchTab";
            this.FetchTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FetchTab.Size = new System.Drawing.Size(289, 370);
            this.FetchTab.TabIndex = 0;
            this.FetchTab.Text = "Repos";
            this.FetchTab.UseVisualStyleBackColor = true;
            // 
            // MyOrganizationLabel
            // 
            this.MyOrganizationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyOrganizationLabel.AutoSize = true;
            this.MyOrganizationLabel.Location = new System.Drawing.Point(7, 162);
            this.MyOrganizationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyOrganizationLabel.Name = "MyOrganizationLabel";
            this.MyOrganizationLabel.Size = new System.Drawing.Size(100, 17);
            this.MyOrganizationLabel.TabIndex = 18;
            this.MyOrganizationLabel.Text = "Organizations:";
            // 
            // MyOrganizationCombobox
            // 
            this.MyOrganizationCombobox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MyOrganizationCombobox.FormattingEnabled = true;
            this.MyOrganizationCombobox.Location = new System.Drawing.Point(67, 159);
            this.MyOrganizationCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.MyOrganizationCombobox.Name = "MyOrganizationCombobox";
            this.MyOrganizationCombobox.Size = new System.Drawing.Size(197, 24);
            this.MyOrganizationCombobox.TabIndex = 17;
            this.MyOrganizationCombobox.SelectedIndexChanged += new System.EventHandler(this.MyOrganizationCombobox_SelectedIndexChanged);
            // 
            // GetListOfOrganizationRepositoryButton
            // 
            this.GetListOfOrganizationRepositoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GetListOfOrganizationRepositoryButton.Enabled = false;
            this.GetListOfOrganizationRepositoryButton.Location = new System.Drawing.Point(11, 42);
            this.GetListOfOrganizationRepositoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetListOfOrganizationRepositoryButton.Name = "GetListOfOrganizationRepositoryButton";
            this.GetListOfOrganizationRepositoryButton.Size = new System.Drawing.Size(255, 28);
            this.GetListOfOrganizationRepositoryButton.TabIndex = 16;
            this.GetListOfOrganizationRepositoryButton.Text = "Get My Organization Repositories";
            this.GetListOfOrganizationRepositoryButton.UseVisualStyleBackColor = true;
            this.GetListOfOrganizationRepositoryButton.Click += new System.EventHandler(this.GetListOfOrganizationRepositoryButton_Click);
            // 
            // GetOrgButton
            // 
            this.GetOrgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GetOrgButton.Location = new System.Drawing.Point(11, 122);
            this.GetOrgButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetOrgButton.Name = "GetOrgButton";
            this.GetOrgButton.Size = new System.Drawing.Size(255, 28);
            this.GetOrgButton.TabIndex = 15;
            this.GetOrgButton.Text = "Get My Organization";
            this.GetOrgButton.UseVisualStyleBackColor = true;
            this.GetOrgButton.Click += new System.EventHandler(this.GetOrgButton_Click);
            // 
            // GetListOfRepositoryButton
            // 
            this.GetListOfRepositoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GetListOfRepositoryButton.Location = new System.Drawing.Point(11, 6);
            this.GetListOfRepositoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetListOfRepositoryButton.Name = "GetListOfRepositoryButton";
            this.GetListOfRepositoryButton.Size = new System.Drawing.Size(255, 28);
            this.GetListOfRepositoryButton.TabIndex = 14;
            this.GetListOfRepositoryButton.Text = "Get All My Repositories";
            this.GetListOfRepositoryButton.UseVisualStyleBackColor = true;
            this.GetListOfRepositoryButton.Click += new System.EventHandler(this.GetListOfRepositoryButton_Click);
            // 
            // RemoveSelectedReposButton
            // 
            this.RemoveSelectedReposButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSelectedReposButton.ForeColor = System.Drawing.Color.Maroon;
            this.RemoveSelectedReposButton.Location = new System.Drawing.Point(11, 327);
            this.RemoveSelectedReposButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveSelectedReposButton.Name = "RemoveSelectedReposButton";
            this.RemoveSelectedReposButton.Size = new System.Drawing.Size(255, 28);
            this.RemoveSelectedReposButton.TabIndex = 13;
            this.RemoveSelectedReposButton.Text = "Remove selected repos";
            this.RemoveSelectedReposButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedReposButton.Click += new System.EventHandler(this.RemoveSelectedReposButton_Click);
            // 
            // ForkSelectedRepoButton
            // 
            this.ForkSelectedRepoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ForkSelectedRepoButton.Location = new System.Drawing.Point(11, 282);
            this.ForkSelectedRepoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ForkSelectedRepoButton.Name = "ForkSelectedRepoButton";
            this.ForkSelectedRepoButton.Size = new System.Drawing.Size(255, 28);
            this.ForkSelectedRepoButton.TabIndex = 10;
            this.ForkSelectedRepoButton.Text = "Frok selected repos into remote account";
            this.ForkSelectedRepoButton.UseVisualStyleBackColor = true;
            this.ForkSelectedRepoButton.Click += new System.EventHandler(this.ForkSelectedRepoButton_Click);
            // 
            // SearhTab
            // 
            this.SearhTab.Controls.Add(this.ReadmeCheckBox);
            this.SearhTab.Controls.Add(this.DescriptionCheckBox);
            this.SearhTab.Controls.Add(this.NameCheckBox);
            this.SearhTab.Controls.Add(this.ContentLabel);
            this.SearhTab.Controls.Add(this.ContentTextbox);
            this.SearhTab.Controls.Add(this.ClearInputsButton);
            this.SearhTab.Controls.Add(this.label2);
            this.SearhTab.Controls.Add(this.SearchLocationLabel);
            this.SearhTab.Controls.Add(this.LanguageLabel);
            this.SearhTab.Controls.Add(this.LanguageTextbox);
            this.SearhTab.Controls.Add(this.NumberOfForksMinLabel);
            this.SearhTab.Controls.Add(this.ForkLabel);
            this.SearhTab.Controls.Add(this.NumberOfForksMaxTextBox);
            this.SearhTab.Controls.Add(this.NumberOfForksMinTextBox);
            this.SearhTab.Controls.Add(this.SearchButton);
            this.SearhTab.Controls.Add(this.LastUpdateDateMaxDateTimePicker);
            this.SearhTab.Controls.Add(this.CreationDateMaxDateTimePicker);
            this.SearhTab.Controls.Add(this.LastUpdateDateMinLabel);
            this.SearhTab.Controls.Add(this.CreationDateMinLabel);
            this.SearhTab.Controls.Add(this.LastUpdateDateMinDateTimePicker);
            this.SearhTab.Controls.Add(this.CreationDateMinDateTimePicker);
            this.SearhTab.Controls.Add(this.LastUpdateDateLabel);
            this.SearhTab.Controls.Add(this.CreationDateLabel);
            this.SearhTab.Controls.Add(this.MinSizeLabel);
            this.SearhTab.Controls.Add(this.SizeLabel);
            this.SearhTab.Controls.Add(this.MaxSizeTextbox);
            this.SearhTab.Controls.Add(this.MaxStarTextbox);
            this.SearhTab.Controls.Add(this.MinStarsLabel);
            this.SearhTab.Controls.Add(this.MinSizeTextbox);
            this.SearhTab.Controls.Add(this.MinStarTextbox);
            this.SearhTab.Controls.Add(this.StarsLabel);
            this.SearhTab.Controls.Add(this.KeywordLabel);
            this.SearhTab.Controls.Add(this.QueryTextbox);
            this.SearhTab.Controls.Add(this.NumberOfForksMaxLabel);
            this.SearhTab.Controls.Add(this.LastUpdateDateMaxLabel);
            this.SearhTab.Controls.Add(this.CreationDateMaxLabel);
            this.SearhTab.Controls.Add(this.MaxSizeLabel);
            this.SearhTab.Controls.Add(this.MaxStarsLabel);
            this.SearhTab.Location = new System.Drawing.Point(4, 25);
            this.SearhTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearhTab.Name = "SearhTab";
            this.SearhTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearhTab.Size = new System.Drawing.Size(289, 370);
            this.SearhTab.TabIndex = 1;
            this.SearhTab.Text = "Search";
            this.SearhTab.UseVisualStyleBackColor = true;
            // 
            // ReadmeCheckBox
            // 
            this.ReadmeCheckBox.AutoSize = true;
            this.ReadmeCheckBox.Checked = true;
            this.ReadmeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadmeCheckBox.Location = new System.Drawing.Point(293, 112);
            this.ReadmeCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReadmeCheckBox.Name = "ReadmeCheckBox";
            this.ReadmeCheckBox.Size = new System.Drawing.Size(78, 21);
            this.ReadmeCheckBox.TabIndex = 37;
            this.ReadmeCheckBox.Text = "readme";
            this.ReadmeCheckBox.UseVisualStyleBackColor = true;
            // 
            // DescriptionCheckBox
            // 
            this.DescriptionCheckBox.AutoSize = true;
            this.DescriptionCheckBox.Checked = true;
            this.DescriptionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DescriptionCheckBox.Location = new System.Drawing.Point(201, 112);
            this.DescriptionCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionCheckBox.Name = "DescriptionCheckBox";
            this.DescriptionCheckBox.Size = new System.Drawing.Size(60, 21);
            this.DescriptionCheckBox.TabIndex = 36;
            this.DescriptionCheckBox.Text = "desc";
            this.DescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Checked = true;
            this.NameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NameCheckBox.Location = new System.Drawing.Point(112, 112);
            this.NameCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(65, 21);
            this.NameCheckBox.TabIndex = 35;
            this.NameCheckBox.Text = "name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(11, 84);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(57, 17);
            this.ContentLabel.TabIndex = 33;
            this.ContentLabel.Text = "Content";
            // 
            // ContentTextbox
            // 
            this.ContentTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentTextbox.Location = new System.Drawing.Point(112, 80);
            this.ContentTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentTextbox.Name = "ContentTextbox";
            this.ContentTextbox.Size = new System.Drawing.Size(262, 22);
            this.ContentTextbox.TabIndex = 2;
            // 
            // ClearInputsButton
            // 
            this.ClearInputsButton.Location = new System.Drawing.Point(232, 295);
            this.ClearInputsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearInputsButton.Name = "ClearInputsButton";
            this.ClearInputsButton.Size = new System.Drawing.Size(143, 28);
            this.ClearInputsButton.TabIndex = 17;
            this.ClearInputsButton.Text = "Clear All";
            this.ClearInputsButton.UseVisualStyleBackColor = true;
            this.ClearInputsButton.Click += new System.EventHandler(this.ClearInputsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(60, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Five or less criteria can be used in search.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchLocationLabel
            // 
            this.SearchLocationLabel.AutoSize = true;
            this.SearchLocationLabel.Location = new System.Drawing.Point(11, 114);
            this.SearchLocationLabel.Name = "SearchLocationLabel";
            this.SearchLocationLabel.Size = new System.Drawing.Size(91, 17);
            this.SearchLocationLabel.TabIndex = 34;
            this.SearchLocationLabel.Text = "Search Area:";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(11, 54);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(76, 17);
            this.LanguageLabel.TabIndex = 29;
            this.LanguageLabel.Text = "Language:";
            // 
            // LanguageTextbox
            // 
            this.LanguageTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LanguageTextbox.Location = new System.Drawing.Point(112, 49);
            this.LanguageTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LanguageTextbox.Name = "LanguageTextbox";
            this.LanguageTextbox.Size = new System.Drawing.Size(262, 22);
            this.LanguageTextbox.TabIndex = 1;
            // 
            // NumberOfForksMinLabel
            // 
            this.NumberOfForksMinLabel.AutoSize = true;
            this.NumberOfForksMinLabel.Location = new System.Drawing.Point(112, 207);
            this.NumberOfForksMinLabel.Name = "NumberOfForksMinLabel";
            this.NumberOfForksMinLabel.Size = new System.Drawing.Size(30, 17);
            this.NumberOfForksMinLabel.TabIndex = 27;
            this.NumberOfForksMinLabel.Text = "Min";
            // 
            // ForkLabel
            // 
            this.ForkLabel.AutoSize = true;
            this.ForkLabel.Location = new System.Drawing.Point(11, 207);
            this.ForkLabel.Name = "ForkLabel";
            this.ForkLabel.Size = new System.Drawing.Size(47, 17);
            this.ForkLabel.TabIndex = 25;
            this.ForkLabel.Text = "Forks:";
            // 
            // NumberOfForksMaxTextBox
            // 
            this.NumberOfForksMaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfForksMaxTextBox.Location = new System.Drawing.Point(280, 202);
            this.NumberOfForksMaxTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberOfForksMaxTextBox.Name = "NumberOfForksMaxTextBox";
            this.NumberOfForksMaxTextBox.Size = new System.Drawing.Size(94, 22);
            this.NumberOfForksMaxTextBox.TabIndex = 8;
            this.NumberOfForksMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            // 
            // NumberOfForksMinTextBox
            // 
            this.NumberOfForksMinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfForksMinTextBox.Location = new System.Drawing.Point(145, 202);
            this.NumberOfForksMinTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberOfForksMinTextBox.Name = "NumberOfForksMinTextBox";
            this.NumberOfForksMinTextBox.Size = new System.Drawing.Size(94, 22);
            this.NumberOfForksMinTextBox.TabIndex = 7;
            this.NumberOfForksMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(15, 295);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 28);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LastUpdateDateMaxDateTimePicker
            // 
            this.LastUpdateDateMaxDateTimePicker.Location = new System.Drawing.Point(280, 265);
            this.LastUpdateDateMaxDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastUpdateDateMaxDateTimePicker.Name = "LastUpdateDateMaxDateTimePicker";
            this.LastUpdateDateMaxDateTimePicker.Size = new System.Drawing.Size(93, 22);
            this.LastUpdateDateMaxDateTimePicker.TabIndex = 12;
            this.LastUpdateDateMaxDateTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // CreationDateMaxDateTimePicker
            // 
            this.CreationDateMaxDateTimePicker.Location = new System.Drawing.Point(280, 234);
            this.CreationDateMaxDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreationDateMaxDateTimePicker.Name = "CreationDateMaxDateTimePicker";
            this.CreationDateMaxDateTimePicker.Size = new System.Drawing.Size(93, 22);
            this.CreationDateMaxDateTimePicker.TabIndex = 10;
            this.CreationDateMaxDateTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // LastUpdateDateMinLabel
            // 
            this.LastUpdateDateMinLabel.AutoSize = true;
            this.LastUpdateDateMinLabel.Location = new System.Drawing.Point(112, 270);
            this.LastUpdateDateMinLabel.Name = "LastUpdateDateMinLabel";
            this.LastUpdateDateMinLabel.Size = new System.Drawing.Size(30, 17);
            this.LastUpdateDateMinLabel.TabIndex = 18;
            this.LastUpdateDateMinLabel.Text = "Min";
            // 
            // CreationDateMinLabel
            // 
            this.CreationDateMinLabel.AutoSize = true;
            this.CreationDateMinLabel.Location = new System.Drawing.Point(112, 239);
            this.CreationDateMinLabel.Name = "CreationDateMinLabel";
            this.CreationDateMinLabel.Size = new System.Drawing.Size(30, 17);
            this.CreationDateMinLabel.TabIndex = 18;
            this.CreationDateMinLabel.Text = "Min";
            // 
            // LastUpdateDateMinDateTimePicker
            // 
            this.LastUpdateDateMinDateTimePicker.Location = new System.Drawing.Point(145, 265);
            this.LastUpdateDateMinDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastUpdateDateMinDateTimePicker.Name = "LastUpdateDateMinDateTimePicker";
            this.LastUpdateDateMinDateTimePicker.Size = new System.Drawing.Size(93, 22);
            this.LastUpdateDateMinDateTimePicker.TabIndex = 11;
            this.LastUpdateDateMinDateTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // CreationDateMinDateTimePicker
            // 
            this.CreationDateMinDateTimePicker.Location = new System.Drawing.Point(145, 234);
            this.CreationDateMinDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreationDateMinDateTimePicker.Name = "CreationDateMinDateTimePicker";
            this.CreationDateMinDateTimePicker.Size = new System.Drawing.Size(93, 22);
            this.CreationDateMinDateTimePicker.TabIndex = 9;
            this.CreationDateMinDateTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // LastUpdateDateLabel
            // 
            this.LastUpdateDateLabel.AutoSize = true;
            this.LastUpdateDateLabel.Location = new System.Drawing.Point(11, 268);
            this.LastUpdateDateLabel.Name = "LastUpdateDateLabel";
            this.LastUpdateDateLabel.Size = new System.Drawing.Size(92, 17);
            this.LastUpdateDateLabel.TabIndex = 16;
            this.LastUpdateDateLabel.Text = "Update Date:";
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Location = new System.Drawing.Point(11, 238);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(88, 17);
            this.CreationDateLabel.TabIndex = 15;
            this.CreationDateLabel.Text = "Create Date:";
            // 
            // MinSizeLabel
            // 
            this.MinSizeLabel.AutoSize = true;
            this.MinSizeLabel.Location = new System.Drawing.Point(112, 176);
            this.MinSizeLabel.Name = "MinSizeLabel";
            this.MinSizeLabel.Size = new System.Drawing.Size(30, 17);
            this.MinSizeLabel.TabIndex = 9;
            this.MinSizeLabel.Text = "Min";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(11, 176);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(68, 17);
            this.SizeLabel.TabIndex = 6;
            this.SizeLabel.Text = "Size: (kb)";
            // 
            // MaxSizeTextbox
            // 
            this.MaxSizeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxSizeTextbox.Location = new System.Drawing.Point(280, 171);
            this.MaxSizeTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxSizeTextbox.Name = "MaxSizeTextbox";
            this.MaxSizeTextbox.Size = new System.Drawing.Size(94, 22);
            this.MaxSizeTextbox.TabIndex = 6;
            this.MaxSizeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            // 
            // MaxStarTextbox
            // 
            this.MaxStarTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxStarTextbox.Location = new System.Drawing.Point(280, 140);
            this.MaxStarTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxStarTextbox.Name = "MaxStarTextbox";
            this.MaxStarTextbox.Size = new System.Drawing.Size(94, 22);
            this.MaxStarTextbox.TabIndex = 4;
            this.MaxStarTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            // 
            // MinStarsLabel
            // 
            this.MinStarsLabel.AutoSize = true;
            this.MinStarsLabel.Location = new System.Drawing.Point(112, 145);
            this.MinStarsLabel.Name = "MinStarsLabel";
            this.MinStarsLabel.Size = new System.Drawing.Size(30, 17);
            this.MinStarsLabel.TabIndex = 4;
            this.MinStarsLabel.Text = "Min";
            // 
            // MinSizeTextbox
            // 
            this.MinSizeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinSizeTextbox.Location = new System.Drawing.Point(145, 171);
            this.MinSizeTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinSizeTextbox.Name = "MinSizeTextbox";
            this.MinSizeTextbox.Size = new System.Drawing.Size(94, 22);
            this.MinSizeTextbox.TabIndex = 5;
            this.MinSizeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            // 
            // MinStarTextbox
            // 
            this.MinStarTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinStarTextbox.Location = new System.Drawing.Point(145, 140);
            this.MinStarTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinStarTextbox.Name = "MinStarTextbox";
            this.MinStarTextbox.Size = new System.Drawing.Size(94, 22);
            this.MinStarTextbox.TabIndex = 3;
            this.MinStarTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            // 
            // StarsLabel
            // 
            this.StarsLabel.AutoSize = true;
            this.StarsLabel.Location = new System.Drawing.Point(11, 145);
            this.StarsLabel.Name = "StarsLabel";
            this.StarsLabel.Size = new System.Drawing.Size(45, 17);
            this.StarsLabel.TabIndex = 2;
            this.StarsLabel.Text = "Stars:";
            // 
            // KeywordLabel
            // 
            this.KeywordLabel.AutoSize = true;
            this.KeywordLabel.Location = new System.Drawing.Point(11, 25);
            this.KeywordLabel.Name = "KeywordLabel";
            this.KeywordLabel.Size = new System.Drawing.Size(66, 17);
            this.KeywordLabel.TabIndex = 1;
            this.KeywordLabel.Text = "Keyword:";
            // 
            // QueryTextbox
            // 
            this.QueryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryTextbox.Location = new System.Drawing.Point(112, 18);
            this.QueryTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryTextbox.Name = "QueryTextbox";
            this.QueryTextbox.Size = new System.Drawing.Size(262, 22);
            this.QueryTextbox.TabIndex = 0;
            // 
            // NumberOfForksMaxLabel
            // 
            this.NumberOfForksMaxLabel.AutoSize = true;
            this.NumberOfForksMaxLabel.Location = new System.Drawing.Point(245, 207);
            this.NumberOfForksMaxLabel.Name = "NumberOfForksMaxLabel";
            this.NumberOfForksMaxLabel.Size = new System.Drawing.Size(33, 17);
            this.NumberOfForksMaxLabel.TabIndex = 26;
            this.NumberOfForksMaxLabel.Text = "Max";
            // 
            // LastUpdateDateMaxLabel
            // 
            this.LastUpdateDateMaxLabel.AutoSize = true;
            this.LastUpdateDateMaxLabel.Location = new System.Drawing.Point(245, 270);
            this.LastUpdateDateMaxLabel.Name = "LastUpdateDateMaxLabel";
            this.LastUpdateDateMaxLabel.Size = new System.Drawing.Size(33, 17);
            this.LastUpdateDateMaxLabel.TabIndex = 20;
            this.LastUpdateDateMaxLabel.Text = "Max";
            // 
            // CreationDateMaxLabel
            // 
            this.CreationDateMaxLabel.AutoSize = true;
            this.CreationDateMaxLabel.Location = new System.Drawing.Point(245, 239);
            this.CreationDateMaxLabel.Name = "CreationDateMaxLabel";
            this.CreationDateMaxLabel.Size = new System.Drawing.Size(33, 17);
            this.CreationDateMaxLabel.TabIndex = 20;
            this.CreationDateMaxLabel.Text = "Max";
            // 
            // MaxSizeLabel
            // 
            this.MaxSizeLabel.AutoSize = true;
            this.MaxSizeLabel.Location = new System.Drawing.Point(245, 176);
            this.MaxSizeLabel.Name = "MaxSizeLabel";
            this.MaxSizeLabel.Size = new System.Drawing.Size(33, 17);
            this.MaxSizeLabel.TabIndex = 8;
            this.MaxSizeLabel.Text = "Max";
            // 
            // MaxStarsLabel
            // 
            this.MaxStarsLabel.AutoSize = true;
            this.MaxStarsLabel.Location = new System.Drawing.Point(245, 145);
            this.MaxStarsLabel.Name = "MaxStarsLabel";
            this.MaxStarsLabel.Size = new System.Drawing.Size(33, 17);
            this.MaxStarsLabel.TabIndex = 4;
            this.MaxStarsLabel.Text = "Max";
            // 
            // ValidationTab
            // 
            this.ValidationTab.Controls.Add(this.SelectInValidRepoButton);
            this.ValidationTab.Controls.Add(this.SelectValidRepo);
            this.ValidationTab.Controls.Add(this.TargetFrameworkCombobox);
            this.ValidationTab.Controls.Add(this.FrameworkLabel);
            this.ValidationTab.Controls.Add(this.ValidateOnFileNameLabel);
            this.ValidationTab.Controls.Add(this.ValidateOnFileNameTextBox);
            this.ValidationTab.Controls.Add(this.ValidationResultButton);
            this.ValidationTab.Location = new System.Drawing.Point(4, 25);
            this.ValidationTab.Margin = new System.Windows.Forms.Padding(4);
            this.ValidationTab.Name = "ValidationTab";
            this.ValidationTab.Size = new System.Drawing.Size(289, 370);
            this.ValidationTab.TabIndex = 3;
            this.ValidationTab.Text = "Validation";
            this.ValidationTab.UseVisualStyleBackColor = true;
            // 
            // SelectInValidRepoButton
            // 
            this.SelectInValidRepoButton.Location = new System.Drawing.Point(9, 330);
            this.SelectInValidRepoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectInValidRepoButton.Name = "SelectInValidRepoButton";
            this.SelectInValidRepoButton.Size = new System.Drawing.Size(369, 28);
            this.SelectInValidRepoButton.TabIndex = 29;
            this.SelectInValidRepoButton.Text = "Select Invalid Repositories";
            this.SelectInValidRepoButton.UseVisualStyleBackColor = true;
            this.SelectInValidRepoButton.Click += new System.EventHandler(this.SelectInValidRepoButton_Click);
            // 
            // SelectValidRepo
            // 
            this.SelectValidRepo.Location = new System.Drawing.Point(9, 297);
            this.SelectValidRepo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectValidRepo.Name = "SelectValidRepo";
            this.SelectValidRepo.Size = new System.Drawing.Size(369, 28);
            this.SelectValidRepo.TabIndex = 28;
            this.SelectValidRepo.Text = "Select Valid Repositories";
            this.SelectValidRepo.UseVisualStyleBackColor = true;
            this.SelectValidRepo.Click += new System.EventHandler(this.SelectValidRepo_Click);
            // 
            // TargetFrameworkCombobox
            // 
            this.TargetFrameworkCombobox.FormattingEnabled = true;
            this.TargetFrameworkCombobox.Items.AddRange(new object[] { "Android Native", "iOS Native", "ReactNative", "Other" });
            this.TargetFrameworkCombobox.Location = new System.Drawing.Point(156, 14);
            this.TargetFrameworkCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.TargetFrameworkCombobox.Name = "TargetFrameworkCombobox";
            this.TargetFrameworkCombobox.Size = new System.Drawing.Size(221, 24);
            this.TargetFrameworkCombobox.TabIndex = 27;
            this.TargetFrameworkCombobox.SelectedValueChanged += new System.EventHandler(this.TargetFrameworkCombobox_SelectedValueChanged);
            // 
            // FrameworkLabel
            // 
            this.FrameworkLabel.AutoSize = true;
            this.FrameworkLabel.Location = new System.Drawing.Point(9, 16);
            this.FrameworkLabel.Name = "FrameworkLabel";
            this.FrameworkLabel.Size = new System.Drawing.Size(127, 17);
            this.FrameworkLabel.TabIndex = 26;
            this.FrameworkLabel.Text = "Target Framework:";
            // 
            // ValidateOnFileNameLabel
            // 
            this.ValidateOnFileNameLabel.AutoSize = true;
            this.ValidateOnFileNameLabel.Location = new System.Drawing.Point(9, 49);
            this.ValidateOnFileNameLabel.Name = "ValidateOnFileNameLabel";
            this.ValidateOnFileNameLabel.Size = new System.Drawing.Size(71, 17);
            this.ValidateOnFileNameLabel.TabIndex = 25;
            this.ValidateOnFileNameLabel.Text = "FileName:";
            // 
            // ValidateOnFileNameTextBox
            // 
            this.ValidateOnFileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidateOnFileNameTextBox.Location = new System.Drawing.Point(156, 47);
            this.ValidateOnFileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidateOnFileNameTextBox.Name = "ValidateOnFileNameTextBox";
            this.ValidateOnFileNameTextBox.Size = new System.Drawing.Size(222, 22);
            this.ValidateOnFileNameTextBox.TabIndex = 24;
            // 
            // ValidationResultButton
            // 
            this.ValidationResultButton.Location = new System.Drawing.Point(9, 261);
            this.ValidationResultButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidationResultButton.Name = "ValidationResultButton";
            this.ValidationResultButton.Size = new System.Drawing.Size(369, 28);
            this.ValidationResultButton.TabIndex = 17;
            this.ValidationResultButton.Text = "Validate Result";
            this.ValidationResultButton.UseVisualStyleBackColor = true;
            this.ValidationResultButton.Click += new System.EventHandler(this.ValidationResultButton_Click);
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.ResetButton);
            this.ConfigTab.Controls.Add(this.ProjectPathLabel);
            this.ConfigTab.Controls.Add(this.PathLabel);
            this.ConfigTab.Controls.Add(this.SelectConfigurationFileTypeLabel);
            this.ConfigTab.Controls.Add(this.FileNameLabel);
            this.ConfigTab.Controls.Add(this.FileNameTextBox);
            this.ConfigTab.Controls.Add(this.FindFileCustomRadioButton);
            this.ConfigTab.Controls.Add(this.FindFileReactNativeRadioButton);
            this.ConfigTab.Controls.Add(this.FindFileiOSRadioButton);
            this.ConfigTab.Controls.Add(this.FindFileAndroidRadioButton);
            this.ConfigTab.Controls.Add(this.DeleteSonarCloudExclusionFileButton);
            this.ConfigTab.Controls.Add(this.PushExclusionFileButton);
            this.ConfigTab.Controls.Add(this.FindFileButton);
            this.ConfigTab.Location = new System.Drawing.Point(4, 25);
            this.ConfigTab.Margin = new System.Windows.Forms.Padding(4);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(4);
            this.ConfigTab.Size = new System.Drawing.Size(289, 370);
            this.ConfigTab.TabIndex = 2;
            this.ConfigTab.Text = "Sonar";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 331);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(376, 28);
            this.ResetButton.TabIndex = 25;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ProjectPathLabel
            // 
            this.ProjectPathLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProjectPathLabel.Location = new System.Drawing.Point(12, 241);
            this.ProjectPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectPathLabel.Name = "ProjectPathLabel";
            this.ProjectPathLabel.Size = new System.Drawing.Size(303, 23);
            this.ProjectPathLabel.TabIndex = 24;
            this.ProjectPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 219);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(71, 17);
            this.PathLabel.TabIndex = 24;
            this.PathLabel.Text = "File Path: ";
            // 
            // SelectConfigurationFileTypeLabel
            // 
            this.SelectConfigurationFileTypeLabel.AutoSize = true;
            this.SelectConfigurationFileTypeLabel.Enabled = false;
            this.SelectConfigurationFileTypeLabel.Location = new System.Drawing.Point(12, 14);
            this.SelectConfigurationFileTypeLabel.Name = "SelectConfigurationFileTypeLabel";
            this.SelectConfigurationFileTypeLabel.Size = new System.Drawing.Size(265, 17);
            this.SelectConfigurationFileTypeLabel.TabIndex = 23;
            this.SelectConfigurationFileTypeLabel.Text = "Select a framework or type the file name:";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Enabled = false;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 158);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(71, 17);
            this.FileNameLabel.TabIndex = 23;
            this.FileNameLabel.Text = "FileName:";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.Enabled = false;
            this.FileNameTextBox.Location = new System.Drawing.Point(113, 155);
            this.FileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(274, 22);
            this.FileNameTextBox.TabIndex = 22;
            // 
            // FindFileCustomRadioButton
            // 
            this.FindFileCustomRadioButton.AutoSize = true;
            this.FindFileCustomRadioButton.Location = new System.Drawing.Point(12, 124);
            this.FindFileCustomRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindFileCustomRadioButton.Name = "FindFileCustomRadioButton";
            this.FindFileCustomRadioButton.Size = new System.Drawing.Size(102, 21);
            this.FindFileCustomRadioButton.TabIndex = 21;
            this.FindFileCustomRadioButton.Text = "Custom File";
            this.FindFileCustomRadioButton.UseVisualStyleBackColor = true;
            this.FindFileCustomRadioButton.CheckedChanged += new System.EventHandler(this.FindFileCustomRadioButton_CheckedChanged);
            // 
            // FindFileReactNativeRadioButton
            // 
            this.FindFileReactNativeRadioButton.AutoSize = true;
            this.FindFileReactNativeRadioButton.Location = new System.Drawing.Point(12, 96);
            this.FindFileReactNativeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindFileReactNativeRadioButton.Name = "FindFileReactNativeRadioButton";
            this.FindFileReactNativeRadioButton.Size = new System.Drawing.Size(106, 21);
            this.FindFileReactNativeRadioButton.TabIndex = 20;
            this.FindFileReactNativeRadioButton.Text = "ReactNative";
            this.FindFileReactNativeRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindFileiOSRadioButton
            // 
            this.FindFileiOSRadioButton.AutoSize = true;
            this.FindFileiOSRadioButton.Location = new System.Drawing.Point(12, 68);
            this.FindFileiOSRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindFileiOSRadioButton.Name = "FindFileiOSRadioButton";
            this.FindFileiOSRadioButton.Size = new System.Drawing.Size(171, 21);
            this.FindFileiOSRadioButton.TabIndex = 19;
            this.FindFileiOSRadioButton.Text = "iOS Native SDK (Swift)";
            this.FindFileiOSRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindFileAndroidRadioButton
            // 
            this.FindFileAndroidRadioButton.AutoSize = true;
            this.FindFileAndroidRadioButton.Checked = true;
            this.FindFileAndroidRadioButton.Location = new System.Drawing.Point(12, 39);
            this.FindFileAndroidRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindFileAndroidRadioButton.Name = "FindFileAndroidRadioButton";
            this.FindFileAndroidRadioButton.Size = new System.Drawing.Size(203, 21);
            this.FindFileAndroidRadioButton.TabIndex = 12;
            this.FindFileAndroidRadioButton.TabStop = true;
            this.FindFileAndroidRadioButton.Text = "Android Native SDK (Kotlin)";
            this.FindFileAndroidRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSonarCloudExclusionFileButton
            // 
            this.DeleteSonarCloudExclusionFileButton.Location = new System.Drawing.Point(12, 299);
            this.DeleteSonarCloudExclusionFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteSonarCloudExclusionFileButton.Name = "DeleteSonarCloudExclusionFileButton";
            this.DeleteSonarCloudExclusionFileButton.Size = new System.Drawing.Size(376, 28);
            this.DeleteSonarCloudExclusionFileButton.TabIndex = 17;
            this.DeleteSonarCloudExclusionFileButton.Text = "Delete SonarCloud Configuration File";
            this.DeleteSonarCloudExclusionFileButton.UseVisualStyleBackColor = true;
            this.DeleteSonarCloudExclusionFileButton.Click += new System.EventHandler(this.DeleteSonarCloudExclusionFileButton_Click);
            // 
            // PushExclusionFileButton
            // 
            this.PushExclusionFileButton.Location = new System.Drawing.Point(12, 268);
            this.PushExclusionFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PushExclusionFileButton.Name = "PushExclusionFileButton";
            this.PushExclusionFileButton.Size = new System.Drawing.Size(376, 28);
            this.PushExclusionFileButton.TabIndex = 17;
            this.PushExclusionFileButton.Text = "Push SonarCloud Configuration File";
            this.PushExclusionFileButton.UseVisualStyleBackColor = true;
            this.PushExclusionFileButton.Click += new System.EventHandler(this.PushExclusionFileButton_Click);
            // 
            // FindFileButton
            // 
            this.FindFileButton.Location = new System.Drawing.Point(12, 187);
            this.FindFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(376, 28);
            this.FindFileButton.TabIndex = 16;
            this.FindFileButton.Text = "Find Path";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.ExtractBugsButtons);
            this.ReportTab.Controls.Add(this.ExtractCodeSmellButton);
            this.ReportTab.Controls.Add(this.ExtractIssuesButton);
            this.ReportTab.Controls.Add(this.FinalStatusReportLabel);
            this.ReportTab.Controls.Add(this.FinalStatusReportDisplayLabel);
            this.ReportTab.Controls.Add(this.GenerateReportButton);
            this.ReportTab.Controls.Add(this.ReportStatusLabel);
            this.ReportTab.Controls.Add(this.ReportStatusDisplayLabel);
            this.ReportTab.Controls.Add(this.ClearReportButton);
            this.ReportTab.Controls.Add(this.ComponentNumberLabel);
            this.ReportTab.Controls.Add(this.ComponentNumberDisplayLabel);
            this.ReportTab.Controls.Add(this.GetProjectMeasuresButton);
            this.ReportTab.Controls.Add(this.GetListOfSonarCloudProjectsButton);
            this.ReportTab.Location = new System.Drawing.Point(4, 25);
            this.ReportTab.Margin = new System.Windows.Forms.Padding(4);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Size = new System.Drawing.Size(289, 370);
            this.ReportTab.TabIndex = 4;
            this.ReportTab.Text = "Report";
            this.ReportTab.UseVisualStyleBackColor = true;
            // 
            // ExtractBugsButtons
            // 
            this.ExtractBugsButtons.Location = new System.Drawing.Point(185, 294);
            this.ExtractBugsButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtractBugsButtons.Name = "ExtractBugsButtons";
            this.ExtractBugsButtons.Size = new System.Drawing.Size(95, 28);
            this.ExtractBugsButtons.TabIndex = 34;
            this.ExtractBugsButtons.Text = "Bug";
            this.ExtractBugsButtons.UseVisualStyleBackColor = true;
            this.ExtractBugsButtons.Click += new System.EventHandler(this.ExtractBugsButtons_Click);
            // 
            // ExtractCodeSmellButton
            // 
            this.ExtractCodeSmellButton.Location = new System.Drawing.Point(289, 294);
            this.ExtractCodeSmellButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtractCodeSmellButton.Name = "ExtractCodeSmellButton";
            this.ExtractCodeSmellButton.Size = new System.Drawing.Size(95, 28);
            this.ExtractCodeSmellButton.TabIndex = 33;
            this.ExtractCodeSmellButton.Text = "Code Smell";
            this.ExtractCodeSmellButton.UseVisualStyleBackColor = true;
            this.ExtractCodeSmellButton.Click += new System.EventHandler(this.ExtractCodeSmellButton_Click);
            // 
            // ExtractIssuesButton
            // 
            this.ExtractIssuesButton.Location = new System.Drawing.Point(9, 294);
            this.ExtractIssuesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtractIssuesButton.Name = "ExtractIssuesButton";
            this.ExtractIssuesButton.Size = new System.Drawing.Size(167, 28);
            this.ExtractIssuesButton.TabIndex = 33;
            this.ExtractIssuesButton.Text = "Extract Issues";
            this.ExtractIssuesButton.UseVisualStyleBackColor = true;
            this.ExtractIssuesButton.Click += new System.EventHandler(this.ExtractAndroidIssues_Click);
            // 
            // FinalStatusReportLabel
            // 
            this.FinalStatusReportLabel.AutoSize = true;
            this.FinalStatusReportLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FinalStatusReportLabel.Location = new System.Drawing.Point(8, 249);
            this.FinalStatusReportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalStatusReportLabel.MaximumSize = new System.Drawing.Size(373, 0);
            this.FinalStatusReportLabel.Name = "FinalStatusReportLabel";
            this.FinalStatusReportLabel.Size = new System.Drawing.Size(0, 17);
            this.FinalStatusReportLabel.TabIndex = 31;
            this.FinalStatusReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FinalStatusReportDisplayLabel
            // 
            this.FinalStatusReportDisplayLabel.AutoSize = true;
            this.FinalStatusReportDisplayLabel.Location = new System.Drawing.Point(8, 225);
            this.FinalStatusReportDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalStatusReportDisplayLabel.Name = "FinalStatusReportDisplayLabel";
            this.FinalStatusReportDisplayLabel.Size = new System.Drawing.Size(133, 17);
            this.FinalStatusReportDisplayLabel.TabIndex = 32;
            this.FinalStatusReportDisplayLabel.Text = "Final Report Status:";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(8, 190);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(376, 28);
            this.GenerateReportButton.TabIndex = 30;
            this.GenerateReportButton.Text = "Filter completed projects and generate report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // ReportStatusLabel
            // 
            this.ReportStatusLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ReportStatusLabel.Location = new System.Drawing.Point(8, 159);
            this.ReportStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportStatusLabel.Name = "ReportStatusLabel";
            this.ReportStatusLabel.Size = new System.Drawing.Size(376, 23);
            this.ReportStatusLabel.TabIndex = 28;
            this.ReportStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportStatusDisplayLabel
            // 
            this.ReportStatusDisplayLabel.AutoSize = true;
            this.ReportStatusDisplayLabel.Location = new System.Drawing.Point(8, 135);
            this.ReportStatusDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportStatusDisplayLabel.Name = "ReportStatusDisplayLabel";
            this.ReportStatusDisplayLabel.Size = new System.Drawing.Size(111, 17);
            this.ReportStatusDisplayLabel.TabIndex = 29;
            this.ReportStatusDisplayLabel.Text = "Measure Status:";
            // 
            // ClearReportButton
            // 
            this.ClearReportButton.ForeColor = System.Drawing.Color.Maroon;
            this.ClearReportButton.Location = new System.Drawing.Point(9, 330);
            this.ClearReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearReportButton.Name = "ClearReportButton";
            this.ClearReportButton.Size = new System.Drawing.Size(376, 28);
            this.ClearReportButton.TabIndex = 27;
            this.ClearReportButton.Text = "Clear and Reset";
            this.ClearReportButton.UseVisualStyleBackColor = true;
            this.ClearReportButton.Click += new System.EventHandler(this.ClearReportButton_Click);
            // 
            // ComponentNumberLabel
            // 
            this.ComponentNumberLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ComponentNumberLabel.Location = new System.Drawing.Point(8, 66);
            this.ComponentNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComponentNumberLabel.Name = "ComponentNumberLabel";
            this.ComponentNumberLabel.Size = new System.Drawing.Size(376, 23);
            this.ComponentNumberLabel.TabIndex = 25;
            this.ComponentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComponentNumberDisplayLabel
            // 
            this.ComponentNumberDisplayLabel.AutoSize = true;
            this.ComponentNumberDisplayLabel.Location = new System.Drawing.Point(8, 46);
            this.ComponentNumberDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComponentNumberDisplayLabel.Name = "ComponentNumberDisplayLabel";
            this.ComponentNumberDisplayLabel.Size = new System.Drawing.Size(132, 17);
            this.ComponentNumberDisplayLabel.TabIndex = 26;
            this.ComponentNumberDisplayLabel.Text = "Number of projects:";
            // 
            // GetProjectMeasuresButton
            // 
            this.GetProjectMeasuresButton.Location = new System.Drawing.Point(8, 100);
            this.GetProjectMeasuresButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetProjectMeasuresButton.Name = "GetProjectMeasuresButton";
            this.GetProjectMeasuresButton.Size = new System.Drawing.Size(376, 28);
            this.GetProjectMeasuresButton.TabIndex = 19;
            this.GetProjectMeasuresButton.Text = "Get project measures for the selected projects";
            this.GetProjectMeasuresButton.UseVisualStyleBackColor = true;
            this.GetProjectMeasuresButton.Click += new System.EventHandler(this.GetProjectMeasuresButton_Click);
            // 
            // GetListOfSonarCloudProjectsButton
            // 
            this.GetListOfSonarCloudProjectsButton.Location = new System.Drawing.Point(8, 10);
            this.GetListOfSonarCloudProjectsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetListOfSonarCloudProjectsButton.Name = "GetListOfSonarCloudProjectsButton";
            this.GetListOfSonarCloudProjectsButton.Size = new System.Drawing.Size(376, 28);
            this.GetListOfSonarCloudProjectsButton.TabIndex = 18;
            this.GetListOfSonarCloudProjectsButton.Text = "Get projects from SonarCloud";
            this.GetListOfSonarCloudProjectsButton.UseVisualStyleBackColor = true;
            this.GetListOfSonarCloudProjectsButton.Click += new System.EventHandler(this.GetListOfSonarCloudProjectsButton_Click);
            // 
            // CodigaTab
            // 
            this.CodigaTab.Controls.Add(this.GetCodigaSelectedRepoAnalysis);
            this.CodigaTab.Controls.Add(this.GetCodigaRepoBtn);
            this.CodigaTab.Location = new System.Drawing.Point(4, 25);
            this.CodigaTab.Margin = new System.Windows.Forms.Padding(4);
            this.CodigaTab.Name = "CodigaTab";
            this.CodigaTab.Padding = new System.Windows.Forms.Padding(4);
            this.CodigaTab.Size = new System.Drawing.Size(289, 370);
            this.CodigaTab.TabIndex = 5;
            this.CodigaTab.Text = "Codiga";
            this.CodigaTab.UseVisualStyleBackColor = true;
            // 
            // GetCodigaSelectedRepoAnalysis
            // 
            this.GetCodigaSelectedRepoAnalysis.Location = new System.Drawing.Point(18, 66);
            this.GetCodigaSelectedRepoAnalysis.Name = "GetCodigaSelectedRepoAnalysis";
            this.GetCodigaSelectedRepoAnalysis.Size = new System.Drawing.Size(255, 34);
            this.GetCodigaSelectedRepoAnalysis.TabIndex = 1;
            this.GetCodigaSelectedRepoAnalysis.Text = "Get selected repo analysis\r\n";
            this.GetCodigaSelectedRepoAnalysis.UseVisualStyleBackColor = true;
            this.GetCodigaSelectedRepoAnalysis.Click += new System.EventHandler(this.GetCodigaSelectedRepoAnalysis_Click);
            // 
            // GetCodigaRepoBtn
            // 
            this.GetCodigaRepoBtn.Location = new System.Drawing.Point(18, 18);
            this.GetCodigaRepoBtn.Name = "GetCodigaRepoBtn";
            this.GetCodigaRepoBtn.Size = new System.Drawing.Size(256, 32);
            this.GetCodigaRepoBtn.TabIndex = 0;
            this.GetCodigaRepoBtn.Text = "Get Codiga repositories\r\n\r\n";
            this.GetCodigaRepoBtn.UseVisualStyleBackColor = true;
            this.GetCodigaRepoBtn.Click += new System.EventHandler(this.GetCodigaRepoBtn_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllButton.Enabled = false;
            this.SelectAllButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.SelectAllButton.Location = new System.Drawing.Point(606, 10);
            this.SelectAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(33, 31);
            this.SelectAllButton.TabIndex = 12;
            this.SelectAllButton.Text = "";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // ClearSelectionButton
            // 
            this.ClearSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSelectionButton.Enabled = false;
            this.ClearSelectionButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.ClearSelectionButton.Location = new System.Drawing.Point(570, 10);
            this.ClearSelectionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearSelectionButton.Name = "ClearSelectionButton";
            this.ClearSelectionButton.Size = new System.Drawing.Size(33, 31);
            this.ClearSelectionButton.TabIndex = 11;
            this.ClearSelectionButton.Text = "";
            this.ClearSelectionButton.UseVisualStyleBackColor = true;
            this.ClearSelectionButton.Click += new System.EventHandler(this.ClearSelectionButton_Click);
            // 
            // StopProcessButton
            // 
            this.StopProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopProcessButton.Enabled = false;
            this.StopProcessButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopProcessButton.Location = new System.Drawing.Point(642, 10);
            this.StopProcessButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopProcessButton.Name = "StopProcessButton";
            this.StopProcessButton.Size = new System.Drawing.Size(33, 31);
            this.StopProcessButton.TabIndex = 9;
            this.StopProcessButton.Text = "";
            this.StopProcessButton.UseVisualStyleBackColor = true;
            this.StopProcessButton.Click += new System.EventHandler(this.StopProcessButton_Click);
            // 
            // ResultsCountLabel
            // 
            this.ResultsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultsCountLabel.Location = new System.Drawing.Point(1, 478);
            this.ResultsCountLabel.Name = "ResultsCountLabel";
            this.ResultsCountLabel.Size = new System.Drawing.Size(207, 16);
            this.ResultsCountLabel.TabIndex = 6;
            this.ResultsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalItemFoundLabel
            // 
            this.TotalItemFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalItemFoundLabel.Location = new System.Drawing.Point(503, 478);
            this.TotalItemFoundLabel.Name = "TotalItemFoundLabel";
            this.TotalItemFoundLabel.Size = new System.Drawing.Size(203, 16);
            this.TotalItemFoundLabel.TabIndex = 9;
            this.TotalItemFoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TabControl);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.UserNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.LoginButton);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CopyItemAddressButton);
            this.splitContainer1.Panel2.Controls.Add(this.FindButton);
            this.splitContainer1.Panel2.Controls.Add(this.SearchTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.LoadButton);
            this.splitContainer1.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.SelectedCountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.RepoListBox);
            this.splitContainer1.Panel2.Controls.Add(this.SpinnerPictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.ClearListButton);
            this.splitContainer1.Panel2.Controls.Add(this.TotalItemFoundLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ClearSelectionButton);
            this.splitContainer1.Panel2.Controls.Add(this.SelectAllButton);
            this.splitContainer1.Panel2.Controls.Add(this.ResultsCountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.StopProcessButton);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 502);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.Image = global::EtsGitTools.Properties.Resources.SonarCloudH;
            this.pictureBox3.Location = new System.Drawing.Point(70, 453);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::EtsGitTools.Properties.Resources.GitHub_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(239, 453);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = global::EtsGitTools.Properties.Resources.ETS;
            this.pictureBox2.Location = new System.Drawing.Point(3, 453);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // CopyItemAddressButton
            // 
            this.CopyItemAddressButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyItemAddressButton.Enabled = false;
            this.CopyItemAddressButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.CopyItemAddressButton.Location = new System.Drawing.Point(455, 10);
            this.CopyItemAddressButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CopyItemAddressButton.Name = "CopyItemAddressButton";
            this.CopyItemAddressButton.Size = new System.Drawing.Size(33, 31);
            this.CopyItemAddressButton.TabIndex = 18;
            this.CopyItemAddressButton.Text = "";
            this.CopyItemAddressButton.UseVisualStyleBackColor = true;
            this.CopyItemAddressButton.Click += new System.EventHandler(this.CopyItemAddressButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Enabled = false;
            this.FindButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.FindButton.Location = new System.Drawing.Point(279, 10);
            this.FindButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(33, 31);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 12);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(269, 22);
            this.SearchTextBox.TabIndex = 16;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Enabled = false;
            this.LoadButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.LoadButton.Location = new System.Drawing.Point(492, 10);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(33, 31);
            this.LoadButton.TabIndex = 15;
            this.LoadButton.Text = "";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F);
            this.SaveButton.Location = new System.Drawing.Point(531, 10);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(33, 31);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SelectedCountLabel
            // 
            this.SelectedCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SelectedCountLabel.Location = new System.Drawing.Point(256, 478);
            this.SelectedCountLabel.Name = "SelectedCountLabel";
            this.SelectedCountLabel.Size = new System.Drawing.Size(207, 16);
            this.SelectedCountLabel.TabIndex = 13;
            this.SelectedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpinnerPictureBox
            // 
            this.SpinnerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpinnerPictureBox.Image = global::EtsGitTools.Properties.Resources.spinner;
            this.SpinnerPictureBox.Location = new System.Drawing.Point(419, 12);
            this.SpinnerPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpinnerPictureBox.Name = "SpinnerPictureBox";
            this.SpinnerPictureBox.Size = new System.Drawing.Size(33, 25);
            this.SpinnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpinnerPictureBox.TabIndex = 11;
            this.SpinnerPictureBox.TabStop = false;
            this.SpinnerPictureBox.Visible = false;
            // 
            // ClearListButton
            // 
            this.ClearListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearListButton.Enabled = false;
            this.ClearListButton.Location = new System.Drawing.Point(678, 10);
            this.ClearListButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(33, 31);
            this.ClearListButton.TabIndex = 4;
            this.ClearListButton.Text = "🗑";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 502);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1075, 529);
            this.Name = "MainForm";
            this.Text = "EtsGitTools";
            this.TabControl.ResumeLayout(false);
            this.FetchTab.ResumeLayout(false);
            this.FetchTab.PerformLayout();
            this.SearhTab.ResumeLayout(false);
            this.SearhTab.PerformLayout();
            this.ValidationTab.ResumeLayout(false);
            this.ValidationTab.PerformLayout();
            this.ConfigTab.ResumeLayout(false);
            this.ConfigTab.PerformLayout();
            this.ReportTab.ResumeLayout(false);
            this.ReportTab.PerformLayout();
            this.CodigaTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button GetCodigaRepoBtn;
        private System.Windows.Forms.Button GetCodigaSelectedRepoAnalysis;

        private System.Windows.Forms.TabPage CodigaTab;

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.ListBox RepoListBox;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage FetchTab;
        private System.Windows.Forms.TabPage SearhTab;
        private System.Windows.Forms.Label ResultsCountLabel;
        private System.Windows.Forms.Button StopProcessButton;
        private System.Windows.Forms.Button ClearSelectionButton;
        private System.Windows.Forms.Button ForkSelectedRepoButton;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button RemoveSelectedReposButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MaxSizeLabel;
        private System.Windows.Forms.Label MinSizeLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox MaxStarTextbox;
        private System.Windows.Forms.Label MaxStarsLabel;
        private System.Windows.Forms.Label MinStarsLabel;
        private System.Windows.Forms.TextBox MinStarTextbox;
        private System.Windows.Forms.Label StarsLabel;
        private System.Windows.Forms.Label KeywordLabel;
        private System.Windows.Forms.TextBox QueryTextbox;
        private System.Windows.Forms.TextBox MaxSizeTextbox;
        private System.Windows.Forms.TextBox MinSizeTextbox;
        private System.Windows.Forms.Label LastUpdateDateLabel;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label LastUpdateDateMaxLabel;
        private System.Windows.Forms.Label CreationDateMaxLabel;
        private System.Windows.Forms.DateTimePicker LastUpdateDateMaxDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreationDateMaxDateTimePicker;
        private System.Windows.Forms.Label LastUpdateDateMinLabel;
        private System.Windows.Forms.Label CreationDateMinLabel;
        private System.Windows.Forms.DateTimePicker LastUpdateDateMinDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreationDateMinDateTimePicker;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.TextBox LanguageTextbox;
        private System.Windows.Forms.Label NumberOfForksMaxLabel;
        private System.Windows.Forms.Label NumberOfForksMinLabel;
        private System.Windows.Forms.Label ForkLabel;
        private System.Windows.Forms.TextBox NumberOfForksMaxTextBox;
        private System.Windows.Forms.TextBox NumberOfForksMinTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearInputsButton;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox ContentTextbox;
        private System.Windows.Forms.Label SearchLocationLabel;
        private System.Windows.Forms.Label TotalItemFoundLabel;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.CheckBox ReadmeCheckBox;
        private System.Windows.Forms.CheckBox DescriptionCheckBox;
        private System.Windows.Forms.Button GetListOfRepositoryButton;
        private System.Windows.Forms.PictureBox SpinnerPictureBox;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.RadioButton FindFileCustomRadioButton;
        private System.Windows.Forms.RadioButton FindFileReactNativeRadioButton;
        private System.Windows.Forms.RadioButton FindFileiOSRadioButton;
        private System.Windows.Forms.RadioButton FindFileAndroidRadioButton;
        private System.Windows.Forms.Button PushExclusionFileButton;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.Label ProjectPathLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label SelectConfigurationFileTypeLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage ValidationTab;
        private System.Windows.Forms.Label ValidateOnFileNameLabel;
        private System.Windows.Forms.TextBox ValidateOnFileNameTextBox;
        private System.Windows.Forms.Button ValidationResultButton;
        private System.Windows.Forms.ComboBox TargetFrameworkCombobox;
        private System.Windows.Forms.Label FrameworkLabel;
        private System.Windows.Forms.Button SelectValidRepo;
        private System.Windows.Forms.Button GetOrgButton;
        private System.Windows.Forms.Button GetListOfOrganizationRepositoryButton;
        private System.Windows.Forms.Label MyOrganizationLabel;
        private System.Windows.Forms.ComboBox MyOrganizationCombobox;
        private System.Windows.Forms.Button SelectInValidRepoButton;
        private System.Windows.Forms.Label SelectedCountLabel;
        private System.Windows.Forms.Button DeleteSonarCloudExclusionFileButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TabPage ReportTab;
        private System.Windows.Forms.Button GetListOfSonarCloudProjectsButton;
        private System.Windows.Forms.Button GetProjectMeasuresButton;
        private System.Windows.Forms.Label ComponentNumberLabel;
        private System.Windows.Forms.Label ComponentNumberDisplayLabel;
        private System.Windows.Forms.Button ClearReportButton;
        private System.Windows.Forms.Label ReportStatusLabel;
        private System.Windows.Forms.Label ReportStatusDisplayLabel;
        private System.Windows.Forms.Label FinalStatusReportLabel;
        private System.Windows.Forms.Label FinalStatusReportDisplayLabel;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Button CopyItemAddressButton;
        private System.Windows.Forms.Button ExtractCodeSmellButton;
        private System.Windows.Forms.Button ExtractIssuesButton;
        private System.Windows.Forms.Button ExtractBugsButtons;
    }
}

