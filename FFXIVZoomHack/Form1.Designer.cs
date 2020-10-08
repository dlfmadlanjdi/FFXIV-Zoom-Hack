namespace FFXIVZoomHack
{
    partial class Form1
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
            this._autoApplyCheckbox = new System.Windows.Forms.CheckBox();
            this._zoomSettingsBox = new System.Windows.Forms.GroupBox();
            this._zoomMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this._zoomMaxDefaultButton = new System.Windows.Forms.Button();
            this._zoomMaxLabel = new System.Windows.Forms.Label();
            this._fovUpDown = new System.Windows.Forms.NumericUpDown();
            this._zoomMinUpDown = new System.Windows.Forms.NumericUpDown();
            this._fovDefaultButton = new System.Windows.Forms.Button();
            this._zoomMinDefaultButton = new System.Windows.Forms.Button();
            this._fovLabel = new System.Windows.Forms.Label();
            this._zoomMinLabel = new System.Windows.Forms.Label();
            this._processListBox = new System.Windows.Forms.GroupBox();
            this._gotoProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._processList = new System.Windows.Forms.ComboBox();
            this._updateOffsetsTextbox = new System.Windows.Forms.TextBox();
            this._updateOffsetsButton = new System.Windows.Forms.Button();
            this._updateLocationDefault = new System.Windows.Forms.Button();
            this._zoomSettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._zoomMaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fovUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._zoomMinUpDown)).BeginInit();
            this._processListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _autoApplyCheckbox
            // 
            this._autoApplyCheckbox.AutoSize = true;
            this._autoApplyCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._autoApplyCheckbox.Location = new System.Drawing.Point(7, 23);
            this._autoApplyCheckbox.Name = "_autoApplyCheckbox";
            this._autoApplyCheckbox.Size = new System.Drawing.Size(219, 24);
            this._autoApplyCheckbox.TabIndex = 0;
            this._autoApplyCheckbox.Text = "Automatically apply on load";
            this._autoApplyCheckbox.UseVisualStyleBackColor = true;
            // 
            // _zoomSettingsBox
            // 
            this._zoomSettingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._zoomSettingsBox.Controls.Add(this._zoomMaxUpDown);
            this._zoomSettingsBox.Controls.Add(this._zoomMaxDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._zoomMaxLabel);
            this._zoomSettingsBox.Controls.Add(this._fovUpDown);
            this._zoomSettingsBox.Controls.Add(this._zoomMinUpDown);
            this._zoomSettingsBox.Controls.Add(this._fovDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._zoomMinDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._fovLabel);
            this._zoomSettingsBox.Controls.Add(this._zoomMinLabel);
            this._zoomSettingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._zoomSettingsBox.Location = new System.Drawing.Point(15, 138);
            this._zoomSettingsBox.Name = "_zoomSettingsBox";
            this._zoomSettingsBox.Size = new System.Drawing.Size(553, 190);
            this._zoomSettingsBox.TabIndex = 1;
            this._zoomSettingsBox.TabStop = false;
            this._zoomSettingsBox.Text = "Zoom Settings";
            // 
            // _zoomMaxUpDown
            // 
            this._zoomMaxUpDown.DecimalPlaces = 2;
            this._zoomMaxUpDown.Location = new System.Drawing.Point(289, 77);
            this._zoomMaxUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._zoomMaxUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this._zoomMaxUpDown.Name = "_zoomMaxUpDown";
            this._zoomMaxUpDown.Size = new System.Drawing.Size(251, 26);
            this._zoomMaxUpDown.TabIndex = 10;
            this._zoomMaxUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // _zoomMaxDefaultButton
            // 
            this._zoomMaxDefaultButton.Location = new System.Drawing.Point(427, 42);
            this._zoomMaxDefaultButton.Name = "_zoomMaxDefaultButton";
            this._zoomMaxDefaultButton.Size = new System.Drawing.Size(112, 24);
            this._zoomMaxDefaultButton.TabIndex = 4;
            this._zoomMaxDefaultButton.Text = "Default";
            this._zoomMaxDefaultButton.UseVisualStyleBackColor = true;
            this._zoomMaxDefaultButton.Click += new System.EventHandler(this._zoomMaxDefaultButton_Click);
            // 
            // _zoomMaxLabel
            // 
            this._zoomMaxLabel.AutoSize = true;
            this._zoomMaxLabel.Location = new System.Drawing.Point(284, 42);
            this._zoomMaxLabel.Name = "_zoomMaxLabel";
            this._zoomMaxLabel.Size = new System.Drawing.Size(83, 20);
            this._zoomMaxLabel.TabIndex = 8;
            this._zoomMaxLabel.Text = "Zoom Max";
            // 
            // _fovUpDown
            // 
            this._fovUpDown.DecimalPlaces = 2;
            this._fovUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._fovUpDown.Location = new System.Drawing.Point(11, 157);
            this._fovUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            this._fovUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._fovUpDown.Name = "_fovUpDown";
            this._fovUpDown.Size = new System.Drawing.Size(251, 26);
            this._fovUpDown.TabIndex = 7;
            this._fovUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // _zoomMinUpDown
            // 
            this._zoomMinUpDown.DecimalPlaces = 2;
            this._zoomMinUpDown.Location = new System.Drawing.Point(12, 77);
            this._zoomMinUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._zoomMinUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this._zoomMinUpDown.Name = "_zoomMinUpDown";
            this._zoomMinUpDown.Size = new System.Drawing.Size(251, 26);
            this._zoomMinUpDown.TabIndex = 6;
            this._zoomMinUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // _fovDefaultButton
            // 
            this._fovDefaultButton.Location = new System.Drawing.Point(150, 122);
            this._fovDefaultButton.Name = "_fovDefaultButton";
            this._fovDefaultButton.Size = new System.Drawing.Size(112, 24);
            this._fovDefaultButton.TabIndex = 5;
            this._fovDefaultButton.Text = "Default";
            this._fovDefaultButton.UseVisualStyleBackColor = true;
            this._fovDefaultButton.Click += new System.EventHandler(this._fovDefaultButton_Click);
            // 
            // _zoomMinDefaultButton
            // 
            this._zoomMinDefaultButton.Location = new System.Drawing.Point(150, 42);
            this._zoomMinDefaultButton.Name = "_zoomMinDefaultButton";
            this._zoomMinDefaultButton.Size = new System.Drawing.Size(112, 24);
            this._zoomMinDefaultButton.TabIndex = 4;
            this._zoomMinDefaultButton.Text = "Default";
            this._zoomMinDefaultButton.UseVisualStyleBackColor = true;
            this._zoomMinDefaultButton.Click += new System.EventHandler(this._zoomMinDefaultButton_Click);
            // 
            // _fovLabel
            // 
            this._fovLabel.AutoSize = true;
            this._fovLabel.Location = new System.Drawing.Point(7, 122);
            this._fovLabel.Name = "_fovLabel";
            this._fovLabel.Size = new System.Drawing.Size(99, 20);
            this._fovLabel.TabIndex = 2;
            this._fovLabel.Text = "Field of View";
            // 
            // _zoomMinLabel
            // 
            this._zoomMinLabel.AutoSize = true;
            this._zoomMinLabel.Location = new System.Drawing.Point(7, 42);
            this._zoomMinLabel.Name = "_zoomMinLabel";
            this._zoomMinLabel.Size = new System.Drawing.Size(79, 20);
            this._zoomMinLabel.TabIndex = 1;
            this._zoomMinLabel.Text = "Zoom Min";
            // 
            // _processListBox
            // 
            this._processListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._processListBox.Controls.Add(this._gotoProcessButton);
            this._processListBox.Controls.Add(this.label1);
            this._processListBox.Controls.Add(this._processList);
            this._processListBox.Controls.Add(this._autoApplyCheckbox);
            this._processListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._processListBox.Location = new System.Drawing.Point(15, 46);
            this._processListBox.Name = "_processListBox";
            this._processListBox.Size = new System.Drawing.Size(553, 87);
            this._processListBox.TabIndex = 2;
            this._processListBox.TabStop = false;
            this._processListBox.Text = "Processes";
            // 
            // _gotoProcessButton
            // 
            this._gotoProcessButton.Location = new System.Drawing.Point(332, 53);
            this._gotoProcessButton.Name = "_gotoProcessButton";
            this._gotoProcessButton.Size = new System.Drawing.Size(167, 24);
            this._gotoProcessButton.TabIndex = 8;
            this._gotoProcessButton.Text = "Bring to Front";
            this._gotoProcessButton.UseVisualStyleBackColor = true;
            this._gotoProcessButton.Click += new System.EventHandler(this._gotoProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Processes";
            // 
            // _processList
            // 
            this._processList.FormattingEnabled = true;
            this._processList.Location = new System.Drawing.Point(111, 51);
            this._processList.Name = "_processList";
            this._processList.Size = new System.Drawing.Size(200, 28);
            this._processList.TabIndex = 1;
            // 
            // _updateOffsetsTextbox
            // 
            this._updateOffsetsTextbox.Location = new System.Drawing.Point(15, 12);
            this._updateOffsetsTextbox.Name = "_updateOffsetsTextbox";
            this._updateOffsetsTextbox.Size = new System.Drawing.Size(356, 21);
            this._updateOffsetsTextbox.TabIndex = 3;
            // 
            // _updateOffsetsButton
            // 
            this._updateOffsetsButton.Location = new System.Drawing.Point(471, 11);
            this._updateOffsetsButton.Name = "_updateOffsetsButton";
            this._updateOffsetsButton.Size = new System.Drawing.Size(97, 40);
            this._updateOffsetsButton.TabIndex = 9;
            this._updateOffsetsButton.Text = "Update Offsets";
            this._updateOffsetsButton.UseVisualStyleBackColor = true;
            this._updateOffsetsButton.Click += new System.EventHandler(this._updateOffsetsButton_Click);
            // 
            // _updateLocationDefault
            // 
            this._updateLocationDefault.Location = new System.Drawing.Point(379, 13);
            this._updateLocationDefault.Name = "_updateLocationDefault";
            this._updateLocationDefault.Size = new System.Drawing.Size(87, 38);
            this._updateLocationDefault.TabIndex = 10;
            this._updateLocationDefault.Text = "Default";
            this._updateLocationDefault.UseVisualStyleBackColor = true;
            this._updateLocationDefault.Click += new System.EventHandler(this._updateLocationDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 339);
            this.Controls.Add(this._updateLocationDefault);
            this.Controls.Add(this._updateOffsetsButton);
            this.Controls.Add(this._updateOffsetsTextbox);
            this.Controls.Add(this._processListBox);
            this.Controls.Add(this._zoomSettingsBox);
            this.MaximumSize = new System.Drawing.Size(598, 378);
            this.MinimumSize = new System.Drawing.Size(598, 378);
            this.Name = "Form1";
            this.Text = "FFXIV Zoom Hack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._zoomSettingsBox.ResumeLayout(false);
            this._zoomSettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._zoomMaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fovUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._zoomMinUpDown)).EndInit();
            this._processListBox.ResumeLayout(false);
            this._processListBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _autoApplyCheckbox;
        private System.Windows.Forms.GroupBox _zoomSettingsBox;
        private System.Windows.Forms.GroupBox _processListBox;
        private System.Windows.Forms.Label _fovLabel;
        private System.Windows.Forms.Label _zoomMinLabel;
        private System.Windows.Forms.Button _fovDefaultButton;
        private System.Windows.Forms.Button _zoomMinDefaultButton;
        private System.Windows.Forms.NumericUpDown _fovUpDown;
        private System.Windows.Forms.NumericUpDown _zoomMinUpDown;
        private System.Windows.Forms.Button _gotoProcessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _processList;
        private System.Windows.Forms.TextBox _updateOffsetsTextbox;
        private System.Windows.Forms.Button _updateOffsetsButton;
        private System.Windows.Forms.Button _updateLocationDefault;
        private System.Windows.Forms.NumericUpDown _zoomMaxUpDown;
        private System.Windows.Forms.Button _zoomMaxDefaultButton;
        private System.Windows.Forms.Label _zoomMaxLabel;
    }
}

