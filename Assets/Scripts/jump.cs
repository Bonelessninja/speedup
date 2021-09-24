using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class jump : MonoBehaviour
{

    public float speed = 5f;
    public float jumpspeed = 5000f;

    Rigidbody rb;
    bool canjump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //checking if player is on the floor. if so, player can jump, else he cannot. the floor or any object from where you want the player to

    private void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.tag == "floor")
        {
            canjump = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            canjump = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //movement script

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0f, 0f, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0f, 0f, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed * Time.deltaTime, 0f, 0f);
        }

// jumping script. player can jump only when canjump is true (means when the player is on the floor)
        if (Input.GetKey(KeyCode.Space) & canjump)
        {
            rb.AddForce(0f, jumpspeed * Time.deltaTime, 0f);
        }
    }
}
