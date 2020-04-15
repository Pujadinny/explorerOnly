using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnActivation : MonoBehaviour
{
    public RespawnMoviment resp;
    private void Start()
    {
        resp = GetComponent<RespawnMoviment>();
    }


    private void OnTriggerEnter(Collider trigger)
    {
        MoureRespawn();

    }

    public void MoureRespawn()
    {
        resp.MovimentRespawn();
    }
}
        
    

