using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject m_bulletPrefab = default;
    [SerializeField] Transform m_muzzle = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("‚±‚±‚É’e‚ğ”­Ë‚·‚éˆ—‚ğ‘‚­B");
            //Instantiate(m_bulletPrefab );
            GameObject newObject = Instantiate(m_bulletPrefab);
            newObject.transform.position = m_muzzle.position;
        }
    }
}
