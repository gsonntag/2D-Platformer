using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Vector2 movementVector;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = movementVector;
    }

    void OnMove(InputValue value)
    {
        movementVector = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(0, 2000));
    }
}
