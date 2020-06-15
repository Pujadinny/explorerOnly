using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llum : MonoBehaviour
{
    public Light llum;
    public bool Onllum = false;

    public void Start()
    {

        Luz(llum);
        
    }

    public void Luz (Light llinterna)
    {
        if (llinterna  && !Onllum)
        {
            llum.enabled = true;
            Onllum = true;
        }
        else if (llinterna && Onllum)
        {
            llum.enabled = false;
            Onllum = false;
        }

    }
}

