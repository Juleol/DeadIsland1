using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	private SpriteRenderer playerSprite;

	public HealthBar healthBar;

	// Start is called before the first frame update
	public void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		playerSprite = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	public void Update()
	{
		// if (Input.GetKeyDown(KeyCode.Space)) 
		// {
		// 	TakeDamage(20);
		// }
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		
		healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
		gameObject.SetActive(false);
		}
		StartCoroutine("HurtColor");
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
}

		
	
	
