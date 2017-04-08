using UnityEngine;
using System.Collections;
using Microsoft;
using TreeEditor;
using System.Collections.Generic;


public class SateliteMovement : MonoBehaviour 
{
	public int speed = 1;
	public Vector3 satPos;
	public Vector vect;
	public GameObject Satelite;
	public int vitok;
	public float x, y, z, vx, vy, vz, t;
	public List<Vector3> wayPoints;
	int k = 0;
	public int length;
	private int i = 0;
	Vector3 wayPoint;

	void Update() 
	{

			if (k == 0) {
				satPos = new Vector3 (x, y, z);
				Satelite.transform.position = satPos;
				k = 1;
			}
			vect = new Vector (x, y, z, vx, vy, vz, t);
			vect.RKS (1);
			wayPoint.x = vect.x;
			wayPoint.y = vect.y;
			wayPoint.z = vect.z;
			wayPoints.Add (wayPoint);
			x = vect.x;
			y = vect.y;
			z = vect.z; 
			vx = vect.vx;
			vy = vect.vy;
			vz = vect.vz;
			//if(Input.GetKey("w"))
			//transform.rotation = Quaternion.LookRotation(wayPoints[i]);
			Satelite.transform.LookAt(wayPoint);
			Satelite.transform.position = (wayPoint);

			//transform.rotation = Quaternion.FromToRotation (Satelite.transform.position, wayPoints [i]);
			//Vector3 distance = wayPoints[i] - Satelite.transform.position;

			i++; //Идем в следующую

	}
}