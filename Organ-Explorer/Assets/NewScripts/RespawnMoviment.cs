using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMoviment : MonoBehaviour
{
    private Animator animacion;
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void MovimentRespawn()
    {
        animacion.SetInteger("Status", 1);
    }
}
