using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventarioCollider : MonoBehaviour
{

    InventarioManager m;
    public GameObject b1;
    void Start()
    {
        m = GetComponent<InventarioManager>();
        b1.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            b1.SetActive(true);
        }
        
          

        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<InventarioObjetoRecogible>() != null)
        {
            InventarioObjetoRecogible i = col.GetComponent<InventarioObjetoRecogible>();
            m.AgregarAlgoAlInventario(i.id, i.cantidad);
            Debug.Log(i.id);
            Destroy(col.gameObject);
        }

        // if (Input
    }
}
