using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diffuse : Shell
{
    float a = 1f;
    public void Start()
    {
        First();
        DestroyTime();
        //Speed();
    }
    private void Update()
    {
        Speed();
    }

    public override void Speed()
    {
        float sin = Mathf.Sin(Time.time);
        this.transform.localPosition =  new Vector3(0, sin, 0);
    }
}