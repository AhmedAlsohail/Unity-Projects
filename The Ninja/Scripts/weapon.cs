using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject hitbox;
    public Transform attackpoint;
    [SerializeField] AudioClip attacksound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Instantiate(hitbox, attackpoint.position, attackpoint.rotation);
            AudioSource.PlayClipAtPoint(attacksound, Camera.main.transform.position);
        }
        
    }
}
