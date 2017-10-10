using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoProyectil : MonoBehaviour
{

    public float radius = 2;
    public float fuerzaExplosion = 10;

    public GameObject explosion;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "objetosApuntables")
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

            foreach (Collider c in colliders)
            {
                if(c.GetComponent<Rigidbody>() == null)
                {
                    continue;
                }
                c.GetComponent<Rigidbody>().AddExplosionForce(fuerzaExplosion, transform.position, radius, 0.5f, ForceMode.Impulse);
            }
            if(explosion)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }

}
