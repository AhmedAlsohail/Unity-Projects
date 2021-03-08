using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    public float currenattack = 1f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("Attacking", true);
            animator.SetFloat("attacku", 1.02f);
        }

        if (Input.GetKeyDown(KeyCode.Z) &&  currenattack == 1)
        {
            currenattack = 2f;
            animator.SetBool("attako", true);
        }
        else
        if (Input.GetKeyDown(KeyCode.Z)  && currenattack == 2)
        {
            animator.SetBool("attako", false);
            currenattack = 1f;
        }

            if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }


      

      


    }
}
