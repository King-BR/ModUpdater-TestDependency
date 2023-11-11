using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;

public class TestModUpdaterDependency : Mod
{
    public void Start()
    {
        Debug.Log("Mod TestModUpdaterDependency has been loaded!");
    }

    public void OnModUnload()
    {
        Debug.Log("Mod TestModUpdaterDependency has been unloaded!");
    }
}