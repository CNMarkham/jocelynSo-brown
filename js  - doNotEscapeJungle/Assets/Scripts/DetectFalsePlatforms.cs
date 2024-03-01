using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    public bool hit;

    public LayerMask layermask;

    void Update()
    {
        hit = Physics.Raycast(transform.position, Vector3.forward, 10, layermask);

       
        if (hit)
        {
            Debug.LogWarning("Be careful.");
        } else
        {
            Debug.LogWarning("All clear.");
        }
    }
}
