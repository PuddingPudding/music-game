using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float speed = 3f;
    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float finalSpeedX = 0;

        if(Input.GetKey(KeyCode.LeftArrow) )
        {
            finalSpeedX += -1 * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            finalSpeedX += 1 * speed;
        }

        this.rigidbody.velocity = new Vector2(finalSpeedX , this.rigidbody.velocity.y);
    }
}
