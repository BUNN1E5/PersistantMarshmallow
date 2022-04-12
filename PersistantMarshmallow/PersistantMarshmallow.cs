using OWML.Common;
using OWML.ModHelper;

namespace PersistantMarshmallow
{
    public class PersistantMarshmallow : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"{nameof(PersistantMarshmallow)} is loaded!", MessageType.Success);

            ModHelper.HarmonyHelper.AddPrefix<Marshmallow>("Shrivel", typeof(PersistantMarshmallow), "Shrivel");
        }

        public static bool Shrivel(Marshmallow __instance) {
            return false;
        }
        
    }
}
