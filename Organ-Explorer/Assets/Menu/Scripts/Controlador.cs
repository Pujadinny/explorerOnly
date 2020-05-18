using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
  //  public Pasue pausa; //agafo el script de pasue (PAUSA)

    public void ChangeEscena(string nombre) //funico de canviar l'escena
    {

        print("Benvingut al Organ Explorer");
        SceneManager.LoadScene(nombre);
    }
    public void Exit() //funcio de sortir del Game
    {
        print("Adeu fins una altre");
        Application.Quit();

    }

    
  //public void Restart()
   // {
        
   // }
}
