using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float speed = 8;
    public float beschleunigungSpeed;
    public float bremsSpeed;
    public bool sollHalt;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the train should breake.
        if (sollHalt == false)
        {
            //if not the train drives with the Beschleunigung in order  to  get faster from a stop. 
             transform.Translate(Vector3.forward * Time.deltaTime * Beschleunigung() );
        }
        else 
        {
            Debug.Log("Halt");

            //if the next station gets closer the train still moves forward but with decreasing speed. 
            transform.Translate(Vector3.forward * Time.deltaTime * Break() );
        }
       
    }

    float Beschleunigung ()
    {
        // A simple way to fasten the speed. 200 is the max speed for now.
        if (speed <= 200)
        {
            speed = speed * beschleunigungSpeed;
        }
        return speed;
    }

     
    float Break ()
    {
        // A simple way to lower the speed until the train has come to a stop.
        if (speed >= 5){
            speed = speed * bremsSpeed;
        }
        else {
            speed = 0;
        }
        
        return speed;
    }
}
