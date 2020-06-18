using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ButtonInstantinate : MonoBehaviour
{
    public GameObject but;

    void Start()
    {
        but.SetActive(false);
        Invoke("Timeing", 16);
    }


    public void Timeing()
    {
        but.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
