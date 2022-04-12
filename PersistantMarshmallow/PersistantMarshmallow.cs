using System;
using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace PersistantMarshmallow
{
    public class PersistantMarshmallow : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"{nameof(PersistantMarshmallow)} is loaded!", MessageType.Success);

            ModHelper.HarmonyHelper.AddPostfix<RoastingStickController>("Awake", typeof(PersistantMarshmallow), "RoastingStickAwakePostfix");
        }

        public static void RoastingStickAwakePostfix(RoastingStickController __instance)
        {
            SelfDestruct selfDestruct = __instance._mallowBodyPrefab.GetComponent<SelfDestruct>();
            selfDestruct.enabled = false;
        }

    }
}
