using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;

namespace AutoClicker
{
    enum ClickType
    {
        toggle,
        hold,
    }

    internal class AutoClicker
    {
        private bool m_MasterActivation = false;
        public bool MasterActivation
        {
            get
            {
                return m_MasterActivation;
            }
            set
            {
                toggleSystem_Active = false;
                m_MasterActivation = value;
            }
        }

        public ushort TargettetCPS { get; set; } = 10;

        private bool toggleSystem_Active = false;
        private bool toggleSystem_AvailableToChange = false;





        public ClickType ClickType { get; set; } = ClickType.hold;


        public VirtualKeyCode KeyToClick { get; set; }
        public VirtualKeyCode TriggerKey { get; set; }



        private readonly Thread AutoClickerThread;



        public AutoClicker()
        {
            AutoClickerThread = new Thread(new ThreadStart(AutoClick))
            {
                IsBackground = true,
            };
            AutoClickerThread.Start();
        }


        private readonly InputSimulator InputSimulator = new InputSimulator();

        private void AutoClick()
        {
            DateTime lastTrigger = DateTime.Now;


            while (true)
            {
                TimeSpan difference = DateTime.Now - lastTrigger;
                TimeSpan delay = TimeSpan.FromMilliseconds(1000 / TargettetCPS);
                if (difference < delay)
                    Task.Delay(delay - difference).Wait();

                lastTrigger += delay;
                switch (ClickType)
                {
                    case ClickType.toggle:
                        if (InputSimulator.InputDeviceState.IsKeyDown(TriggerKey))
                        {
                            if (toggleSystem_AvailableToChange)
                            {
                                toggleSystem_AvailableToChange = false;

                                toggleSystem_Active = !toggleSystem_Active;
                            }
                        }
                        else
                        {
                            toggleSystem_AvailableToChange = true;
                        }

                        if (MasterActivation && toggleSystem_Active)
                            Click();

                        break;

                    case ClickType.hold:
                        if (MasterActivation && InputSimulator.InputDeviceState.IsKeyDown(TriggerKey))
                            Click();
                        break;
                }
            }
        }

        private void Click()
        {
            switch (KeyToClick)
            {
                default:
                    InputSimulator.Keyboard.KeyPress(KeyToClick);
                    break;

                case VirtualKeyCode.LBUTTON:
                    InputSimulator.Mouse.LeftButtonClick();
                    break;

                case VirtualKeyCode.MBUTTON:
                    InputSimulator.Mouse.MiddleButtonClick();
                    break;

                case VirtualKeyCode.RBUTTON:
                    InputSimulator.Mouse.RightButtonClick();
                    break;

            }
        }
    }
}
