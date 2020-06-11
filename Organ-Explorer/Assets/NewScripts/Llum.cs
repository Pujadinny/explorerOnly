using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Llum : MonoBehaviour
{
    public  GameObject llum;
    public bool Onllum;

    public void Start()
    {
        llum.gameObject.GetComponent<Light>();
        Onllum = true;
    }

    public void Luz()
    {
        if (Onllum == false)
        {

            llum.SetActive(true);
        }
        else  
        {
            llum.SetActive(false);
        }
        
    }
    
    


}
    // Update is called once per frame

