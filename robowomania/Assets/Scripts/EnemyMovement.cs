using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;

    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= -8)
        {

        }

        if (transform.position.x >= 8)
        {

        }


        float newYPosition = transform.position.y;


    }
}


