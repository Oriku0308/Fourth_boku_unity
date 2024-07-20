using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalShell : Shell
{
    public int _maxHit = 1;
    public void Start()
    {
        First();
        DestroyTime();
        Speed();
    }
}
