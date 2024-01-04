using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // I have terrible code
            for (int i = 0; i < 255; i++)
                if (((VirtualKeyCode)i).ToString() != i.ToString())
                    virtualKeyCodes.Add((VirtualKeyCode)i);
        }


        private readonly AutoClicker autoClicker = new AutoClicker();


        #region WindowController Funktions
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region DragAndDrop Funktions
        private int differenceX;
        private int differenceY;

        private bool isDragging = false;

        private void MouseDown_DragAndDrop(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;


            differenceX = Location.X - MousePosition.X;
            differenceY = Location.Y - MousePosition.Y;

            isDragging = true;
        }

        private void MouseMove_DragAndDrop(object sender, MouseEventArgs e)
        {
            if (isDragging)
                Location = new Point(MousePosition.X + differenceX, MousePosition.Y + differenceY);
        }

        private void MouseUp_DragAndDrop(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion


        #region System
        private void Master_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Enabler(MasterEnabler_CheckBox.Checked);
            autoClicker.MasterActivation = MasterEnabler_CheckBox.Checked;
        }

        private void TopMost_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = TopMost_CheckBox.Checked;
        }
        #endregion


        #region Trigger
        private void Toggle_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            autoClicker.ClickType = Toggle_CheckBox.Checked ? ClickType.toggle : ClickType.hold;
        }

        private void ChangeHotkey_Button_Click(object sender, EventArgs e)
        {
            autoClicker.MasterActivation = false;
            EnablerOther(false);
            ChangeHotkey_Button.Text = (autoClicker.TriggerKey = GetNextKeyPress()).ToString();
            EnablerOther(true);
            autoClicker.MasterActivation = MasterEnabler_CheckBox.Checked;
        }
        #endregion


        #region CPS
        private void CPS_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            autoClicker.TargettetCPS = (ushort)CPS_NumericUpDown.Value;
        }
        #endregion


        #region ClickAction
        private void LeftClick_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            autoClicker.KeyToClick = VirtualKeyCode.LBUTTON;
        }
        private void MiddleClick_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            autoClicker.KeyToClick = VirtualKeyCode.MBUTTON;
        }
        private void RightClick_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            autoClicker.KeyToClick = VirtualKeyCode.RBUTTON;
        }

        private VirtualKeyCode CustomKeyCode = VirtualKeyCode.F10;
        private void Custom_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            autoClicker.KeyToClick = CustomKeyCode;
        }
        private void Custom_Button_Click(object sender, EventArgs e)
        {
            autoClicker.MasterActivation = false;
            EnablerOther(false);
            CustomKeyCode = GetNextKeyPress();
            Custom_Button.Text = CustomKeyCode.ToString();
            if (Custom_RadioButton.Checked)
                autoClicker.KeyToClick = CustomKeyCode;
            EnablerOther(true);
            autoClicker.MasterActivation = MasterEnabler_CheckBox.Checked;
        }
        #endregion


        #region Other help Funktions
        private readonly List<VirtualKeyCode> virtualKeyCodes = new List<VirtualKeyCode>();
        private VirtualKeyCode GetNextKeyPress()
        {
            InputSimulator inputSimulator = new InputSimulator();

            while (true)
            {
                Task.Delay(50).Wait();
                for (int i = 0; i < virtualKeyCodes.Count; i++)
                    if (inputSimulator.InputDeviceState.IsHardwareKeyDown(virtualKeyCodes[i]))
                        return virtualKeyCodes[i];
            }
        }

        private void EnablerOther(bool state)
        {
            Enabler(state);
            Minimize_Button.Enabled = state;
            TopMost_CheckBox.Enabled = state;
            MasterEnabler_CheckBox.Enabled = state;
        }
        private void Enabler(bool state)
        {
            CPS_NumericUpDown.Enabled = state;

            LeftClick_RadioButton.Enabled = state;
            MiddleClick_RadioButton.Enabled = state;
            RightClick_RadioButton.Enabled = state;
            Custom_RadioButton.Enabled = state;

            Toggle_CheckBox.Enabled = state;

            ChangeHotkey_Button.Enabled = state;
            Custom_Button.Enabled = state;
        }
        #endregion
    }
}
