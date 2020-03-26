using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformActivation : MonoBehaviour  // SCRIPT ASSIGNAT AL CUBO

{
    public PlatformMoviment plat;
   

    private void Start()
    {
       
        plat = GetComponent<PlatformMoviment>(); //Script de la plataforma -- PlatformMoviment
    
    }
    private void OnTriggerEnter(Collider trigger) //Trigger que té el cubu
    {

        MourePlata();
        

    }

    public void MourePlata()
    {
        
        plat.MovimentPlataforma();   //quan el cubu rebi el trigger activa la variable de Moviment de Plataforma

    }
}
