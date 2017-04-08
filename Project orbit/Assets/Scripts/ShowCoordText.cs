using UnityEngine;
using System.Collections;

public class ShowCoordText : MonoBehaviour {

	GameObject Satelite;
	GUIText CoordText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		CoordText.text = "x="+Satelite.transform.position.x;
	}
}
