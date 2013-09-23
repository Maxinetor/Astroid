using UnityEngine;
using System.Collections;

public class Astroids : MonoBehaviour {


	void Start () {
		transform.Rotate(0,Random.Range(-180,180),0);
	}
	
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0, 0, 200));
	
		
	}
	void OnTriggerEnter(Collider col)
 {
  	if(col.collider.name == "Player")
  	{
		Destroy(col.gameObject);
	    Destroy(gameObject);
	}
	}
}
