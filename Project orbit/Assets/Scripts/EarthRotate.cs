using UnityEngine;
using System.Collections;

public class EarthRotate : MonoBehaviour 
{
	public GameObject Earth;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () 
	{
		Earth.transform.Rotate (Vector3.down, 10 * Time.deltaTime);
	}
}
