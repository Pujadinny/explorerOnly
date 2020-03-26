using UnityEngine;
using System.Collections;

public class CameraTopDown : MonoBehaviour
{
	private GameObject player;
	private Vector3 offsetPos;

	void Start()
	{
		player = GameObject.FindWithTag("Player"); // Find the GameObject named Player
		offsetPos = new Vector3(0, 10f, -8f); // Set the camera's offset position
	}

	void OnEnable()
	{
		gameObject.transform.parent = null; // This makes the camera a parent object rather than a child
	}
	
	
}