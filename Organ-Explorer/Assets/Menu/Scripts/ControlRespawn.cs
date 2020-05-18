using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlRespawn : MonoBehaviour
{
    public Transform pleyer;
    public Transform respPonit;


    public void RespawnCama(string nombre) //funico de canviar l'escena
    {
        SceneManager.LoadScene(nombre);
        pleyer.transform.position = respPonit.transform.position;
    }

}
