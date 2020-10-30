using MelonLoader;
using UnityEngine.InputSystem;
namespace Suicide
{
    public class Main : MelonMod
    {
        readonly InputAction SuicideAction = new InputAction("Suicide", binding: "<Keyboard>/p");
        public override void OnUpdate()
        {
            if (SuicideAction.triggered)
            {
                MelonLogger.Log("suicide");
                //old unobfuscated code
                //Player localplayer = GameController.instance.myPlayer.player;
                Player localplayer = Helpers.GetLocalPlayer();
                localplayer.StartCoroutine_Auto(localplayer.Method_Private_IEnumerator_PDM_0());
                localplayer.StartKillingPlayerNetworked();
                localplayer.KillPlayer();
            }
        }
        public override void OnApplicationStart()
        {
            MelonLogger.Log("Suicide mod loaded!");
            SuicideAction.Enable();
        }
    }
}