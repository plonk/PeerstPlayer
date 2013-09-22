﻿namespace PeerstPlayer.Forms.Setting
{
	partial class PlayerSettingView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSettingView));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.settingPage = new System.Windows.Forms.TabPage();
			this.windowGroupBox = new System.Windows.Forms.GroupBox();
			this.aspectRateFixCheckBox = new System.Windows.Forms.CheckBox();
			this.windowSnapEnableCheckBox = new System.Windows.Forms.CheckBox();
			this.volumeGroupBox = new System.Windows.Forms.GroupBox();
			this.initGroupBox = new System.Windows.Forms.GroupBox();
			this.writeFieldVisibleCheckBox = new System.Windows.Forms.CheckBox();
			this.topMostCheckBox = new System.Windows.Forms.CheckBox();
			this.closeGroupBox = new System.Windows.Forms.GroupBox();
			this.disconnectRealyOnCloseCheckBox = new System.Windows.Forms.CheckBox();
			this.statusBarGroupBox = new System.Windows.Forms.GroupBox();
			this.shortcutPage = new System.Windows.Forms.TabPage();
			this.commandLabel = new System.Windows.Forms.Label();
			this.shortcutListView = new System.Windows.Forms.ListView();
			this.commandColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.shortcutColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mouseGesturePage = new System.Windows.Forms.TabPage();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.settingPage.SuspendLayout();
			this.windowGroupBox.SuspendLayout();
			this.initGroupBox.SuspendLayout();
			this.closeGroupBox.SuspendLayout();
			this.shortcutPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.settingPage);
			this.tabControl.Controls.Add(this.shortcutPage);
			this.tabControl.Controls.Add(this.mouseGesturePage);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(591, 306);
			this.tabControl.TabIndex = 0;
			// 
			// settingPage
			// 
			this.settingPage.Controls.Add(this.windowGroupBox);
			this.settingPage.Controls.Add(this.volumeGroupBox);
			this.settingPage.Controls.Add(this.initGroupBox);
			this.settingPage.Controls.Add(this.closeGroupBox);
			this.settingPage.Controls.Add(this.statusBarGroupBox);
			this.settingPage.Location = new System.Drawing.Point(4, 22);
			this.settingPage.Name = "settingPage";
			this.settingPage.Padding = new System.Windows.Forms.Padding(3);
			this.settingPage.Size = new System.Drawing.Size(583, 280);
			this.settingPage.TabIndex = 0;
			this.settingPage.Text = "各種設定";
			this.settingPage.UseVisualStyleBackColor = true;
			// 
			// windowGroupBox
			// 
			this.windowGroupBox.Controls.Add(this.aspectRateFixCheckBox);
			this.windowGroupBox.Controls.Add(this.windowSnapEnableCheckBox);
			this.windowGroupBox.Location = new System.Drawing.Point(8, 6);
			this.windowGroupBox.Name = "windowGroupBox";
			this.windowGroupBox.Size = new System.Drawing.Size(242, 68);
			this.windowGroupBox.TabIndex = 4;
			this.windowGroupBox.TabStop = false;
			this.windowGroupBox.Text = "ウィンドウ";
			// 
			// aspectRateFixCheckBox
			// 
			this.aspectRateFixCheckBox.AutoSize = true;
			this.aspectRateFixCheckBox.Enabled = false;
			this.aspectRateFixCheckBox.Location = new System.Drawing.Point(9, 40);
			this.aspectRateFixCheckBox.Name = "aspectRateFixCheckBox";
			this.aspectRateFixCheckBox.Size = new System.Drawing.Size(104, 16);
			this.aspectRateFixCheckBox.TabIndex = 8;
			this.aspectRateFixCheckBox.Text = "アスペクト比固定";
			this.aspectRateFixCheckBox.UseVisualStyleBackColor = true;
			// 
			// windowSnapEnableCheckBox
			// 
			this.windowSnapEnableCheckBox.AutoSize = true;
			this.windowSnapEnableCheckBox.Location = new System.Drawing.Point(9, 18);
			this.windowSnapEnableCheckBox.Name = "windowSnapEnableCheckBox";
			this.windowSnapEnableCheckBox.Size = new System.Drawing.Size(126, 16);
			this.windowSnapEnableCheckBox.TabIndex = 7;
			this.windowSnapEnableCheckBox.Text = "ウィンドウスナップ有効";
			this.windowSnapEnableCheckBox.UseVisualStyleBackColor = true;
			// 
			// volumeGroupBox
			// 
			this.volumeGroupBox.Location = new System.Drawing.Point(256, 80);
			this.volumeGroupBox.Name = "volumeGroupBox";
			this.volumeGroupBox.Size = new System.Drawing.Size(242, 68);
			this.volumeGroupBox.TabIndex = 3;
			this.volumeGroupBox.TabStop = false;
			this.volumeGroupBox.Text = "音量";
			// 
			// initGroupBox
			// 
			this.initGroupBox.Controls.Add(this.writeFieldVisibleCheckBox);
			this.initGroupBox.Controls.Add(this.topMostCheckBox);
			this.initGroupBox.Location = new System.Drawing.Point(8, 80);
			this.initGroupBox.Name = "initGroupBox";
			this.initGroupBox.Size = new System.Drawing.Size(242, 68);
			this.initGroupBox.TabIndex = 2;
			this.initGroupBox.TabStop = false;
			this.initGroupBox.Text = "初期表示";
			// 
			// writeFieldVisibleCheckBox
			// 
			this.writeFieldVisibleCheckBox.AutoSize = true;
			this.writeFieldVisibleCheckBox.Location = new System.Drawing.Point(6, 18);
			this.writeFieldVisibleCheckBox.Name = "writeFieldVisibleCheckBox";
			this.writeFieldVisibleCheckBox.Size = new System.Drawing.Size(104, 16);
			this.writeFieldVisibleCheckBox.TabIndex = 9;
			this.writeFieldVisibleCheckBox.Text = "書き込み欄表示";
			this.writeFieldVisibleCheckBox.UseVisualStyleBackColor = true;
			// 
			// topMostCheckBox
			// 
			this.topMostCheckBox.AutoSize = true;
			this.topMostCheckBox.Location = new System.Drawing.Point(6, 40);
			this.topMostCheckBox.Name = "topMostCheckBox";
			this.topMostCheckBox.Size = new System.Drawing.Size(84, 16);
			this.topMostCheckBox.TabIndex = 6;
			this.topMostCheckBox.Text = "最前列表示";
			this.topMostCheckBox.UseVisualStyleBackColor = true;
			// 
			// closeGroupBox
			// 
			this.closeGroupBox.Controls.Add(this.disconnectRealyOnCloseCheckBox);
			this.closeGroupBox.Location = new System.Drawing.Point(8, 154);
			this.closeGroupBox.Name = "closeGroupBox";
			this.closeGroupBox.Size = new System.Drawing.Size(242, 68);
			this.closeGroupBox.TabIndex = 1;
			this.closeGroupBox.TabStop = false;
			this.closeGroupBox.Text = "終了時";
			// 
			// disconnectRealyOnCloseCheckBox
			// 
			this.disconnectRealyOnCloseCheckBox.AutoSize = true;
			this.disconnectRealyOnCloseCheckBox.Location = new System.Drawing.Point(9, 18);
			this.disconnectRealyOnCloseCheckBox.Name = "disconnectRealyOnCloseCheckBox";
			this.disconnectRealyOnCloseCheckBox.Size = new System.Drawing.Size(74, 16);
			this.disconnectRealyOnCloseCheckBox.TabIndex = 5;
			this.disconnectRealyOnCloseCheckBox.Text = "リレー切断";
			this.disconnectRealyOnCloseCheckBox.UseVisualStyleBackColor = true;
			// 
			// statusBarGroupBox
			// 
			this.statusBarGroupBox.Location = new System.Drawing.Point(256, 6);
			this.statusBarGroupBox.Name = "statusBarGroupBox";
			this.statusBarGroupBox.Size = new System.Drawing.Size(242, 68);
			this.statusBarGroupBox.TabIndex = 0;
			this.statusBarGroupBox.TabStop = false;
			this.statusBarGroupBox.Text = "ステータスバー";
			// 
			// shortcutPage
			// 
			this.shortcutPage.Controls.Add(this.commandLabel);
			this.shortcutPage.Controls.Add(this.shortcutListView);
			this.shortcutPage.Location = new System.Drawing.Point(4, 22);
			this.shortcutPage.Name = "shortcutPage";
			this.shortcutPage.Padding = new System.Windows.Forms.Padding(3);
			this.shortcutPage.Size = new System.Drawing.Size(583, 280);
			this.shortcutPage.TabIndex = 1;
			this.shortcutPage.Text = "ショートカット";
			this.shortcutPage.UseVisualStyleBackColor = true;
			// 
			// commandLabel
			// 
			this.commandLabel.AutoSize = true;
			this.commandLabel.Location = new System.Drawing.Point(8, 223);
			this.commandLabel.Name = "commandLabel";
			this.commandLabel.Size = new System.Drawing.Size(201, 24);
			this.commandLabel.TabIndex = 2;
			this.commandLabel.Text = "【登録】：コマンドを選択後、キー入力\r\n【削除】：削除したいコマンドをダブルクリック";
			// 
			// shortcutListView
			// 
			this.shortcutListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.commandColumnHeader,
            this.shortcutColumnHeader});
			this.shortcutListView.FullRowSelect = true;
			this.shortcutListView.GridLines = true;
			this.shortcutListView.Location = new System.Drawing.Point(8, 16);
			this.shortcutListView.MultiSelect = false;
			this.shortcutListView.Name = "shortcutListView";
			this.shortcutListView.Size = new System.Drawing.Size(317, 196);
			this.shortcutListView.TabIndex = 1;
			this.shortcutListView.UseCompatibleStateImageBehavior = false;
			this.shortcutListView.View = System.Windows.Forms.View.Details;
			// 
			// commandColumnHeader
			// 
			this.commandColumnHeader.Text = "コマンド";
			this.commandColumnHeader.Width = 140;
			// 
			// shortcutColumnHeader
			// 
			this.shortcutColumnHeader.Text = "ショートカット";
			this.shortcutColumnHeader.Width = 140;
			// 
			// mouseGesturePage
			// 
			this.mouseGesturePage.Location = new System.Drawing.Point(4, 22);
			this.mouseGesturePage.Name = "mouseGesturePage";
			this.mouseGesturePage.Size = new System.Drawing.Size(583, 280);
			this.mouseGesturePage.TabIndex = 2;
			this.mouseGesturePage.Text = "マウスジェスチャ";
			this.mouseGesturePage.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(423, 312);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Location = new System.Drawing.Point(504, 312);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "キャンセル";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// PlayerSettingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 347);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PlayerSettingView";
			this.Text = "設定";
			this.TopMost = true;
			this.tabControl.ResumeLayout(false);
			this.settingPage.ResumeLayout(false);
			this.windowGroupBox.ResumeLayout(false);
			this.windowGroupBox.PerformLayout();
			this.initGroupBox.ResumeLayout(false);
			this.initGroupBox.PerformLayout();
			this.closeGroupBox.ResumeLayout(false);
			this.closeGroupBox.PerformLayout();
			this.shortcutPage.ResumeLayout(false);
			this.shortcutPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage settingPage;
		private System.Windows.Forms.TabPage shortcutPage;
		private System.Windows.Forms.TabPage mouseGesturePage;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.GroupBox windowGroupBox;
		private System.Windows.Forms.GroupBox volumeGroupBox;
		private System.Windows.Forms.GroupBox initGroupBox;
		private System.Windows.Forms.GroupBox closeGroupBox;
		private System.Windows.Forms.GroupBox statusBarGroupBox;
		private System.Windows.Forms.CheckBox disconnectRealyOnCloseCheckBox;
		private System.Windows.Forms.CheckBox windowSnapEnableCheckBox;
		private System.Windows.Forms.CheckBox topMostCheckBox;
		private System.Windows.Forms.CheckBox aspectRateFixCheckBox;
		private System.Windows.Forms.CheckBox writeFieldVisibleCheckBox;
		private System.Windows.Forms.ListView shortcutListView;
		private System.Windows.Forms.ColumnHeader commandColumnHeader;
		private System.Windows.Forms.ColumnHeader shortcutColumnHeader;
		private System.Windows.Forms.Label commandLabel;

	}
}