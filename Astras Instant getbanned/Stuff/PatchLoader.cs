using HarmonyLib;

namespace AI_GT.Stuff;

public class PatchLoader
{
    public static void Apply()
    {
        Harmony VALLL = new Harmony(Constantss.GUID);
        VALLL.PatchAll();
    }
}