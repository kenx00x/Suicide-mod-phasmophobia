using MelonLoader;
using UnityEngine.InputSystem;

namespace Suicide
{
    public class Main : MelonMod
    {
        InputAction SuicideAction = new InputAction("Suicide", binding: "<Keyboard>/p");
        public override void OnUpdate()
        {
            base.OnUpdate();
            if (SuicideAction.triggered)
            {
                MelonLogger.Log("suicide");
                Player localplayer = GameController.instance.myPlayer.player;
                localplayer.StartKillingPlayerNetworked();
                //currently the dead body doesnt spawn :(
                localplayer.SpawnDeadBody();
                localplayer.KillPlayer();
            }
        }
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Log("Suicide mod loaded!");
            SuicideAction.Enable();
        }
    }
}
