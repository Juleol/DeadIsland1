using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;


    //    public Text NOAMMOText;


    [SerializeField]
    private GameObject[] ammo;
    public int ammoAmount = 6;

    // Update is called once per frame
    void Start()
    {
        //        NOAMMOText = GetComponent<Text>();
        for (int i = 0; i <= 5; i++)
        {
            ammo[i].gameObject.SetActive(true);
        }
        ammoAmount = 6;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoAmount > 0)
        {

            Shoot();
            ammoAmount -= 1;
            ammo[ammoAmount].gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            ammoAmount = 6;
            for (int i = 0; i <= 5; i++)
            {
                ammo[i].gameObject.SetActive(true);
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}


//   else
       // {
        //    NOAMMOText.gameObject.SetActive(false);
     //  }