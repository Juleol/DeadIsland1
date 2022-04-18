using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    public int health = 100;
    public GameObject deathEffect;
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            ScoreScript.scoreValue += 10;
            Counter.enemiesValue -= 1;
        }
    }

    // Start is called before the first frame update
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
   
     
}