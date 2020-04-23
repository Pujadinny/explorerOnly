using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgansInstantinate : MonoBehaviour
{
    //ORGANS
    public GameObject cor;
    public GameObject pulmo;
    public GameObject instePrim;
    public GameObject insteGros;
    public GameObject cervell;




    //POSI organs
    public Transform posiCor;
    public Transform posiPulmo;
    public Transform posiIntestiPrim;
    public Transform posiIntestiGros;
    public Transform posiCervell;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(cor, posiCor.position, Quaternion.identity);
            Instantiate(pulmo, posiPulmo.position, Quaternion.identity);
            Instantiate(instePrim, posiIntestiPrim.position, Quaternion.identity);
            Instantiate(insteGros, posiIntestiGros.position, Quaternion.identity);
            Instantiate(cervell, posiCervell.position, Quaternion.identity);

        }

        
    }
}
