using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;
    public double test;
    SpriteRenderer sr;
    
    Vector2 mousePos;

    Vector2 movement;
    void Start()
    {
        
        
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
       

        mousePos = Input.mousePosition;
        Vector2 mousePosDelta = mousePos;
        if (mousePosDelta.x < 390)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

        test = Math.Sin(45.0);
        //Debug.Log(Input.mousePosition);
        Debug.Log(test);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
