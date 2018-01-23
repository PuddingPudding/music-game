using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private bool isCanJump = false;
    public float speed = 3f;
    public Collider2D jumpSensor;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 finalSpeed = this.rigidbody.velocity;
        finalSpeed.x = 0;

        if(Input.GetKey(KeyCode.LeftArrow) )
        {
            finalSpeed += Vector2.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            finalSpeed += Vector2.right * speed;
        }

        if(jumpSensor.IsTouchingLayers(LayerMask.GetMask("Terrian") ) )
        {
            this.isCanJump = true;
        }
        else
        {
            this.isCanJump = false;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && this.isCanJump)
        {
            finalSpeed += Vector2.up * speed;
        }

        this.rigidbody.velocity = finalSpeed;
    }
}
