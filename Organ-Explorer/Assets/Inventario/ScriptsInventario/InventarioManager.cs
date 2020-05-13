using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioManager : MonoBehaviour {

    [System.Serializable]
    public struct ObjetoInventarioId //Estructura dels objectes del inventari 
    {
        public int id;
        public int cantidad;

        public ObjetoInventarioId(int ID, int quant) //funcio que defineix/construeix  com es l'estructura dels objectes
        {
            this.id = ID;
            this.cantidad = quant;
        }
        public void AddQuanty(int quanty) //funcio de cantitat d'objectes 
        {
            cantidad += quanty; //anyadeix a l'estrucutura la quantitat dels objectes
        }


        // public void DeleteQuanty(int quanty) //funcio de cantitat d'objectes 
        //({
        //   cantidad -= quanty; //redueix a l'estrucutura la quantitat dels objectes
        //}
    }

    public InventarioBaseDatos baseDatos;   // mini base de dades "DATA"
    public List<ObjetoInventarioId> inventario; // llista dels ELEMENTS de la "DATA"

    public void AddInventario (int id, int cantidad)    //funcio agregar inventari
    {
        for (int i = 0; i < inventario.Count; i++)  // pregunta si tenim el NOM/ID del objecte en el inventari
        {
            if (inventario[i].id == id) // si el NOM/ID son iguals 
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad + cantidad);  //afegim directament el objecte
                UpdateInventario();  // actualizem el inventari
                return; // sinó troba res ... 
            }
        }
        inventario.Add(new ObjetoInventarioId(id, cantidad)); //afegiex aquest nou objecte al inventari i la quantitat (SI SON IGUALS !!!)
        UpdateInventario(); // actualizem el inventari
    }
    public void DeleteInvetario(int id, int cantidad) //FUNCIO de eliminar algo del Invetari
    {
        for (int i = 0; i < inventario.Count; i++) //pregunta si tenim l'objecta en el inventari 
        {
            if (inventario[i].id == id) // si el tenim i coinsideix amb el nom
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad - cantidad); // la quantitat REDUEIX
                if (inventario[i].cantidad <= 0)    // i si disunuixes es més PETITA o = a 0 
                    inventario.Remove(inventario[i]);    // el objecte s'elimina
                UpdateInventario();         // actualizar el inventari
                return;                 //sino  troba res
            }
        }
        Debug.LogError("No puc eliminar l'objecte"); // fes un debug.logerror que digui "No es pot elimar el objecte" :D
    }

    // public void IntercambiarPuestos(int i1 , int i2)
    //{
      //  ObjetoInventarioId i = inventario[i1];
       // inventario[i1] = inventario[i2];
       // inventario[i2] = i;
    //    UpdateInventario();
    //}

    public void Start()
    {
        UpdateInventario(); //funció :D ACTUALIZAR EL INVENTARI
    }


    public InventarioObjetoInterface prefab;  //objecte ELEMENTO que és qui fa de prefav
    public Transform inventarioUI;          // un Emty que té la posició del inventari
    List<InventarioObjetoInterface> pool = new List<InventarioObjetoInterface>(); //quanti de objcetes que tenim (no es saps si els utilizes o no)

    public void UpdateInventario()
    {
        print("El Inventari s'ha Actualizat");
        for (int i = 0; i < pool.Count; i++) // Per cada objecte que hi ha en el pool
        {
            if (i < inventario.Count) //si i/(el numero d'objecte en el pool) el contador del inventari es més gran
            {
                ObjetoInventarioId o = inventario[i]; // agafem el objecte del inventari 
                pool[i].sprite.sprite = baseDatos.baseDatos[o.id].sprite; // agafem el SCRIPT DE IMATGE (fet per unity) i agafem el Sprite
                pool[i].cantidad.text = o.cantidad.ToString(); //llavors la quantitat, és a dir el texte
                pool[i].id = i;

                pool[i].boton.onClick.RemoveAllListeners();  //li treiem tots els liseners que tingui i llavors
                pool[i].boton.onClick.AddListener(() => gameObject.SendMessage(baseDatos.baseDatos[o.id].funcion, SendMessageOptions.DontRequireReceiver)); //el boto

                pool[i].gameObject.SetActive(true);    //DESPRES l'activem .. mai sabem si esta activat o no :D
            }
            else // del contrari ..
            {
                pool[i].gameObject.SetActive(false); // el desectivem
            }
        }
        if (inventario.Count > pool.Count)
        {
            for (int i = pool.Count; i < inventario.Count; i++)
            {
                InventarioObjetoInterface oi = Instantiate(prefab, inventarioUI); //fem apareixer el prefab
                pool.Add(oi);

                oi.transform.position = Vector3.zero; // bug de Unity que arregla la posicio 
                oi.transform.localScale = Vector3.one;

                ObjetoInventarioId o = inventario[i]; //agafem el objecte del inventari 
                pool[i].sprite.sprite = baseDatos.baseDatos[o.id].sprite; // agafem el sprite
                pool[i].cantidad.text = o.cantidad.ToString(); //llavors la quantitat
                pool[i].id = i; 
                pool[i].manager = this;

                pool[i].boton.onClick.RemoveAllListeners(); //li treiem tots els liseners que tingui i llavors 
                pool[i].boton.onClick.AddListener(() => gameObject.SendMessage(baseDatos.baseDatos[o.id].funcion, SendMessageOptions.DontRequireReceiver)); //el boto

                pool[i].gameObject.SetActive(true); //DESPRES l'activem .. mai sabem si esta activat o no :D
            }
        }
    }


    public void Pocion()   //funcio que fa que crida a la funció que elimina objectes
    {
        DeleteInvetario(0, 1);
    }
}
