using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llum : MonoBehaviour
{
    public GameObject llum;
    public bool Onllum = false;

    public void Start()
    {

        Luz(gameObject);
        
    }

    public void Luz (GameObject a)
    {
        if (a && !Onllum)
        {
            llum.SetActive (true);
            Onllum = true;
        }
        else if (a && Onllum)
        {
            llum.SetActive (false);
            Onllum = false;
        }

    }
}

