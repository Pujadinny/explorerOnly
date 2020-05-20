using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DataInserter : MonoBehaviour {

	public InputField inputUserName;
	public InputField inputPassword;
	//public string inputEmail;

	string CreateUserURL = "http://ec2-18-210-22-233.compute-1.amazonaws.com/~edi/alta_usu.php";

	// Use this for initialization



	public void SendData()

	{

		CreateUser(inputUserName.text, inputPassword.text);
	}
	public void CreateUser(string username, string password)
	{
		WWWForm form = new WWWForm();
		form.AddField("usernamePostAlta", username);
		form.AddField("passwordPostAlta", password);

		WWW www = new WWW(CreateUserURL, form);
	}
}
