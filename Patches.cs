using HarmonyLib;
using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AlwaysRunning
{
    class Patches
    {
        [HarmonyPatch(typeof(PlayerCtrl), "Walking")]
        [HarmonyPrefix]
        static bool Walking_Prefix(PlayerCtrl __instance)
        {
            if (__instance.m_reqAction != 0)
            {
                __instance.RequestAction();
            }
            else
            {
                float speed = Plugin.Instance.runningSpeed.Value;

                if (PadManager.IsInput(PadManager.BUTTON.bCross))
                    speed = Plugin.Instance.walkingSpeed.Value;

                __instance.m_move.SetAccelerationRate(speed);
                __instance.m_isMoved = __instance.m_move.SetPlayerMove();
                __instance.LookAtSomethingOnField();
            }
            return false;
        }
    }
}
