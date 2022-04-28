﻿using Harmony;
using System.Reflection;

public class DisableTeleport : FortressCraftMod
{
    public HarmonyInstance mHarmony;

    public void Awake()
    {
        mHarmony = HarmonyInstance.Create("DisableTeleport");
        mHarmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    public override ModRegistrationData Register()
    {
        return new ModRegistrationData();
    }
}
