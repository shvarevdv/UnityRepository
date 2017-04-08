using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScript : MonoBehaviour 
{
	public GameObject Satelite;
	public Text coordText;
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{

		coordText.text ="x = " + Satelite.transform.position.x + "\n" +
						"y = " + Satelite.transform.position.y + "\n" +
						"z = " + Satelite.transform.position.z;
	}
}
