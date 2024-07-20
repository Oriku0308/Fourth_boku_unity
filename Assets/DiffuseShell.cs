using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diffuse : Shell
{
    float a = 0.01f;
    public void Start()
    {
        First();
        DestroyTime();
        //Speed();
    }
    private void FixedUpdate()
    {
        m_speed += 0.01f;

        Speed();
    }

    public override void Speed()
    {
        float sin = Mathf.Sin(Time.timeSinceLevelLoad) + m_speed;
        this.rb.velocity = new Vector2(a *= m_speed, sin );
    }
}
