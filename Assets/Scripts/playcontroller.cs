using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playcontroller : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementvalue)
    {
        Vector2 movementvector = movementvalue.Get<Vector2>();

        movementX = movementvector.x;
        movementY = movementvector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
}
