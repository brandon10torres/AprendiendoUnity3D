using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{

    public SkinnedMeshRenderer mallaMounstruo;
    public MeshRenderer mallaCubo;

    public Color colorHoverMounstruo;
    public Color colorHoverCubo;

    private Color colorInicialMounstruo;
    private Color colorInicialCubo;

    public Animator animCargaMounstruo;
    public Animator animCargaCubo;

    public float duracionCargaMounstruo = 0.80f;


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
        mallaMounstruo.material.color = colorHoverMounstruo;
    }

    public void CargaMounstruoHoverExit()
    {
        CancelInvoke("EjecutarAccionCargaMounstruo");
        animCargaMounstruo.Play("cargaOjoInicio");
        mallaMounstruo.material.color = colorInicialMounstruo;
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





}
