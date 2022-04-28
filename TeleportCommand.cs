using Harmony;

[HarmonyPatch(typeof(ConsoleCommands), "Teleport")]
public class TeleportCommand
{
    public static bool Prefix()
    {
        if (NetworkManager.instance.mClientThread != null)
        {
            Player player = NetworkManager.instance.mClientThread.mPlayer;
            if (player != null)
            {
                if (player.mBuildPermission == eBuildPermission.Admin)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
