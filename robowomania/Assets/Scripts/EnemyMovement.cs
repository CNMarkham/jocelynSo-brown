using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    public float yDirection;
    public float leftEdge;
    public float rightEdge;
    public Vector3 crush1;
    public Vector3 crush2;
    private Rigidbody2D enemyRigidBody;
    private Rigidbody2D playerRigidBody;
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (transform.position.x <= leftEdge)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }

        if (transform.position.x >= -leftEdge)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }

        if (transform.position.y >= 4)
        {
            yDirection = -1;
            enemyRigidBody.AddForce(Vector2.down * yForce);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);

        }
        if (collision.gameObject.tag == "Enemy")
        {

            crush1 = collision.gameObject.transform.position;
            crush2 = gameObject.transform.position;
            Vector3 direction = crush1 - crush2;
            enemyRigidBody.AddForce(-direction.normalized * 500f);
            //collision.gameObject.
        }


        if (collision.gameObject.tag == "Player")
        {
            playerRigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 pushForce = new Vector2(xForce * xDirection, yForce * yDirection);
            enemyRigidBody.AddForce(pushForce);
            playerRigidBody.AddForce(pushForce);
        }
    }

}

