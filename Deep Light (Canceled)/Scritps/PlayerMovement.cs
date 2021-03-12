using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rBody;

    bool isfacingRight = true;

    float horizontal;
    float vertical;

    public float runSpeed = 5.0f;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        moveInput();

        flip();
    }

    private void FixedUpdate()
    {
        move();
    }

    public void moveInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    public void move()
    {
        rBody.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    public void flip()
    {
        if(Input.GetKey(KeyCode.RightArrow) && !isfacingRight)
        {
            transform.Rotate(0f, 180f, 0f);

            isfacingRight = !isfacingRight;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && isfacingRight)
        {
            transform.Rotate(0f, 180f, 0f);

            isfacingRight = !isfacingRight;
        }
    }
}
