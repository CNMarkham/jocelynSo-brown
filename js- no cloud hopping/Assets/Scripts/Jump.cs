using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Rigidbody2D rigidbody;

    float jumpforce = 15;

    public bool canJump;
    // Start is calleyd before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.y > -.01 && rigidbody.velocity.y <.01)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if (canJump && Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }

    }
}
