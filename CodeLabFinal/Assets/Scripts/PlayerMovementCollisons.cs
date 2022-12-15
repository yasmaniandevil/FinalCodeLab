using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCollisons : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();
    }

    private void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }


    void MovementInput()
    {
        float mx = Input.GetAxisRaw("Horizontal");

        movement = new Vector2(mx, 0).normalized;
    }
}
