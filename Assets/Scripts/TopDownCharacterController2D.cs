using UnityEngine;
using System.Collections;
public class TopDownCharacterController2D : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
        //X axis
        if (transform.position.x <= -13.84f)
        {
            transform.position = new Vector2(-13.84f, transform.position.y);
        }
        else if (transform.position.x >= 13.84f)
        {
            transform.position = new Vector2(13.84f, transform.position.y);
        }

        //Y axis
        if (transform.position.y <= -10.15f)
        {
            transform.position = new Vector2(transform.position.x, -10.15f);
        }
        else if (transform.position.y >= 10.15f)
        {
            transform.position = new Vector2(transform.position.x, 10.15f);
        }
    }
}