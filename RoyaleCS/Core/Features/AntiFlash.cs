﻿using RoyaleCS.Core.Handlers;
using System.Windows.Input;

namespace RoyaleCS.Core.Functions
{
    internal class AntiFlash : InitializeHandler
    {
        private bool enabled;



        internal AntiFlash(bool enabled)
        {
            this.enabled = enabled;
        }



        protected override void OnEnable() => Main.Instance.Listener.SetOnKeyPressed(Main.Instance.Listener.GetOnKeyPressed() + onKeyDown);



        protected override void OnDisable() => Main.Instance.Listener.SetOnKeyPressed(Main.Instance.Listener.GetOnKeyPressed() - onKeyDown);



        private void onKeyDown(Key key)
        {
            if (WindowHandler.TryGetCSGOWindow())
            {
                if (key == Key.J)
                {
                    if (enabled = !enabled) Player.SetFlashAlpha(.0f);

                    else Player.SetFlashAlphaByDefault();
                }
            }
        }
    }
}