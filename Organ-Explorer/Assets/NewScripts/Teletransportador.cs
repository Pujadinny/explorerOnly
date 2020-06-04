using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransportador : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //Al tocar el collider de la porta fes el següent
    {
        if (other.tag =="Player") //Si el que toca el collider de la porta es el jugador
        {
            SceneManager.LoadScene("SalonCama"); //Carrega la escena SalonCama (On es posen els organs a la camilla)
        }
    }
}
