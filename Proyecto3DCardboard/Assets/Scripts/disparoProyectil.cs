using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoProyectil : MonoBehaviour 
{

	public GameObject proyectil;
	public GameObject miraProyectil;
	public float fuerzaProyectil = 500.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			GameObject objProyectil = Instantiate (proyectil, miraProyectil.transform.position, Quaternion.identity);
			Destroy (objProyectil, 2.0f);
			objProyectil.GetComponent<Rigidbody> ().AddForce (miraProyectil.transform.forward * fuerzaProyectil);
		}
	}
}
