using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// AQUEST SCIRPT MAY S'HA DE ENSENYAR A L'ALEX .... SI ESTAS LLEGIN AIXÒ NOO HAS LLEGIT RES !!!!!!!!
public class Light : MonoBehaviour
{
    // booleana que permet canviar de encès i apagat
    public bool corEnces;
    public bool pulmoOn;          
    public bool cervellOn;
    public bool fetgeOn;
    public bool intestiGrosOn;
    public bool intestiPrimOn;
    
   //definico de les booleans
    void Start()
    {

    corEnces = false;
    pulmoOn = false;          
    cervellOn = false;
    fetgeOn = false;
    intestiGrosOn = false;
    intestiPrimOn = false;
    }

    public void Update()
    {
        if (corEnces & pulmoOn & cervellOn & fetgeOn & intestiGrosOn & intestiPrimOn == true)
        {
            SceneManager.LoadScene("FINAL");
        }
    }


}
