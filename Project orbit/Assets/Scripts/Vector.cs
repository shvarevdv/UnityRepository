using UnityEngine;
using System.Collections;
using Microsoft;

public class Vector :  IVector
{

	//class Vector
	public int vitok;
	public float x, y, z, vx, vy, vz, t;
	public const float OMEGA_EARTH = 7.292115e-5f;
	public const float MU_E = 398600.44f;
	public Vector()
	{
		x  = 0;
		y  = 0;
		z  = 0;
		vx = 0;
		vy = 0;
		vz = 0;
		t  = 0;
	}
		
	public Vector(float _x, float _y, float _z, float _vx, float _vy, float _vz, float _t)
	{
		x  = _x;
		y  = _y;
		z  = _z;
		vx = _vx;
		vy = _vy;
		vz = _vz;
		t  = _t;
	}
		
	public Vector(Vector _vector)
	{
		x  = _vector.x;
		y  = _vector.y;
		z  = _vector.z;
		vx = _vector.vx;
		vy = _vector.vy;
		vz = _vector.vz;
		t  = _vector.t;
	}
		
	public static Vector operator *(Vector b, float a)
	{
		var c = new Vector();
		c.x  = a*b.x;
		c.y  = a*b.y;
		c.z  = a*b.z;
		c.vx = a*b.vx;
		c.vy = a * b.vy;
		c.vz = a * b.vz;
		return c;
	}

	public static Vector operator *(float a, Vector b)
	{
		var c = new Vector();
		c.x = a * b.x;
		c.y = a * b.y;
		c.z = a * b.z;
		c.vx = a * b.vx;
		c.vy = a * b.vy;
		c.vz = a * b.vz;
		return c;
	}
		
	public static Vector operator + (Vector a,Vector b)
	{
		var c = new Vector();
		c.x = a.x + b.x;
		c.y = a.y + b.y;
		c.z = a.z + b.z;
		c.vx = a.vx + b.vx;
		c.vy = a.vy + b.vy;
		c.vz = a.vz + b.vz;
		c.vitok = a.vitok;
		return c;
	}

	public void RKS(float dt)
	{
		Vector K1, K2, K3, K4;
		var result = new Vector(this);
		K1 = F(this, t) * dt;
		K2 = F(this + K1 * 0.5f, t + 0.5f * dt) * dt;
		K3 = F(this + 0.5f * K2, t + 0.5f * dt) * dt;
		K4 = F(this + K3, t + dt) * dt;
		result = this + 1.0f / 6.0f * (K1 + 2f * K2 + 2f * K3 + K4);
		x = result.x;
		y = result.y;
		z = result.z;
		vx = result.vx;
		vy = result.vy;
		vz = result.vz;
		t += dt;
	}
		
	Vector F (Vector Vect, float dt)
	{
		Vector result = new Vector();
		float r = Mathf.Sqrt(Vect.x*Vect.x + Vect.y*Vect.y + Vect.z*Vect.z);
		//float V = Mathf.Sqrt(Vect.vx * Vect.vx + Vect.vy * Vect.vy + Vect.vz * Vect.vz);
		result.x = Vect.vx;
		result.y = Vect.vy;
		result.z = Vect.vz;
		result.vx = - (MU_E*Vect.x)/(r*r*r) ;
		result.vy = - (MU_E*Vect.y)/(r*r*r) ;
		result.vz = - (MU_E * Vect.z)/(r * r * r);
		return result;
	}
}

