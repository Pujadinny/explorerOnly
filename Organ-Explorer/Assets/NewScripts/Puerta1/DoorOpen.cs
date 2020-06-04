using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anime;
    void Start()
    {
        anime = GetComponent<Animator>(); //Cridas al animator 
    }


    public void Movedoor1()
    {

        anime.SetInteger("Status",1); //Fas que el status de la porta passi a 1 (que fa que es mogui)

    }
}
