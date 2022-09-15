using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;  
    Animator playerAnimator; 
    public float moveSpeed = 3f;
    public float jumpSpeed = 230f, jumpFrequency = 0.1f, nextJumpTime;

    bool facingRight = true;  
    public bool isGrounded = false;
    public bool ciftZipla;

    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;

    private AudioSource audSrc;

    void Awake()
    {
        audSrc = GetComponent<AudioSource>();
    }

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();  
        playerAnimator = GetComponent<Animator>();
    }

    
    void Update() 
    {
        HorizontalMove();
        OnGroundCheck(); 

        if (playerRB.velocity.x < 0 && facingRight) 
        {
            FlipFace();
        }

        else if (playerRB.velocity.x > 0 && !facingRight) 
        {
            FlipFace();
        }

        if (Input.GetKeyDown (KeyCode.W) && (nextJumpTime < Time.timeSinceLevelLoad))
        {

            if (isGrounded == true)
            {
                playerRB.AddForce(Vector2.up * jumpSpeed);
                ciftZipla = true;
                nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
                audSrc.Play();
          
            } else{ 
                if (ciftZipla)
                {
                    ciftZipla = false; 
                    playerRB.AddForce(Vector2.up * jumpSpeed * 2 / 3); 
                    nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
                    audSrc.Play();
                }
          
            }    
        }
    }

    void HorizontalMove()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
        playerAnimator.SetFloat("PlayerSpeed", Mathf.Abs(playerRB.velocity.x));
    }

    void FlipFace()
    {
        facingRight = !facingRight; 
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale; 
    }

    void OnGroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer);
        playerAnimator.SetBool("isGroundedAnim", isGrounded); 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("platform"))
        {
            this.transform.parent = collision.transform;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("platform"))
        {
            this.transform.parent = null;
        }
    }
}
