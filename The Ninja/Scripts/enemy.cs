using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] public int enemyhealth = 100;

    //public GameObject deathEffect;

    public void takedamage(int damage)
    {
        enemyhealth -= damage;

        if (enemyhealth <= 0)
        {
            Die();
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("lavafloor"))
        {
            Die();
        }
    }

    private void Die()
    {
        enemynum.currentnum--;
        Destroy(gameObject);
    }
}
