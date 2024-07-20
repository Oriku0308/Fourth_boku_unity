using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PenetreteShell : Shell
{
    public void Start()
    {
        First();
        DestroyTime();
        Speed();
    }
}
