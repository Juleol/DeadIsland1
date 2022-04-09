using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAimWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform aimTransform;
    public Animator aimAnimator;
    public GameObject gameOverText;
    Object bulletRef;
    [SerializeField]
    private GameObject[] ammo;
    public int ammoAmount = 6;



    void Start()
    {
        gameOverText.SetActive(false);
        //        NOAMMOText = GetComponent<Text>();
        for (int i = 0; i <= 5; i++)
        {
            ammo[i].gameObject.SetActive(true);
        }
        ammoAmount = 6;
    }
    private void Awake()
    {

                 //   int Ammo = GetComponent(Weapon).ammoAmount;

        aimTransform = transform.Find("Aim");
        aimAnimator = aimTransform.GetComponent<Animator>();

    }

    private void Update()
    {
        HandleAiming();
        HandleShooting();
        if (Input.GetButtonDown("Fire1") && ammoAmount > 0)
        {

            Shoot();
            ammoAmount -= 1;
            ammo[ammoAmount].gameObject.SetActive(false);
        }
        if (ammoAmount == 0)
        {
            gameOverText.SetActive(true);

        }
        if (Input.GetKey(KeyCode.R))
        {
            ammoAmount = 6;
            for (int i = 0; i <= 5; i++)
            {
                ammo[i].gameObject.SetActive(true);
                gameOverText.SetActive(false);

            }
            
        }

    }
    private void HandleShooting()
    {
        Vector3 mousePosition = World.GetMouseWorldPosition();

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }
    private void HandleAiming()
    {
        if (Input.GetMouseButtonDown(0))
        {
          if (ammoAmount > 0)
                {
                aimAnimator.SetTrigger("Shoot");

            }
          

        }
      
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

