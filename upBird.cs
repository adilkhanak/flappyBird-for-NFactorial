using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upBird : MonoBehaviour
{
    public GameManager gameManager;
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameManager.GameOver();
    }
   
}
