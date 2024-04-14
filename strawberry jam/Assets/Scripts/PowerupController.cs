using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupController : MonoBehaviour
{
    // variables for nextDrop 
    // (initial float means first powerup spawns 15 seconds in)
    // dropRate is how often powerups are made
    // powerup holds the powerup
    private float nextDrop = 15.0f;
    public float dropRate;
    public GameObject powerup;
    public GameObject powerupEmitter;
    private GameObject player;
    private PlayerControls playerController;

    void Start()
    {
        // powerupEmitter and player are assigned 
        // their corresponding objects in the scene
        powerupEmitter = GameObject.Find("PowerupEmitter");
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerControls>();
    }

    void Update()
    {
        // Null check for gameOver state
        if (playerController.gameOver)
        {
            return;
        }

        // At the interval decided by dropRate, 
        //    powerupPoosition is set to a random x from -6 to 6
        // above the game the powerupEmitter itself is moved to that position, 
        //   and the nextDrop is set
        // a powerup is instantiated at the emitter's position and rotation

        if (Time.time > nextDrop)
        {
            float randomX = Random.Range(-6.0f, 6.0f);
            Vector3 powerupPosition = new Vector3(randomX, 6.0f, 0.0f);
            transform.position = powerupPosition;
            nextDrop = Time.time + dropRate;

            /*****************************\
            |**** Add your code below ****|
            \*****************************/

            Instantiate(powerup, transform.position, transform.rotation);
            //it creates smth , powerup thingie in this one.
            /*****************************\
            |**** Add your code above ****|
            \*****************************/
        }
    }
}





//for (int i= -3 ; i>17 , i += 3){
//    tranform.Translate(Vector3.forward)
//{  

// (0,0,0)
// the answer is (0,0,0) because in the () brackets when it says "i>17" , i know that "i" equals to -3, and as a for loop works , there are 3 statments. the first part is 
// the inital value, which can be any number, the number in the question being -3. For the second statment it says as "i>17". and aslong as the condition is true 
// the code will run. but in this case its not. As for the third statment, the increment tells you how much you increase or decrease the inital varible by each time.
// thus, giving the answer (0,0,0).  



// this answers imposible. the code is completely fine but its just the question at the end. the code is giving the object a force. in this case making it move forward. 
// we cant tell the position because the for loop only repeates one time, basing off the 3 statements of it. the first statment giving us the inital value of i = 0.
// moving onto the second statement it tells us that i , being 0 , is less than 1. which is true. therfore we move onto the third statement, the increment tells you
// how much to decrease or increase the inital varible, in our case, we add 3 everytime, giving us only one repeated code because then 0+3 makes it larger than one.
// making the code stop. after reveiwing the for loop brackets, you can tell it only repeats one time now. to go back to the question, its impossible to answer because 
// after the game object is being pushed , the x , y , z , position constanly changes , and will keep moving till the game stops. this is due to the fact that the
// ".addForce" statment dosent clarify or give a direct position when the game object should stop moving, additonally, it moves forward as the code says "Vector3.Forward",
// giving it velocity, which is the same thing as speed but has direction . therfore, it is impossible to find the position afterwards. 
