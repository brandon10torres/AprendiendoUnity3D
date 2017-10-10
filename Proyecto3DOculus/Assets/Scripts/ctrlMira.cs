using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrlMira : MonoBehaviour
{
    public Transform miVista;
    public GameObject miraOculus;
    public Transform origenLinea;

    public Animator ojoCarga;
    private bool cargarOjo = false;

    private Vector3 lineaDesde;
    private Vector3 lineaA;

    private LineRenderer miLinea;

    // Use this for initialization
    void Start ()
    {
        miLinea = GetComponent<LineRenderer>();
       // miLinea.enabled = true;

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        RaycastHit hit;
		if(Physics.Raycast(miVista.position, miVista.forward, out hit))
        {
            miLinea.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, Time.time);

            if(miraOculus)
            {
                miraOculus.transform.position = hit.point;
            }

            if(hit.collider.tag == "objetosApuntables")
            {
                ///print("OBJETO CHOCADO");
                if(!cargarOjo)
                {
                    cargarOjo = true;
                    ojoCarga.Play("Carga");
                    Invoke("ActivarCarga", 1.5f);
                }
            }
            else
            {
                if(cargarOjo)
                {
                    cargarOjo = false;
                    CancelInvoke("ActivarCarga");
                    ojoCarga.Play("SinCarga");
                }
            }


            lineaDesde = origenLinea.position;
            lineaA = hit.point;

            miLinea.SetPosition(0, lineaDesde);
            miLinea.SetPosition(1, lineaA);
        }
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(lineaDesde, lineaA);
    }

    void ActivarCarga()
    {
        cargarOjo = false;
        ojoCarga.Play("SinCarga");
        print("ACTIVAR CARGA");
    }
}
