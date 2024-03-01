using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public ParticleSystem Pickup;
    void Start()
    {
        Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin")){
            score++; //++ adds one to the varible
            scoreText.text = score.ToString();
            Destroy(other.gameObject);

            Pickup.Play();
        }
    }
}
