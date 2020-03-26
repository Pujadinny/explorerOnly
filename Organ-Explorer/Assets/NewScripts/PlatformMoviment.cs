using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoviment : MonoBehaviour  //SCRIPT ASSIGNAT A LA PLATAFORMA
{ 
      private Animator animacion;

    
    void Start()
    {
        
        animacion = GetComponent<Animator>();

    }

 
    // Variable activar la Plataforma 
    public void MovimentPlataforma()
    {
        animacion.SetInteger("Status",1);
    }
}
