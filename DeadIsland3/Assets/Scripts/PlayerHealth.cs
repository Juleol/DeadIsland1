using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	private SpriteRenderer playerSprite;

	public HealthBar healthBar;
    public GameObject deathEffect, restartButton, gameOverText;
    public int A;
    public int B;


    // Start is called before the first frame update
    public void Start()
	{
        A = 0;
        B = -15;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		playerSprite = GetComponent<SpriteRenderer>();
        restartButton.SetActive(false);
        gameOverText.SetActive(false);


}


// Update is called once per frame
public void Update()
	{
     

        // if (Input.GetKeyDown(KeyCode.Space)) 
        // {
        // 	TakeDamage(20);
        // }
        // gameObject.SetActive(false);

    }

    public void TakeDamage(int damage)
	{
        currentHealth -= damage;
		
		healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            if (currentHealth >= -10)
            {
                gameObject.tag = "Untagged";
                Die();
                Invoke("DoSomething", 2);
            }

          
        }


            //  HurtPlayer.waitToHurt = 90f;
            //  gameObject.GetComponent<HurtPlayer>().waitToHurt = 10f;
            // HurtPlayer.damageToGive = 0;
            //GameObject.Find("Slime(Clone)").GetComponent<HurtPlayer>().enabled = false;
        
        StartCoroutine("HurtColor");

	}

   
   public void Die()
    {
        
        gameObject.SetActive(false);

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Counter.enemiesValue = 0;
     

    }
    IEnumerator HurtColor()
	{
		for (int i = 0; i < 3; i++)
		{
			GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f); //Red, Green, Blue, Alpha/Transparency
			yield return new WaitForSeconds(.1f);
			GetComponent<SpriteRenderer>().color = Color.white; //White is the default "color" for the sprite, if you're curious.
			yield return new WaitForSeconds(.1f);
		}
	}
    void DoSomething()
    {

        gameOverText.SetActive(true);
        restartButton.SetActive(true);

    }

}

		
	
	
