using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour 
{
	public GameObject Planet;

	
	// Update is called once per frame
	void Update () 
	{
		Planet.transform.RotateAround (Vector3.zero, Vector3.down, 0.01f); 
	}
}
