using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoviment : MonoBehaviour
{
    private Animator animacion;


    void Start()
    {

        animacion = GetComponent<Animator>();

    }


    // Variable activar la Plataforma 
    public void MovimentPorta()
    {
        animacion.SetInteger("Status", 1);
    }
}
