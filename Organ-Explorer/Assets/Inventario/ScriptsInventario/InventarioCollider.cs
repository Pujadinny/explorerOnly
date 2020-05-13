using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventarioCollider : MonoBehaviour  // Agregar objectes al inventari 
{
    InventarioManager m;

    void Start()
    {
        m = GetComponent<InventarioManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider tirgger) // quant toques el objecte i fas un trigger passa..
    {
        if (tirgger.GetComponent<InventarioObjetoRecogible>() != null) // si el trigger és un component del Script "InventarioObjectoRecobile" és el contrari
        {
            InventarioObjetoRecogible i = tirgger.GetComponent<InventarioObjetoRecogible>();   // el script agafa el objecte i, aquest el passa en un trigeer i es comparteix en una Component del objecte recollit
            m.AddInventario(i.id, i.cantidad); // la variable m agrega l'objecte en el inventari
            Destroy(tirgger.gameObject); //llavors quant fa el tirigger en el GameObject ha de ser destruit
        }
    }
}

