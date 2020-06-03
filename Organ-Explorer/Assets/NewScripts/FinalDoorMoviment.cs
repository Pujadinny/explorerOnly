using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorMoviment : MonoBehaviour
{
    private Animator finanima;
    void Start()
    {
        finanima = GetComponent<Animator>();
    }


    public void OnTriggerEnter(Collider finaltriger)
    {
        MoviPortaFinal();
    }
    public void MoviPortaFinal()
    {
        finanima.SetInteger("Status", 1);
    }
}
