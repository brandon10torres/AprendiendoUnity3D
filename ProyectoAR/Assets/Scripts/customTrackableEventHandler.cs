using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class customTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour mTrackableBehaviour;
	public SkinnedMeshRenderer mallaMounstruo;
	public Color colorMounstruoEncontrado;
	private Color colorMounstruoInicial;
	private bool mounstruoEnojado = false;
	public Animator animMounstruo;
	// Use this for initialization
    void Start ()
    {        
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
		colorMounstruoInicial = mallaMounstruo.material.color;
    }
    public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }
    void OnTrackingFound()
    {
		
        print("Objecto encontrado");

    }
    void OnTrackingLost()
    {
		
        print("Objecto perdido");
    }

	void OnMouseDown()
	{
		mounstruoEnojado = !mounstruoEnojado;
		if (mounstruoEnojado) 
		{			
			mallaMounstruo.material.color = colorMounstruoEncontrado;
			animMounstruo.SetTrigger ("Enojado");
		} 
		else 
		{
			mallaMounstruo.material.color = colorMounstruoInicial;
		}
	}
}
