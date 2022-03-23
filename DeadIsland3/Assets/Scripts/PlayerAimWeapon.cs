using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAimWeapon : MonoBehaviour
{
    private Transform aimTransform;
    private Animator aimAnimator;
    Object bulletRef;

  
    private void Awake()
    {
        aimTransform = transform.Find("Aim");
        aimAnimator = aimTransform.GetComponent<Animator>();
    }

    private void Update()
    {
        HandleAiming();
        HandleShooting();
       
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
            aimAnimator.SetTrigger("Shoot");

        }
    }
   }

