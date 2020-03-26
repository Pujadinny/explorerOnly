using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasº: MonoBehaviour
{

    public GameObject Inventario;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Inventario.SetActive(!Inventario.activeInHierarchy);
        }
    }
}