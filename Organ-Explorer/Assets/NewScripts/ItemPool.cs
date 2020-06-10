using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //llibreria necessaria per fer aquest Script

public class ItemPool : MonoBehaviour, IDropHandler //Interfaces que es necessiten que Unity ja les porta incurporades
{
    public void OnDrop(PointerEventData eventData) //funció que crida en el Pool (zona on estan els objectes)
    {
        DragHandler.itemDragging.transform.SetParent(transform); //llavors aquests Items son agafats i estan siguent arrosegats, aquests son tranformats en la possicio del pare.
    }
}
