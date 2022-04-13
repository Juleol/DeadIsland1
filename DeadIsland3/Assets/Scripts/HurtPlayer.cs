using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtPlayer : MonoBehaviour
{
    public float waitToHurt = 2f;
    public bool isTouching;
    private PlayerHealth health;
    [SerializeField]
    private int damageToGive = 10;
  
    // Start is called before the first frame update
    void Start()
    {
        health = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouching)
        {
            waitToHurt -= Time.deltaTime;
            if (waitToHurt <= 0)
            {
                //gameObject.GetComponent<PlayerHealth>().TakeDamage(damageToGive);
                health.TakeDamage(damageToGive);
                waitToHurt = 2f;

            }
          

        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageToGive);



            //other.gameObject.SetActive(false);
            //  reloading = true;
            //   SceneManager.LoadScene("Menu");

        }
        
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            isTouching = true;
            

        }
    }
    

       
        

    }

    

