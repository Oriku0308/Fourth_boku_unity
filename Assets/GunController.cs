using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GunController : MonoBehaviour
{
    GameObject m_bulletPrefab = default;
    [SerializeField] Transform m_muzzle = default;
    [SerializeField] GameObject[] _shells;

    int Shellnum = 0;
    int _length;

    // Start is called before the first frame update
    public void Start()
    {
        _length = _shells.Length;
    }

    // Update is called once per frame
    public void Update()
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
            if (Shellnum == _length)
            {
                Shellnum = 0;
            }
            m_bulletPrefab = _shells[Shellnum];
        }
    }
}
