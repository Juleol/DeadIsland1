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
    public int damageToGive;
  
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
                    health.TakeDamage(damageToGive);
                    waitToHurt = 2f;
                }

                //gameObject.GetComponent<PlayerHealth>().TakeDamage(damageToGive);
             
      

        }
       

    }
   
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            //     if (gameObject.GetComponent<PlayerHealth>().maxHealth >= 0)
            //     {
            isTouching = true;

                other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageToGive);
            //   }
            //if (gameObject.GetComponent<PlayerHealth>().currentHealth <= 0)
            //{
            //       isTouching = false;
            //  other.gameObject.GetComponent<PlayerHealth>().TakeDamage(0);

            // GameObject.Find("Slime(Clone)").GetComponent<HurtPlayer>().enabled = false;
        }
     


           
      
        



        }




        //other.gameObject.SetActive(false);
        //  reloading = true;
        //   SceneManager.LoadScene("Menu");

    }

  
        

    
 
   
    

       
        

    

    

