using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //llibreria necessaria per fer aquest Script

public class DropSlots : MonoBehaviour, IDropHandler //Interfaces que es necessiten que Unity ja les porta incurporades
{

    public GameObject item; // variable que fara el objecte (sprite) que sera col·locat quant fagui la funcio de OnEndDrag
   
    public void OnDrop(PointerEventData eventData) //funció que deixa caure el objecte 
    {
      if (!item )   //si el objecte que cau a la cassella
        {
            item = DragHandler.itemDragging; //el objecte que tenim dintre de la cassella és el mateix que el que el objecte que tenim agafat / dragging / que el itemDragging.
            item.transform.SetParent(transform); //despres si el item es correcte el tranformem amb un fill de la cassella.
            item.transform.position = transform.position; //finalment aquest objecte si coinxideix amb la cassella i el tranformem en fill li donem la possicio que té LA CASSELLA.
        }
    }

    void Update() //funció Update
    {

        if(item != null && item.transform.parent != transform) //condicio que el que fa és dirli al Item (sprite) que si no és null el Item no es moura d'on esta i no tampoc sera fill de res a a menys que sigui que te el "TAG"
        {
            item = null; //Llavors el item si que es correcte
        }
        
    }
}
