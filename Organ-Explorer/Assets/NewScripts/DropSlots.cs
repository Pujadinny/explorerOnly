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
    // Objectes
    public GameObject cor;
    public GameObject pulmo;
    public GameObject cervell;
    public GameObject fetge;
    public GameObject intestiGros;
    public GameObject intestiPrim;

    public Light llight;


    //INCORRECTE
     public GameObject luxRed;           //llum VERMELLA 
      public GameObject luxGreen;         //LLUM VERDE


    /*
    public bool corEnces = false;
    public bool pulmoOn = false;          // booleana que permet canviar de encès i apagat
    public bool cervellOn = false;
    public bool fetgeOn = false;
    public bool intestiGrosOn = false;
    public bool intestiPrimOn = false;
    */


      public void Start()
      {
          luxRed.SetActive(false); //definir si el objecte esta encès o apagat
          luxGreen.SetActive(false); //definir si el objecte esta encès o apagat
      }


    public void ApagatRed()    //funcio APAGAT RED
    {
            luxRed.SetActive(false);            // desactiva el GameObject luxRed 
    }

    public void ApagatVerde()    //funcio APAGAT GREEN
    {

            luxGreen.SetActive(false); // desactiva el GameObject luxGreen

    }




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
            

            if (SlotCor.transform.position == cor.transform.position & !llight.corEnces )  //condicio que fa que els organs et diguin si estan ben posats o no
            {
                Debug.Log("Cor ben posat"); //si ho esta llavors fes un log que digui que el "Cor està ben posat"
                luxGreen.SetActive(true);
                Invoke("ApagatVerde", 2);
                llight.corEnces = true;
            }

            else if (SlotPulmo.transform.position == pulmo.transform.position & !llight.pulmoOn)  //sino si el pulmo es correcte el SLOT de pulmo ha de ser el mateix que el del Item Pulmo
            {
                Debug.Log("Pulmo ben posat");                   //DEGUB "Pulmo ben posat
                luxGreen.SetActive(true);                       // La llum s'activa
                Invoke("ApagatVerde", 2);                       // Invoca a la funcio APAGAR VERDE fa un delay de 2 seg
                llight.pulmoOn = true;                           // booleana de light
            }

            else if (SlotCervell.transform.position == cervell.transform.position & !llight.cervellOn)   //sino si el cervell és correcte el SLOT de cervell i el item cervell  han de ser el mateix 
            {
                Debug.Log("Cervell ben posat");
                luxGreen.SetActive(true);                       // La llum s'activa
                Invoke("ApagatVerde", 2);                       // Invoca a la funcio APAGAR VERDE fa un delay de 2 seg
                llight.cervellOn = true;                         // booleana de light
            }

            else if (SlotFetge.transform.position == fetge.transform.position & !llight.fetgeOn)  //sino si el fetge  es correcte el SLOT del fetge ha de ser el matiex que el item
            {
                Debug.Log("Fetge ben posat");                       //DEBUG "FETGE BEN POSAT"
                luxGreen.SetActive(true);                          // La llum s'activa
                Invoke("ApagatVerde", 2);                       // Invoca a la funcio APAGAR VERDE fa un delay de 2 seg
                llight.fetgeOn = true;                           // booleana de light
            }

            else if (SlotIntestiGros.transform.position == intestiGros.transform.position & !llight.intestiGrosOn)   //sino si el intestiGros es correcte el SLOT Intesti Gros ha de considir amb el item Intesti gros
            {
                Debug.Log("IntestiGros ben posat");
                luxGreen.SetActive(true);                         // La llum s'activa
                Invoke("ApagatVerde", 2);                        // Invoca a la funcio APAGAR VERDE fa un delay de 2 seg
                llight.intestiGrosOn = true;                        // booleana de light
            }

            else if (SlotIntestiPrim.transform.position == intestiPrim.transform.position & !llight.intestiPrimOn)    //sino si el intesti Prim és correcte el SLOT 
            {
                Debug.Log("IntestiPrim ben posat");
                luxGreen.SetActive(true);                        // La llum s'activa
                Invoke("ApagatVerde", 2);                        // Invoca a la funcio APAGAR VERDE fa un delay de 2 seg
                llight.intestiPrimOn = true;                         // booleana de light
            }
          
            else //sino ...
            {
                luxRed.SetActive(true);                         //llumm roja activated
                Invoke("ApagatRed", 2);                         // Invoca a la funcio APAGAR VERDE fa un delay de 2 seg
                Debug.Log("Posicio Incorrecte");                //DEBUG " posi incorrecte"
            }

        }
      

    }


    void Update() //funció Update
    {
        if (item != null && item.transform.parent != transform) //condicio que el que fa és dirli al Item (sprite) que si no és null el Item no es moura d'on esta i no tampoc sera fill de res a a menys que sigui que te el "TAG"
        {
            Debug.Log("hola");                //DEGUG "hola"
            item = null;                    //Llavors el item si que es correcte
        }


    }


}
