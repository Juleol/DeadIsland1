using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;
    public float test;
    public Animator animator;
    SpriteRenderer sr;
    

    Vector2 mousePos;

    Vector2 movement;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
      


        movement.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movement.x));

        movement.y = Input.GetAxisRaw("Vertical");

        Vector2 lookDir = mousePos - rb.position;


        if (lookDir.x < 0f)
        {
            sr.flipX = true;
        } 
        else if (lookDir.x > 0f)
        {
            sr.flipX = false;
        }

        //Debug.Log(Input.mousePosition);
        //Debug.Log(mouseAngle);
        //float mouseAngle = Vector2.Angle(mousePos, rb.position );
        //Vector2 mousePosDelta = mousePos;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
