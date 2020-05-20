using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecupUsu : MonoBehaviour
{
    public string[] items; // variable de string que porta un array 
    public string inputNomUsu; //variable string que anomenada entrada de Nom d'usuari
    public string inputPassUsu; // variable string entrada de la contrassenya del usuari


    string LoginURL = "http://ec2-18-210-22-233.compute-1.amazonaws.com/~edi/login.php"; //crida al php servidor
   

    /*void Start()  
    {
        
    }*/

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) StartCoroutine(LoginToDB(inputNomUsu, inputPassUsu));
    }


    IEnumerator LoginToDB(string iusu, string ipass)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", iusu);
        form.AddField("passwordPost", ipass);
        WWW www = new WWW(LoginURL, form);
        yield return www;
        string itemsDataString = www.text;
        items = itemsDataString.Split('#');

        //print(itemsDataString);
        //print(items[0]);

         print(GetDataValue(items[0], "nom:"));
         print(GetDataValue(items[1], "passw:"));
         print(GetDataValue(items[2], "org0:"));
         print(GetDataValue(items[3], "org1:"));
         print(GetDataValue(items[4], "org2:"));
         print(GetDataValue(items[5], "org3:"));
         print(GetDataValue(items[6], "org4:"));
         print(GetDataValue(items[7], "org5:"));
         print(GetDataValue(items[8], "org6:"));
         print(GetDataValue(items[9], "org7:"));
         print(GetDataValue(items[10], "org8:"));
         print(GetDataValue(items[11], "temps:")); 
    }
    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        return value;
    }


}
