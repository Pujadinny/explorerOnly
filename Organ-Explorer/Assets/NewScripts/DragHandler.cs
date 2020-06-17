using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;  //llibreria necessaria per fer aquest Script

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler  //Interfaces que es necessiten que Unity ja les porta incurporades
{

    public static GameObject itemDragging;  //varible d'objecte que estas agafan

    Vector3 posiStart; //variable que fa moure en tots els vectors x ,y ,z 
    Transform startParent; //variable el punt con comença tot
    Transform dragParent; //variable de posicio un transform
    //Transform respawnPoint; 



    void Start() //quant comença la funcio START
    {

        dragParent = GameObject.FindGameObjectWithTag("Object").transform; // la variable "dragparent"  busca un objecte amb el TAG "OBJECT"   el objecte és el ObjectParent. 
        Debug.Log(dragParent);
    }


    public void OnBeginDrag(PointerEventData eventData)    //LLavors la funció On BeginDrag crida a un event que rep el Eventsystem
    {
        Debug.Log("ONBeginDrag");
        itemDragging = gameObject; //en la variable de itemDragging cridem al objecte del joc que és,una imatge. Sprite Cor ,Sprite pulmo ,etc...
        Debug.Log(itemDragging);
        posiStart = transform.position; // la varibale posiStart és el punt on el ITEM esta situat i esta deixat. EXEMPLE: X:100 Y:13 Z:1 (primera vegada)  X:241 Y:15'1 Z:11 (segona vegada) aquesta ha estat deixat
        startParent = transform.parent; //el StartParent és de quin POOL surt el item Si del dret o de l'esquerra
        transform.SetParent(dragParent); // transformem la seva poscio en un fill respecta al seu pare. Es a dir la zona a la que surt esta utilizant el dragParent que aquest utiliza un TAG. Si es el tag ok Es posa sino no.
    }

    public void OnDrag(PointerEventData eventData)          //Funcio de OnDrag
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition; //tranforma la del objecte amb la del ratoli
    }

    public void OnEndDrag(PointerEventData eventData)   //funcio OnEndDrag
    {
        Debug.Log("OnEndDrag");
        itemDragging = null; //el objecte selecionat sempre sera no
        if (transform.parent == dragParent ) // a menys.. si la seva posició és equivalent al dragParent ... i el dragParent busca el objecte que te el Tag "Object"
        {   //si passa la condició...

            transform.position = posiStart; //la posicio actual passa a ser passa a ser el primer punt on es queda. EXEMPLE: és a dir si en el inspector surt x = 150'4 y = 1'412 z=1 doncs per ell és 0 TOT. Despres si tu el mous a la posi X=250 y = 31 z= 21  despres de fer funcio OnDrag sera 0 per ell.
            transform.SetParent(startParent); //finalment el que fa és aquella posicio passa a ser fill de el starParent
            Debug.Log(posiStart);
            Debug.Log(startParent);
        }
    }
}
    

   
    
        
    

