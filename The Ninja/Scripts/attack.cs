using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    public float currenattack = 1f;
    public Animator animator;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<weapon>().CooldownCounter <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                animator.SetBool("Attacking", true);
                animator.SetFloat("attacku", 1.02f);
            }

            if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Mouse0)) && currenattack == 1)
            {
                currenattack = 2f;
                animator.SetBool("attako", true);
            }
            else
            if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Mouse0)) && currenattack == 2)
            {
                animator.SetBool("attako", false);
                currenattack = 1f;
            }

            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                animator.SetBool("isJumping", true);
            }
        }
    }
}
