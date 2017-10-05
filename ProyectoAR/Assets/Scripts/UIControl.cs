using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    public GameObject panelColores;
    public GameObject btnMeter;
    public GameObject btnSacar;
    public Animator animPanelColores;
    public Color[] coloresMounstruo;
    public Animator animMounstruo;

    public SkinnedMeshRenderer mallaMounstruo;
    private Color colorInicialMounstruo;

	// Use this for initialization
	void Start ()
    {
        colorInicialMounstruo = mallaMounstruo.material.color;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SacarPanel()
    {
        btnSacar.SetActive(false);
        btnMeter.SetActive(true);
        animPanelColores.SetTrigger("sacarPanel");
    }
    public void MeterPanel()
    {
        btnSacar.SetActive(true);
        btnMeter.SetActive(false);
        animPanelColores.SetTrigger("meterPanel");
    }

    public void CambiarColor(int indexColor)
    {
        if(indexColor == coloresMounstruo.Length-1)
        {
            mallaMounstruo.material.color = colorInicialMounstruo;
        }
        else
        {
            mallaMounstruo.material.color = coloresMounstruo[indexColor];
        }
        
    }

    public void CambiarAnimaciones(string animacion)
    {
        animMounstruo.SetTrigger(animacion);
    }

}
