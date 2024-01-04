using System.Windows.Forms;

namespace AutoClicker
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
            this.components = new System.ComponentModel.Container();
            this.MasterEnabler_CheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Title_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.WindowController_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Display_Panel = new System.Windows.Forms.Panel();
            this.ClickAction_GroupBox = new System.Windows.Forms.GroupBox();
            this.MiddleClick_RadioButton = new System.Windows.Forms.RadioButton();
            this.LeftClick_RadioButton = new System.Windows.Forms.RadioButton();
            this.RightClick_RadioButton = new System.Windows.Forms.RadioButton();
            this.Custom_RadioButton = new System.Windows.Forms.RadioButton();
            this.Custom_Button = new System.Windows.Forms.Button();
            this.CPS_GroupBox = new System.Windows.Forms.GroupBox();
            this.CPS_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.System_GroupBox = new System.Windows.Forms.GroupBox();
            this.TopMost_CheckBox = new System.Windows.Forms.CheckBox();
            this.Trigger_GroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeHotkey_Button = new System.Windows.Forms.Button();
            this.Toggle_CheckBox = new System.Windows.Forms.CheckBox();
            this.Hotkey_Label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.Title_FlowLayoutPanel.SuspendLayout();
            this.WindowController_FlowLayoutPanel.SuspendLayout();
            this.Display_Panel.SuspendLayout();
            this.ClickAction_GroupBox.SuspendLayout();
            this.CPS_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPS_NumericUpDown)).BeginInit();
            this.System_GroupBox.SuspendLayout();
            this.Trigger_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterEnabler_CheckBox
            // 
            this.MasterEnabler_CheckBox.AutoSize = true;
            this.MasterEnabler_CheckBox.ForeColor = System.Drawing.Color.Red;
            this.MasterEnabler_CheckBox.Location = new System.Drawing.Point(6, 19);
            this.MasterEnabler_CheckBox.Name = "MasterEnabler_CheckBox";
            this.MasterEnabler_CheckBox.Size = new System.Drawing.Size(59, 17);
            this.MasterEnabler_CheckBox.TabIndex = 0;
            this.MasterEnabler_CheckBox.Text = "Enable";
            this.MasterEnabler_CheckBox.UseVisualStyleBackColor = true;
            this.MasterEnabler_CheckBox.CheckedChanged += new System.EventHandler(this.Master_CheckBox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Title_FlowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WindowController_FlowLayoutPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Display_Panel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 211);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Title_FlowLayoutPanel
            // 
            this.Title_FlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title_FlowLayoutPanel.Controls.Add(this.Title_Label);
            this.Title_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Title_FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Title_FlowLayoutPanel.Name = "Title_FlowLayoutPanel";
            this.Title_FlowLayoutPanel.Size = new System.Drawing.Size(108, 33);
            this.Title_FlowLayoutPanel.TabIndex = 1;
            this.Title_FlowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_DragAndDrop);
            this.Title_FlowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_DragAndDrop);
            this.Title_FlowLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_DragAndDrop);
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ForeColor = System.Drawing.Color.Red;
            this.Title_Label.Location = new System.Drawing.Point(3, 3);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(3);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(102, 25);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "AutoClicker";
            this.Title_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_DragAndDrop);
            this.Title_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_DragAndDrop);
            this.Title_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_DragAndDrop);
            // 
            // WindowController_FlowLayoutPanel
            // 
            this.WindowController_FlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WindowController_FlowLayoutPanel.Controls.Add(this.Close_Button);
            this.WindowController_FlowLayoutPanel.Controls.Add(this.Minimize_Button);
            this.WindowController_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowController_FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.WindowController_FlowLayoutPanel.Location = new System.Drawing.Point(108, 0);
            this.WindowController_FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.WindowController_FlowLayoutPanel.Name = "WindowController_FlowLayoutPanel";
            this.WindowController_FlowLayoutPanel.Size = new System.Drawing.Size(184, 33);
            this.WindowController_FlowLayoutPanel.TabIndex = 2;
            this.WindowController_FlowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_DragAndDrop);
            this.WindowController_FlowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_DragAndDrop);
            this.WindowController_FlowLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_DragAndDrop);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.ForeColor = System.Drawing.Color.Red;
            this.Close_Button.Location = new System.Drawing.Point(155, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(26, 26);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "X";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.ForeColor = System.Drawing.Color.Red;
            this.Minimize_Button.Location = new System.Drawing.Point(123, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(26, 26);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.Text = "__";
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Display_Panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Display_Panel, 2);
            this.Display_Panel.Controls.Add(this.ClickAction_GroupBox);
            this.Display_Panel.Controls.Add(this.CPS_GroupBox);
            this.Display_Panel.Controls.Add(this.System_GroupBox);
            this.Display_Panel.Controls.Add(this.Trigger_GroupBox);
            this.Display_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display_Panel.Location = new System.Drawing.Point(0, 33);
            this.Display_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Display_Panel.Name = "Display_Panel";
            this.Display_Panel.Padding = new System.Windows.Forms.Padding(3);
            this.Display_Panel.Size = new System.Drawing.Size(292, 178);
            this.Display_Panel.TabIndex = 3;
            // 
            // ClickAction_GroupBox
            // 
            this.ClickAction_GroupBox.Controls.Add(this.MiddleClick_RadioButton);
            this.ClickAction_GroupBox.Controls.Add(this.LeftClick_RadioButton);
            this.ClickAction_GroupBox.Controls.Add(this.RightClick_RadioButton);
            this.ClickAction_GroupBox.Controls.Add(this.Custom_RadioButton);
            this.ClickAction_GroupBox.Controls.Add(this.Custom_Button);
            this.ClickAction_GroupBox.ForeColor = System.Drawing.Color.Red;
            this.ClickAction_GroupBox.Location = new System.Drawing.Point(6, 74);
            this.ClickAction_GroupBox.Name = "ClickAction_GroupBox";
            this.ClickAction_GroupBox.Size = new System.Drawing.Size(281, 100);
            this.ClickAction_GroupBox.TabIndex = 17;
            this.ClickAction_GroupBox.TabStop = false;
            this.ClickAction_GroupBox.Text = "ClickAction";
            // 
            // MiddleClick_RadioButton
            // 
            this.MiddleClick_RadioButton.AutoSize = true;
            this.MiddleClick_RadioButton.Enabled = false;
            this.MiddleClick_RadioButton.ForeColor = System.Drawing.Color.Red;
            this.MiddleClick_RadioButton.Location = new System.Drawing.Point(6, 42);
            this.MiddleClick_RadioButton.Name = "MiddleClick_RadioButton";
            this.MiddleClick_RadioButton.Size = new System.Drawing.Size(80, 17);
            this.MiddleClick_RadioButton.TabIndex = 13;
            this.MiddleClick_RadioButton.Text = "middle click";
            this.MiddleClick_RadioButton.UseVisualStyleBackColor = true;
            this.MiddleClick_RadioButton.CheckedChanged += new System.EventHandler(this.MiddleClick_RadioButton_CheckedChanged);
            // 
            // LeftClick_RadioButton
            // 
            this.LeftClick_RadioButton.AutoSize = true;
            this.LeftClick_RadioButton.Enabled = false;
            this.LeftClick_RadioButton.ForeColor = System.Drawing.Color.Red;
            this.LeftClick_RadioButton.Location = new System.Drawing.Point(6, 19);
            this.LeftClick_RadioButton.Name = "LeftClick_RadioButton";
            this.LeftClick_RadioButton.Size = new System.Drawing.Size(64, 17);
            this.LeftClick_RadioButton.TabIndex = 4;
            this.LeftClick_RadioButton.Text = "left click";
            this.LeftClick_RadioButton.UseVisualStyleBackColor = true;
            this.LeftClick_RadioButton.CheckedChanged += new System.EventHandler(this.LeftClick_RadioButton_CheckedChanged);
            // 
            // RightClick_RadioButton
            // 
            this.RightClick_RadioButton.AutoSize = true;
            this.RightClick_RadioButton.Enabled = false;
            this.RightClick_RadioButton.ForeColor = System.Drawing.Color.Red;
            this.RightClick_RadioButton.Location = new System.Drawing.Point(6, 65);
            this.RightClick_RadioButton.Name = "RightClick_RadioButton";
            this.RightClick_RadioButton.Size = new System.Drawing.Size(70, 17);
            this.RightClick_RadioButton.TabIndex = 5;
            this.RightClick_RadioButton.Text = "right click";
            this.RightClick_RadioButton.UseVisualStyleBackColor = true;
            this.RightClick_RadioButton.CheckedChanged += new System.EventHandler(this.RightClick_RadioButton_CheckedChanged);
            // 
            // Custom_RadioButton
            // 
            this.Custom_RadioButton.AutoSize = true;
            this.Custom_RadioButton.Enabled = false;
            this.Custom_RadioButton.ForeColor = System.Drawing.Color.Red;
            this.Custom_RadioButton.Location = new System.Drawing.Point(186, 19);
            this.Custom_RadioButton.Name = "Custom_RadioButton";
            this.Custom_RadioButton.Size = new System.Drawing.Size(60, 17);
            this.Custom_RadioButton.TabIndex = 6;
            this.Custom_RadioButton.Text = "Custom";
            this.Custom_RadioButton.UseVisualStyleBackColor = true;
            this.Custom_RadioButton.CheckedChanged += new System.EventHandler(this.Custom_RadioButton_CheckedChanged);
            // 
            // Custom_Button
            // 
            this.Custom_Button.Enabled = false;
            this.Custom_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Custom_Button.ForeColor = System.Drawing.Color.Red;
            this.Custom_Button.Location = new System.Drawing.Point(186, 42);
            this.Custom_Button.Name = "Custom_Button";
            this.Custom_Button.Size = new System.Drawing.Size(89, 23);
            this.Custom_Button.TabIndex = 12;
            this.Custom_Button.Text = "F10";
            this.Custom_Button.UseVisualStyleBackColor = true;
            this.Custom_Button.Click += new System.EventHandler(this.Custom_Button_Click);
            // 
            // CPS_GroupBox
            // 
            this.CPS_GroupBox.Controls.Add(this.CPS_NumericUpDown);
            this.CPS_GroupBox.ForeColor = System.Drawing.Color.Red;
            this.CPS_GroupBox.Location = new System.Drawing.Point(137, 6);
            this.CPS_GroupBox.Name = "CPS_GroupBox";
            this.CPS_GroupBox.Size = new System.Drawing.Size(66, 62);
            this.CPS_GroupBox.TabIndex = 16;
            this.CPS_GroupBox.TabStop = false;
            this.CPS_GroupBox.Text = "CPS";
            // 
            // CPS_NumericUpDown
            // 
            this.CPS_NumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CPS_NumericUpDown.Enabled = false;
            this.CPS_NumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CPS_NumericUpDown.ForeColor = System.Drawing.Color.Red;
            this.CPS_NumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.CPS_NumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.CPS_NumericUpDown.Name = "CPS_NumericUpDown";
            this.CPS_NumericUpDown.Size = new System.Drawing.Size(54, 23);
            this.CPS_NumericUpDown.TabIndex = 2;
            this.CPS_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CPS_NumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CPS_NumericUpDown.ValueChanged += new System.EventHandler(this.CPS_NumericUpDown_ValueChanged);
            // 
            // System_GroupBox
            // 
            this.System_GroupBox.Controls.Add(this.TopMost_CheckBox);
            this.System_GroupBox.Controls.Add(this.MasterEnabler_CheckBox);
            this.System_GroupBox.ForeColor = System.Drawing.Color.Red;
            this.System_GroupBox.Location = new System.Drawing.Point(209, 6);
            this.System_GroupBox.Name = "System_GroupBox";
            this.System_GroupBox.Size = new System.Drawing.Size(78, 62);
            this.System_GroupBox.TabIndex = 15;
            this.System_GroupBox.TabStop = false;
            this.System_GroupBox.Text = "System";
            // 
            // TopMost_CheckBox
            // 
            this.TopMost_CheckBox.AutoSize = true;
            this.TopMost_CheckBox.ForeColor = System.Drawing.Color.Red;
            this.TopMost_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.TopMost_CheckBox.Name = "TopMost_CheckBox";
            this.TopMost_CheckBox.Size = new System.Drawing.Size(68, 17);
            this.TopMost_CheckBox.TabIndex = 1;
            this.TopMost_CheckBox.Text = "TopMost";
            this.TopMost_CheckBox.UseVisualStyleBackColor = true;
            this.TopMost_CheckBox.CheckedChanged += new System.EventHandler(this.TopMost_CheckBox_CheckedChanged);
            // 
            // Trigger_GroupBox
            // 
            this.Trigger_GroupBox.Controls.Add(this.ChangeHotkey_Button);
            this.Trigger_GroupBox.Controls.Add(this.Toggle_CheckBox);
            this.Trigger_GroupBox.Controls.Add(this.Hotkey_Label);
            this.Trigger_GroupBox.ForeColor = System.Drawing.Color.Red;
            this.Trigger_GroupBox.Location = new System.Drawing.Point(6, 6);
            this.Trigger_GroupBox.Name = "Trigger_GroupBox";
            this.Trigger_GroupBox.Size = new System.Drawing.Size(125, 62);
            this.Trigger_GroupBox.TabIndex = 14;
            this.Trigger_GroupBox.TabStop = false;
            this.Trigger_GroupBox.Text = "Trigger";
            // 
            // ChangeHotkey_Button
            // 
            this.ChangeHotkey_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeHotkey_Button.Enabled = false;
            this.ChangeHotkey_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeHotkey_Button.ForeColor = System.Drawing.Color.Red;
            this.ChangeHotkey_Button.Location = new System.Drawing.Point(6, 32);
            this.ChangeHotkey_Button.Name = "ChangeHotkey_Button";
            this.ChangeHotkey_Button.Size = new System.Drawing.Size(113, 23);
            this.ChangeHotkey_Button.TabIndex = 10;
            this.ChangeHotkey_Button.UseVisualStyleBackColor = true;
            this.ChangeHotkey_Button.Click += new System.EventHandler(this.ChangeHotkey_Button_Click);
            // 
            // Toggle_CheckBox
            // 
            this.Toggle_CheckBox.AutoSize = true;
            this.Toggle_CheckBox.Enabled = false;
            this.Toggle_CheckBox.ForeColor = System.Drawing.Color.Red;
            this.Toggle_CheckBox.Location = new System.Drawing.Point(60, 12);
            this.Toggle_CheckBox.Name = "Toggle_CheckBox";
            this.Toggle_CheckBox.Size = new System.Drawing.Size(59, 17);
            this.Toggle_CheckBox.TabIndex = 13;
            this.Toggle_CheckBox.Text = "Toggle";
            this.Toggle_CheckBox.UseVisualStyleBackColor = true;
            this.Toggle_CheckBox.CheckedChanged += new System.EventHandler(this.Toggle_CheckBox_CheckedChanged);
            // 
            // Hotkey_Label
            // 
            this.Hotkey_Label.AutoSize = true;
            this.Hotkey_Label.ForeColor = System.Drawing.Color.Red;
            this.Hotkey_Label.Location = new System.Drawing.Point(3, 16);
            this.Hotkey_Label.Name = "Hotkey_Label";
            this.Hotkey_Label.Size = new System.Drawing.Size(44, 13);
            this.Hotkey_Label.TabIndex = 11;
            this.Hotkey_Label.Text = "Hotkey:";
            // 
            // _MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(292, 211);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "AutoClicker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Title_FlowLayoutPanel.ResumeLayout(false);
            this.Title_FlowLayoutPanel.PerformLayout();
            this.WindowController_FlowLayoutPanel.ResumeLayout(false);
            this.Display_Panel.ResumeLayout(false);
            this.ClickAction_GroupBox.ResumeLayout(false);
            this.ClickAction_GroupBox.PerformLayout();
            this.CPS_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CPS_NumericUpDown)).EndInit();
            this.System_GroupBox.ResumeLayout(false);
            this.System_GroupBox.PerformLayout();
            this.Trigger_GroupBox.ResumeLayout(false);
            this.Trigger_GroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private CheckBox MasterEnabler_CheckBox;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel Title_FlowLayoutPanel;
        private FlowLayoutPanel WindowController_FlowLayoutPanel;
        private Button Minimize_Button;
        private Button Close_Button;
        private Label Title_Label;
        private Panel Display_Panel;
        private CheckBox TopMost_CheckBox;
        private NumericUpDown CPS_NumericUpDown;
        private RadioButton RightClick_RadioButton;
        private RadioButton Custom_RadioButton;
        private RadioButton LeftClick_RadioButton;
        private Label Hotkey_Label;
        private Button ChangeHotkey_Button;
        private Button Custom_Button;
        private CheckBox Toggle_CheckBox;
        private ToolTip toolTip1;
        private GroupBox Trigger_GroupBox;
        private GroupBox System_GroupBox;
        private GroupBox CPS_GroupBox;
        private GroupBox ClickAction_GroupBox;
        private RadioButton MiddleClick_RadioButton;
    }
}