using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaltChecker : MonoBehaviour
{
      public TrainMovement mover;
    private void OnTriggerEnter(Collider other) {
           mover.sollHalt = true;
    }
}
