using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCount : MonoBehaviour
{
    bool _1 = true;
    bool _2 = false;
    int _spaceCount = 0;
    int _12Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _spaceCount++;
            Debug.Log(_spaceCount);
        }
        if(_1 == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            _1 = false;
            _2 = true;
        }
        if(_2 == true && Input.GetKeyDown(KeyCode.Alpha2))
        {
            _12Count++;
            Debug.Log(_12Count);
            _1 = true;
            _2 = false;
        }
    }
}
