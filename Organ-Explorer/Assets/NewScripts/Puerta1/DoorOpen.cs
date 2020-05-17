using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anime;
    void Start()
    {
        anime = GetComponent<Animator>();
    }


    public void Movedoor1()
    {

        anime.SetInteger("Status",1);

    }
}
