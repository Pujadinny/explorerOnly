using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActiviation : MonoBehaviour
{
    public DoorMoviment door;


    private void Start()
    {

        door = GetComponent<DoorMoviment>(); //Script de la plataforma -- PlatformMoviment

    }
    private void OnTriggerEnter(Collider trigger) //Trigger que té el cubu
    {

        MourePorta();


    }

    public void MourePorta()
    {  

        door.MovimentPorta();   //quan el cubu rebi el trigger activa la variable de Moviment de Plataforma

    }
}
