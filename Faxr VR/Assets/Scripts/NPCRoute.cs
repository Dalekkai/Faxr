using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRoute : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (pivotPoint == 4)
            {
                pivotPoint = 0;

            }
            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-7, 43, 918);
                pivotPoint = 4;

            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(6, 43, 918);
                pivotPoint = 3;

            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(6, 43, 922);
                pivotPoint = 2;

            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-7, 43, 922);
                pivotPoint = 1;

            }
            

        }
    }
}
