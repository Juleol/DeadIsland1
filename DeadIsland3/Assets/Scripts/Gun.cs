using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody2D rb; 
    public Camera cam;
    public SpriteRenderer sr;
    public Transform tf;
    public Transform pltf;

    Vector2 mousePos;

    void start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position; 
        if (lookDir.x > 0f)
        {
            transform.position = new Vector3(pltf.position.x + 0.0f, pltf.position.y, pltf.position.z);
            sr.flipY = false;
        }
        else if (lookDir.x < 0f)
        {
            transform.position = new Vector3(pltf.position.x - 0.0f, pltf.position.y, pltf.position.z);
            sr.flipY = true;
        }
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        
    }
}
