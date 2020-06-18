using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioCanvas : MonoBehaviour {

    public GameObject Inventario;

    private void Start ()
    {
        Inventario.SetActive (false);
    }
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            Inventario.SetActive(!Inventario.activeInHierarchy);
            //Cursor.visible = false ? true: false;
            
        }

      

    }
}
