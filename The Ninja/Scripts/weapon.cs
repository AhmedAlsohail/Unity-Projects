using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject hitbox;
    public Transform attackpoint;
    [SerializeField] AudioClip attacksound;

    float attackCooldown = 0.5f;
    public float CooldownCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Mouse0)) && CooldownCounter <= 0)
        {
            Instantiate(hitbox, attackpoint.position, attackpoint.rotation);
            AudioSource.PlayClipAtPoint(attacksound, Camera.main.transform.position);
            CooldownCounter = attackCooldown;
        }
        else if (CooldownCounter > 0)
        {
            CooldownCounter -= Time.deltaTime;
        }

    }
}
