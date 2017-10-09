using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject menuColores;

    public SkinnedMeshRenderer mallaMounstruo;
    public MeshRenderer mallaCubo;

    public Color colorHoverMounstruo;
    public Color colorHoverCubo;

    private Color colorInicialMounstruo;
    private Color colorInicialCubo;

    public Animator animCargaMounstruo;
    public Animator animCargaCubo;
    public Animator animCerrarMenuColores;

    public float duracionCargaMounstruo = 0.80f;

    public Color[] coloresMounstruo;


    // Use this for initialization
    void Start ()
    {
        colorInicialMounstruo = mallaMounstruo.material.color;
        colorInicialCubo = mallaCubo.material.color;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /*public void HoverMounstruo()
    {
        mallaMounstruo.material.color = colorHoverMounstruo;
    }

    public void HoverExitMounstruo()
    {
        mallaMounstruo.material.color = colorInicialMounstruo;
    }

    public void HoverCubo()
    {
        mallaCubo.material.color = colorHoverCubo;
    }

    public void HoverExitCubo()
    {
        mallaCubo.material.color = colorInicialCubo;
    }*/


    public void CargaMounstruoHover()
    {
        animCargaMounstruo.Play("cargaOjo");
        Invoke("EjecutarAccionCargaMounstruo", duracionCargaMounstruo);  
             
    }

    private void EjecutarAccionCargaMounstruo()
    {
        menuColores.SetActive(true);
    }
    private void EjecutarAcccionCerrarMenu()
    {
        menuColores.SetActive(false);
    }

    public void CargaMounstruoHoverExit()
    {
        CancelInvoke("EjecutarAccionCargaMounstruo");
        animCargaMounstruo.Play("cargaOjoInicio");        
    }

    public void MenuColoresHover()
    {
        animCerrarMenuColores.Play("cargaOjo");
        Invoke("EjecutarAcccionCerrarMenu", duracionCargaMounstruo);
    }

    public void MenuColoresHoverExit()
    {
        CancelInvoke("EjecutarAcccionCerrarMenu");
        animCerrarMenuColores.Play("cargaOjoInicio");
    }


    public void CargaCuboHover()
    {
        animCargaCubo.Play("cargaOjo");
        Invoke("EjecutarAccionCargaCubo", duracionCargaMounstruo);
    }

    private void EjecutarAccionCargaCubo()
    {
        mallaCubo.material.color = colorHoverCubo;
    }

    public void CargaCuboHoverExit()
    {
        CancelInvoke("EjecutarAccionCargaCubo");
        animCargaCubo.Play("cargaOjoInicio");
        mallaCubo.material.color = colorInicialCubo;
    }


    public void CambiarColorMounstruo(int numColor)
    {
        mallaMounstruo.material.color = coloresMounstruo[numColor];
    }



}
