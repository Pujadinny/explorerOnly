﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSalaPlataformasVolants : MonoBehaviour
{
    public Transform pleyer;
    public Transform respawnPoint;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entra guarra");
        pleyer.transform.position = respawnPoint.transform.position; //La posició del jugador passa ser la posició de la posició de respawn

    }
}
