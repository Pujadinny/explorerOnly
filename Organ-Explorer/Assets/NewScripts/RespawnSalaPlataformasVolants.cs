using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSalaPlataformasVolants : MonoBehaviour
{
    public Transform pleyer;
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        pleyer.transform.position = respawnPoint.transform.position;
    }
}
