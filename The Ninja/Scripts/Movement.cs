using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;
    [SerializeField] public float jumpHeight = 5f;
    [SerializeField] public float slideSpeed = 15f;
    [SerializeField] public float slideJumpHeight = 1f;

    public static Movement instace;
  
    public Rigidbody2D rb;

    public Animator animator;

    public GameObject GameOverText, Restart, YourScore;




    Vector3 abc = new Vector3(5f, 20f, 0);



    // variables used to check
    public bool isGrounded = false;
    public bool isfacingright = true;
    public bool isSliding = false;


    void Start()
    {
        instace = this;

        GameOverText.SetActive(false);
        Restart.SetActive(false);
        YourScore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemynum.currentnum >= 5)
        {
            Destroyme();
        }
        float speed = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("Speed", Mathf.Abs(speed));
      

        Jump();

        move();

        flip();

        jumpanimation();


            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || 
                Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                animator.SetBool("Attacking", false);

            }

    }

    public void move() //moving code
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    public void Jump() //jumping code
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }

    }

    public void flip() //for the character to flip when moving
    {
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && isfacingright == false && isSliding == false)
        {
            transform.Rotate(0f, 180f, 0f);

            isfacingright = !isfacingright;
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && isfacingright == true && isSliding == false)
        {
            transform.Rotate(0f, 180f, 0f);

            isfacingright = !isfacingright;
        }

    }

    public void jumpanimation()
    {
        if (isGrounded)
        {
            animator.SetBool("isJumping", false);
        }
    }

    private void Destroyme()
    {
        GameOverText.SetActive(true);
        Restart.SetActive(true);
        YourScore.SetActive(true);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("lavafloor"))
        {
            Destroyme();
        }
    }
 


}



