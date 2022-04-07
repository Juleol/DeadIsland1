using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtPlayer : MonoBehaviour
{
    private float waitToLoad = 2f;
    private bool reloading;
    public float waitToHurt = 2f;
    public bool isTouching;
  
    [SerializeField]
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(reloading)
        {
            waitToLoad -= Time.deltaTime;
            if (waitToLoad <= 0)
            {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(25);


            waitToHurt -= Time.deltaTime;
            waitToLoad -= Time.deltaTime;

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
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            isTouching = false;
            waitToHurt = 2f;

        }
    }
}
    

