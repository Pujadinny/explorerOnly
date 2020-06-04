using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSalaPlataformasVolants : MonoBehaviour
{
    public Transform pleyer;
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other) //Al tocar amb el collider del respawn
    {
        pleyer.transform.position = respawnPoint.transform.position; //La posició del jugador passa ser la posició de la posició de respawn
    }
}
