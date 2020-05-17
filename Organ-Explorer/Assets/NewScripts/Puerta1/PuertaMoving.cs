using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaMoving : MonoBehaviour
{
    public  DoorOpen move; 

    private void Start()
    {
        move = GetComponent<DoorOpen>();
    }

    private void OnTriggerEnter(Collider trigger)
    {
        MoureDoor();
    }

    public void MoureDoor()
    {

        move.Movedoor1();
    }
}
