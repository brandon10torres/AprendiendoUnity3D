using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControlIMG360 : MonoBehaviour {


    public MeshRenderer mallaEsfera;
    public Texture[] imagenes360;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //IMG 360
    public void ActivarImagen360(int indexIMG)
    {
        //mallaEsfera.material.SetTexture("_MainTexture", imagenes360[indexIMG]);
        mallaEsfera.material.mainTexture = imagenes360[indexIMG];                
    }
}
