namespace BoreParamCompare
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog_old = new OpenFileDialog();
            b_browse_old = new Button();
            b_activate = new Button();
            b_browse_new = new Button();
            t_console = new TextBox();
            openFileDialog_new = new OpenFileDialog();
            cb_dupe = new CheckBox();
            cb_dupe_no_old = new CheckBox();
            cb_dupe_no_both = new CheckBox();
            label1 = new Label();
            t_VersionNew = new TextBox();
            t_VersionOld = new TextBox();
            label2 = new Label();
            label3 = new Label();
            menu_GameType = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            b_info = new Button();
            tabPage2 = new TabPage();
            cb_logAddedRemovedRows = new CheckBox();
            cb_LogAddedRemovedRowCells = new CheckBox();
            label7 = new Label();
            combo_logNameExclusive = new ComboBox();
            cb_LogRowNames = new CheckBox();
            cb_log_name_changes_only = new CheckBox();
            label6 = new Label();
            cb_log_field_specifics = new CheckBox();
            cb_fields_share_row = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog_old
            // 
            openFileDialog_old.Filter = "Parambnd, Regulation, Data0, or .param|*";
            openFileDialog_old.Title = "Select old Parambnd or Regulation.bin";
            openFileDialog_old.FileOk += openFileDialog_old_FileOk;
            // 
            // b_browse_old
            // 
            b_browse_old.AllowDrop = true;
            b_browse_old.Font = new Font("Segoe UI", 9F);
            b_browse_old.Location = new Point(10, 151);
            b_browse_old.Name = "b_browse_old";
            b_browse_old.Size = new Size(74, 24);
            b_browse_old.TabIndex = 60;
            b_browse_old.Text = "Open Old";
            b_browse_old.UseVisualStyleBackColor = true;
            b_browse_old.Click += b_browse_old_Click;
            b_browse_old.DragDrop += t_VersionOld_DragDrop;
            b_browse_old.DragOver += t_VersionOld_DragOver;
            // 
            // b_activate
            // 
            b_activate.Enabled = false;
            b_activate.Font = new Font("Segoe UI", 9F);
            b_activate.Location = new Point(283, 152);
            b_activate.Name = "b_activate";
            b_activate.Size = new Size(74, 24);
            b_activate.TabIndex = 61;
            b_activate.Text = "Compare";
            b_activate.UseVisualStyleBackColor = true;
            b_activate.Click += b_activate_Click;
            // 
            // b_browse_new
            // 
            b_browse_new.AllowDrop = true;
            b_browse_new.Font = new Font("Segoe UI", 9F);
            b_browse_new.Location = new Point(147, 152);
            b_browse_new.Name = "b_browse_new";
            b_browse_new.Size = new Size(74, 24);
            b_browse_new.TabIndex = 63;
            b_browse_new.Text = "Open New";
            b_browse_new.UseVisualStyleBackColor = true;
            b_browse_new.Click += b_browse_new_Click;
            b_browse_new.DragDrop += t_VersionNew_DragDrop;
            b_browse_new.DragOver += t_VersionNew_DragOver;
            // 
            // t_console
            // 
            t_console.Location = new Point(8, 294);
            t_console.Name = "t_console";
            t_console.ReadOnly = true;
            t_console.Size = new Size(349, 23);
            t_console.TabIndex = 24;
            t_console.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog_new
            // 
            openFileDialog_new.Filter = "Parambnd, Regulation, Data0, or .param|*";
            openFileDialog_new.Title = "Select new Parambnd or Regulation.bin";
            // 
            // cb_dupe
            // 
            cb_dupe.AutoSize = true;
            cb_dupe.Checked = true;
            cb_dupe.CheckState = CheckState.Checked;
            cb_dupe.Location = new Point(8, 173);
            cb_dupe.Name = "cb_dupe";
            cb_dupe.Size = new Size(95, 19);
            cb_dupe.TabIndex = 65;
            cb_dupe.Text = "Log dupe IDs";
            cb_dupe.UseVisualStyleBackColor = true;
            cb_dupe.CheckedChanged += cb_dupe_CheckedChanged;
            // 
            // cb_dupe_no_old
            // 
            cb_dupe_no_old.AutoSize = true;
            cb_dupe_no_old.Location = new Point(8, 198);
            cb_dupe_no_old.Name = "cb_dupe_no_old";
            cb_dupe_no_old.Size = new Size(279, 19);
            cb_dupe_no_old.TabIndex = 67;
            cb_dupe_no_old.Text = "Don't log dupe IDs found in OLD (log all in new)\r\n";
            cb_dupe_no_old.UseVisualStyleBackColor = true;
            cb_dupe_no_old.CheckedChanged += cb_dupe_no_old_CheckedChanged;
            // 
            // cb_dupe_no_both
            // 
            cb_dupe_no_both.AutoSize = true;
            cb_dupe_no_both.Checked = true;
            cb_dupe_no_both.CheckState = CheckState.Checked;
            cb_dupe_no_both.Location = new Point(8, 223);
            cb_dupe_no_both.Name = "cb_dupe_no_both";
            cb_dupe_no_both.Size = new Size(326, 19);
            cb_dupe_no_both.TabIndex = 66;
            cb_dupe_no_both.Text = "Don't log dupe IDs found in BOTH (unique new/old only)";
            cb_dupe_no_both.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 149);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 71;
            label1.Text = "Dupe IDs";
            // 
            // t_VersionNew
            // 
            t_VersionNew.AllowDrop = true;
            t_VersionNew.Location = new Point(147, 117);
            t_VersionNew.Name = "t_VersionNew";
            t_VersionNew.ReadOnly = true;
            t_VersionNew.Size = new Size(74, 23);
            t_VersionNew.TabIndex = 72;
            t_VersionNew.Text = "Unloaded";
            t_VersionNew.TextAlign = HorizontalAlignment.Center;
            t_VersionNew.DragDrop += t_VersionNew_DragDrop;
            t_VersionNew.DragOver += t_VersionNew_DragOver;
            // 
            // t_VersionOld
            // 
            t_VersionOld.AllowDrop = true;
            t_VersionOld.Location = new Point(10, 117);
            t_VersionOld.Name = "t_VersionOld";
            t_VersionOld.ReadOnly = true;
            t_VersionOld.Size = new Size(74, 23);
            t_VersionOld.TabIndex = 73;
            t_VersionOld.Text = "Unloaded";
            t_VersionOld.TextAlign = HorizontalAlignment.Center;
            t_VersionOld.DragDrop += t_VersionOld_DragDrop;
            t_VersionOld.DragOver += t_VersionOld_DragOver;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 99);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 74;
            label2.Text = "Old Version #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 99);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 75;
            label3.Text = "New Version #";
            // 
            // menu_GameType
            // 
            menu_GameType.DropDownStyle = ComboBoxStyle.DropDownList;
            menu_GameType.FormattingEnabled = true;
            menu_GameType.Items.AddRange(new object[] { "[overwritten]" });
            menu_GameType.Location = new Point(283, 117);
            menu_GameType.Name = "menu_GameType";
            menu_GameType.Size = new Size(74, 23);
            menu_GameType.TabIndex = 76;
            menu_GameType.SelectedIndexChanged += cb_GameType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 99);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 77;
            label4.Text = "Game";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(8, 74);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 81;
            label5.Text = "Row Names";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(373, 353);
            tabControl1.TabIndex = 82;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(b_info);
            tabPage1.Controls.Add(t_console);
            tabPage1.Controls.Add(b_browse_old);
            tabPage1.Controls.Add(b_activate);
            tabPage1.Controls.Add(b_browse_new);
            tabPage1.Controls.Add(t_VersionNew);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(t_VersionOld);
            tabPage1.Controls.Add(menu_GameType);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(365, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // b_info
            // 
            b_info.Location = new Point(314, 6);
            b_info.Name = "b_info";
            b_info.Size = new Size(45, 23);
            b_info.TabIndex = 79;
            b_info.Text = "Info";
            b_info.UseVisualStyleBackColor = true;
            b_info.Click += b_info_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cb_logAddedRemovedRows);
            tabPage2.Controls.Add(cb_LogAddedRemovedRowCells);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(combo_logNameExclusive);
            tabPage2.Controls.Add(cb_LogRowNames);
            tabPage2.Controls.Add(cb_log_name_changes_only);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(cb_log_field_specifics);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(cb_dupe);
            tabPage2.Controls.Add(cb_dupe_no_both);
            tabPage2.Controls.Add(cb_dupe_no_old);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cb_fields_share_row);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(365, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Options";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_logAddedRemovedRows
            // 
            cb_logAddedRemovedRows.AutoSize = true;
            cb_logAddedRemovedRows.Checked = true;
            cb_logAddedRemovedRows.CheckState = CheckState.Checked;
            cb_logAddedRemovedRows.Location = new Point(8, 275);
            cb_logAddedRemovedRows.Name = "cb_logAddedRemovedRows";
            cb_logAddedRemovedRows.Size = new Size(162, 19);
            cb_logAddedRemovedRows.TabIndex = 90;
            cb_logAddedRemovedRows.Text = "Log added/removed rows";
            cb_logAddedRemovedRows.UseVisualStyleBackColor = true;
            cb_logAddedRemovedRows.CheckedChanged += cb_logAddedRemovedRows_CheckedChanged;
            // 
            // cb_LogAddedRemovedRowCells
            // 
            cb_LogAddedRemovedRowCells.AutoSize = true;
            cb_LogAddedRemovedRowCells.Location = new Point(8, 300);
            cb_LogAddedRemovedRowCells.Name = "cb_LogAddedRemovedRowCells";
            cb_LogAddedRemovedRowCells.Size = new Size(245, 19);
            cb_LogAddedRemovedRowCells.TabIndex = 89;
            cb_LogAddedRemovedRowCells.Text = "Log all field info for added/removed rows";
            cb_LogAddedRemovedRowCells.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(10, 251);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 88;
            label7.Text = "Misc";
            // 
            // combo_logNameExclusive
            // 
            combo_logNameExclusive.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_logNameExclusive.FormattingEnabled = true;
            combo_logNameExclusive.Items.AddRange(new object[] { "Import row names from Paramdex", "Log Old vs New differences", "Use names from New", "Use names from Old" });
            combo_logNameExclusive.Location = new Point(113, 100);
            combo_logNameExclusive.Name = "combo_logNameExclusive";
            combo_logNameExclusive.Size = new Size(221, 23);
            combo_logNameExclusive.TabIndex = 87;
            combo_logNameExclusive.SelectedIndexChanged += combo_logNameExclusive_SelectedIndexChanged;
            // 
            // cb_LogRowNames
            // 
            cb_LogRowNames.AutoSize = true;
            cb_LogRowNames.Checked = true;
            cb_LogRowNames.CheckState = CheckState.Checked;
            cb_LogRowNames.Location = new Point(6, 102);
            cb_LogRowNames.Name = "cb_LogRowNames";
            cb_LogRowNames.Size = new Size(107, 19);
            cb_LogRowNames.TabIndex = 86;
            cb_LogRowNames.Text = "Log row names";
            cb_LogRowNames.UseVisualStyleBackColor = true;
            cb_LogRowNames.CheckedChanged += cb_LogRowNames_CheckedChanged;
            // 
            // cb_log_name_changes_only
            // 
            cb_log_name_changes_only.AutoSize = true;
            cb_log_name_changes_only.Location = new Point(6, 127);
            cb_log_name_changes_only.Name = "cb_log_name_changes_only";
            cb_log_name_changes_only.Size = new Size(242, 19);
            cb_log_name_changes_only.TabIndex = 83;
            cb_log_name_changes_only.Text = "Don't log row names that are unchanged";
            cb_log_name_changes_only.UseVisualStyleBackColor = true;
            cb_log_name_changes_only.CheckedChanged += cb_log_name_changes_only_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 82;
            label6.Text = "Formatting";
            // 
            // cb_log_field_specifics
            // 
            cb_log_field_specifics.AutoSize = true;
            cb_log_field_specifics.Checked = true;
            cb_log_field_specifics.CheckState = CheckState.Checked;
            cb_log_field_specifics.Location = new Point(6, 27);
            cb_log_field_specifics.Name = "cb_log_field_specifics";
            cb_log_field_specifics.Size = new Size(162, 19);
            cb_log_field_specifics.TabIndex = 69;
            cb_log_field_specifics.Text = "Log specific field changes";
            cb_log_field_specifics.UseVisualStyleBackColor = true;
            cb_log_field_specifics.CheckedChanged += cb_log_field_specifics_CheckedChanged;
            // 
            // cb_fields_share_row
            // 
            cb_fields_share_row.AutoSize = true;
            cb_fields_share_row.Location = new Point(6, 52);
            cb_fields_share_row.Name = "cb_fields_share_row";
            cb_fields_share_row.Size = new Size(198, 19);
            cb_fields_share_row.TabIndex = 70;
            cb_fields_share_row.Text = "Log row changes in 1 shared line";
            cb_fields_share_row.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 353);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Bore Param Comparison";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog_old;
        private TextBox t_console;
        private Button b_browse_old;
        private Button b_activate;
        private Button b_browse_new;
        private OpenFileDialog openFileDialog_new;
        private CheckBox cb_dupe;
        private CheckBox cb_dupe_no_old;
        private CheckBox cb_dupe_no_both;
        private Label label1;
        private TextBox t_VersionNew;
        private TextBox t_VersionOld;
        private Label label2;
        private Label label3;
        private ComboBox menu_GameType;
        private Label label4;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox cb_log_field_specifics;
        private CheckBox cb_fields_share_row;
        private Label label6;
        private CheckBox cb_log_name_changes_only;
        private CheckBox cb_LogRowNames;
        private ComboBox combo_logNameExclusive;
        private CheckBox cb_LogAddedRemovedRowCells;
        private Label label7;
        private Button b_info;
        private CheckBox cb_logAddedRemovedRows;
    }
}