using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); 
        Vector3 destination = new Vector3(horizontal, vertical, 1);
        transform.Translate(destination * speed * Time.deltaTime);
    }
}
