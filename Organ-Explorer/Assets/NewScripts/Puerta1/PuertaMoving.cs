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
        MoureDoor(); //Al tocar el botó executa la següent funció
    }

    public void MoureDoor()
    {

        move.Movedoor1();  //Fa que l'altre script passi el status de la porta a 1
    }
}
