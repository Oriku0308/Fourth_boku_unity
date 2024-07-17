using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GunController : MonoBehaviour
{
    //[SerializeField] 
    GameObject m_bulletPrefab = default;
    [SerializeField] Transform m_muzzle = default;
    [SerializeField] GameObject[] _shells;

    int Shellnum = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(m_bulletPrefab );
            //GameObject newObject = Instantiate(m_bulletPrefab);
            GameObject newObject = Instantiate(_shells[Shellnum]);
            newObject.transform.position = m_muzzle.position;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Shellnum++;
            if (Shellnum == 3)
            {
                Shellnum = 0;
            }
            m_bulletPrefab = _shells[Shellnum];
        }
    }
}
