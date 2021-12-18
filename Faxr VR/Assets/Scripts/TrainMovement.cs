using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 500f; // The variable for the train speed.
    bool sollHalt = false; // Checks if the train needs to stop.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
      Schaffner(); 
    }

    void Schaffner()
   { // If the sollHalt bool is not true the drive method is called, if the bool is true, the break method is called.
     if (sollHalt)
     {
       Break();
     }
     Drive();
   }

    private void OnTriggerEnter(Collider other) 
    {
      sollHalt = true;  // Changes the bool if the stop collider is entered.
    }



   
    void Drive() 
    {
         rb.AddRelativeForce(Vector3.back * speed * Time.deltaTime); // Adds force to the rigid body to move forward (in this case back is forth).     
    }

    void Break() 
    {
         rb.velocity = Vector3.zero;  // A very ugly instant stop but it works. TODO
    }
    
}
