using System;
using System.Windows.Forms;
using GTA;
using GTA.UI;

namespace MyMod
{
    public class MainScript:Script
    {
        public MainScript()
        {
            Tick += OnTick;
            KeyUp += OnKeyUp;
            KeyDown += OnKeyDown;

            Notification.Show("~g~MainScript Activated\n~w~Press F5 to Try");
        }

        private void OnTick(object sender, EventArgs e)
        {

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                Notification.Show("F5 Pressed!");
            }
        }
    }
}
