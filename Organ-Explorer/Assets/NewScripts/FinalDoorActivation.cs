using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorActivation : MonoBehaviour
{
    public FinalDoorMoviment portafinal;


     void Start()
    {
        portafinal = GetComponent<FinalDoorMoviment>();

    }

    public void OnTriggerEnter(Collider other)
    {
        MourePortaFinal();

    }

    public void MourePortaFinal()
    {
       
        portafinal.MoviPortaFinal();

    }



}
