using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivet : MonoBehaviour
{
    public GameObject myPlayer;

    private void FixedUpdate()
    {
        Vector3 diffrence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        diffrence.Normalize();

        float rotationZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if (rotationZ < -90 || rotationZ > 90)
        {
            if(myPlayer.transform.eulerAngles.y == 0)
            {
                transform.localRotation = Quaternion.Euler(180,0,-rotationZ);
            }

        }
    }

}
