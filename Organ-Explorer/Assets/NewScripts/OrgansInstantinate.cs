using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgansInstantinate : MonoBehaviour
{
    //ORGANS 
    public GameObject cor;
    //public GameObject pulmo;
    //public GameObject instePrim;
    //public GameObject insteGros;
    //public GameObject cervell;
    //public GameObject liver;

    //Boton organos
    public GameObject BotonCor;
    //public GameObject BotonPulmon;
    //public GameObject BotonRunyo;
    //public GameObject BotonIntesGros;
    //public GameObject BotonIntesPrim;
    //public GameObject BotonEstomac;
    //public GameObject BotonCervell;

    //boolena
    bool corbool;

    //POSI organs
    public Transform posiCor;
    //public Transform posiPulmo;
    //public Transform posiIntestiPrim;
    //public Transform posiIntestiGros;
    //public Transform posiCervell;
    //public Transform posiLiver;



    void Start()
    {
        corbool = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            
            OnMouseDown();
        }
    }
    void OnMouseDown()
    {
        if (corbool == false)
        {
            corbool = true;
            Instantiate(cor, posiCor.position, Quaternion.identity);
        }
            //Instantiate(instePrim, posiIntestiPrim.position, Quaternion.identity);
            //Instantiate(insteGros, posiIntestiGros.position, Quaternion.identity);
            //Instantiate(cervell, posiCervell.position, Quaternion.identity);
            //Instantiate(liver, posiLiver.position, Quaternion.identity);
            Object.Destroy(this.cor);
            Debug.Log("hola");
        
    }
}
