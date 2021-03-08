using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{

    [SerializeField] public int damage = 20;
    enemy enemy;
    //public GameObject impacteffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemy = hitInfo.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.takedamage(damage);
        }

       // Instantiate(impacteffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
