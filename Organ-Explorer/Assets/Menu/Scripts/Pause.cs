using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isActive;  // variable bool 
    public Canvas canva; //variable que agafa el canvas
    void Start()
    { 
        canva = GetComponent<Canvas>(); 
        canva.enabled = false;

    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))   // si la tecla ESC és activada 
        { 
            isActive = !isActive;   //la variable bool és activada tant com si com no.
            canva.enabled = isActive; //llavors aquesta variable del canvas que està falça, gracies al isActive passa a ser true;
            Time.timeScale = (isActive) ? 0 : 1f; //aqui para el temps en el joc;
        }
    }

   // public void OffCanvas()
   // {
     //   isActive = !isActive;
     //   canva.enabled = !isActive;
    //    Time.timeScale = (isActive) ? 1 : 1f;
    //}
}
