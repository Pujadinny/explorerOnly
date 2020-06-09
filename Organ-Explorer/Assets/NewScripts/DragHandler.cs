using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour , IDragHandler, IEndDragHandler , IBeginDragHandler
{

    public static GameObject objectDragging;

    Vector3 posiStart;
    Transform startParent;
    Transform dragParent;



    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("Object").transform;
    }


    public void OnBeginDrag(PointerEventData eventData)    // Interfas de IBegind DragHandler 
    {
        Debug.Log("BEGIN");
        objectDragging = gameObject;
        posiStart = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);

    }

    public void OnDrag(PointerEventData eventData)          //Interfaz de IDragHandler
    {
        Debug.Log("OnDRAG");
       transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)   //Interfaz de IEndDragHandler
    {
        Debug.Log("ONENDDRAG");
        objectDragging = null;

        if(transform.parent == dragParent)
        {
            transform.position = posiStart;
            transform.SetParent(startParent);

        }
    }

    

    void Update()
    {
        
    }
}
