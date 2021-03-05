using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_Movement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;
    [SerializeField] public float jumpHeight = 2f;

    [SerializeField] public bool isGrounded = false;

    [SerializeField] public Text finalScore;
    public GameObject GameOverText, YourScore, Restart;


    public Animator animator;
    public bool isfacingright = true;

    public Rigidbody2D rb;

    [SerializeField] public float jumpTime;
    private float jumpTimeCounter;
    [SerializeField] private bool isJumping;
    void Start()
    {
        GameOverText.SetActive(false);
        YourScore.SetActive(false);
        Restart.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        move();

        flip();

        Jump();
    }

    public void move() //moving code
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            animator.SetBool("isMoving", true);
        else
            animator.SetBool("isMoving", false);

    }

    public void flip() //for the character to flip when moving
    {
        if (Input.GetKey(KeyCode.D) && isfacingright == false)
        {
            transform.Rotate(0f, 180f, 0f);

            isfacingright = !isfacingright;
        }

        if (Input.GetKey(KeyCode.A) && isfacingright == true)
        {
            transform.Rotate(0f, 180f, 0f);

            isfacingright = !isfacingright;
        }

    }

    public void Jump() //jumping code
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {

            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpHeight;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpHeight;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        }


        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if (isJumping == true)
            animator.SetBool("isJumping", true);

        else if (isJumping == false && isGrounded == true)
            animator.SetBool("isJumping", false);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("lavafloor"))
        {
            gameObject.SetActive(false);
            soundManager.playSound("playerDeath");

            GameOverText.SetActive(true);
            finalScore.text = "Your Score is: " + (int)Score.scoreValue;
            YourScore.SetActive(true);
            Restart.SetActive(true);
        }
    }
}
