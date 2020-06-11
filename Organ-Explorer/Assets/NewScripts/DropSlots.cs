using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //llibreria necessaria per fer aquest Script

public class DropSlots : MonoBehaviour, IDropHandler //Interfaces que es necessiten que Unity ja les porta incurporades
{
     //items
    public GameObject item; // variable que fara el objecte (sprite) que sera col·locat quant fagui la funcio de OnEndDrag
  //  public GameObject item1;

    //slots 
    public GameObject SlotCor;
    public GameObject SlotPulmo;
    public GameObject SlotCervell;
    public GameObject SlotFetge;
    public GameObject SlotIntestiGros;
    public GameObject SlotIntestiPrim;

    public GameObject cor;
    public GameObject pulmo;
    public GameObject cervell;
    public GameObject fetge;
    public GameObject intestiGros;
    public GameObject intestiPrim;

       

    public void OnDrop(PointerEventData eventData) //funció que deixa caure el objecte 
    {
      if (!item )   //si el objecte que cau a la cassella
        {
            Debug.Log("On Drop");
            item = DragHandler.itemDragging; //el objecte que tenim dintre de la cassella és el mateix que el que el objecte que tenim agafat / dragging / que el itemDragging.
            item.transform.SetParent(transform); //despres si el item es correcte el tranformem amb un fill de la cassella.
            Debug.Log(item.transform.parent);
            item.transform.position = transform.position; //finalment aquest objecte si coinxideix amb la cassella i el tranformem en fill li donem la possicio que té LA CASSELLA.
            Debug.Log(item);

            if (SlotCor.transform.position == cor.transform.position)
            {
                Debug.Log("Cor ben posat");
            }
            else if (SlotPulmo.transform.position == pulmo.transform.position)
            {
                Debug.Log("Pulmo ben posat");
            }
            else if (SlotCervell.transform.position == cervell.transform.position)
            {
                Debug.Log("Cervell ben posat");
            }
            else if (SlotFetge.transform.position == fetge.transform.position)
            {
                Debug.Log("Fetge ben posat");
            }
            else if (SlotIntestiGros.transform.position == intestiGros.transform.position)
            {
                Debug.Log("ntestiGros ben posat");
            }
            else if (SlotIntestiPrim.transform.position == intestiPrim.transform.position)
            {
                Debug.Log("intestiPrim ben posat");
            }
            else 
            {
                Debug.Log("Posicio Incorrecte");
            }
            
        }
        

    }

   void Update() //funció Update
    {
        if (item != null && item.transform.parent != transform) //condicio que el que fa és dirli al Item (sprite) que si no és null el Item no es moura d'on esta i no tampoc sera fill de res a a menys que sigui que te el "TAG"
        {
            Debug.Log("hola");
            item = null; //Llavors el item si que es correcte
        }


    }
}
