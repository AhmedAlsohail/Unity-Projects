using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneSpawner : MonoBehaviour
{
    public bool isThereAclown = false;
    public Transform spawnPoint;

    public GameObject light;

    public GameObject clonePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !isThereAclown)
        {
            spawn();
        }

        spawnerHandler();

        lightHandler();
    }

    public void spawn()
    {
        Instantiate(clonePrefab, spawnPoint.position, spawnPoint.rotation);
        isThereAclown = true;
    }

    public void spawnerHandler()
    {
        if (Input.GetKeyDown(KeyCode.X) && isThereAclown)
        {
            isThereAclown = false;
        }
    }

    public void lightHandler()
    {
        if (isThereAclown)
        {
            light.SetActive(false);
        }
        else
        {
            light.SetActive(true);
        }
    }
}
