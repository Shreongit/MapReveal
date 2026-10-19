using System;
using GTA;
using GTA.Native;

namespace MapReveal
{
    public class MapRevealScript : Script
    {
        private bool mapRevealed = false;

        public MapRevealScript()
        {
            Tick += OnTick;
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (mapRevealed)
                return;

            Function.Call(
                (Hash)0xF8DEE0A5600CBB93,
                true
            );

            mapRevealed = true;
        }
    }
}