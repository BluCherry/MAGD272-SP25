using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 3f;         // Movement speed of the player
    private float playerSpeed;       // Current horizontal speed
    public float jumpForce = 20f;   // Force applied when the player jumps

    Animator animator;          // Reference to the Animator component

    Rigidbody2D rigidbody2D;         // Reference to the Rigidbody2D component

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D component attached to this GameObject
        rigidbody2D = GetComponent<Rigidbody2D>();
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move left when A key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
            animator.SetBool("isRunning", true);
            if (transform.localScale.x > 0)
            {
                Vector3 newScale = transform.localScale;
                newScale.x *= -1;
                transform.localScale = newScale;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
        // Move right when D key is pressed
        else if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
            animator.SetBool("isRunning", true);
            if (transform.localScale.x < 0)
            {
                Vector3 newScale = transform.localScale;
                newScale.x *= -1;
                transform.localScale = newScale;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        // Stop when no key is pressed
        else
        {
            playerSpeed = 0;
            if (animator.GetBool("isRunning"))
            {
                animator.SetBool("isRunning", false);
            }
            if (animator.GetBool("isJumping"))
            {
                animator.SetBool("isJumping", false);
            }
        }

        // Set the Rigidbody2D's velocity based on playerSpeed, keeping the existing vertical velocity
        rigidbody2D.linearVelocity = new Vector2(playerSpeed, rigidbody2D.linearVelocity.y);
    }
}
