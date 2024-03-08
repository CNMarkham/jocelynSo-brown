using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public GameObject door;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            Destroy(coin);
            Destroy(door);
        }
    }
}
