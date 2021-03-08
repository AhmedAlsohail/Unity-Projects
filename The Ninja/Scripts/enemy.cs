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
            enemynum.currentnum--;
        }

    }

    private void Die()
    {
       // Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
