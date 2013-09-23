using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0, 0, 400));
	}
	void OnTriggerEnter(Collider col)
 {
  	if(col.collider.name == "Astroid(Clone)")
  	{
		Destroy(col.gameObject);
		for(int i = 0; i < 3; i++)
  		{
  			 GameObject astro = Instantiate(Resources.Load("AstroidSmall"),transform.position,Quaternion.identity) as GameObject;
  		}
	    Destroy(gameObject);
	}
		if(col.collider.name == "AstroidSmall(Clone)")
  	{
		Destroy(col.gameObject);
	    Destroy(gameObject);
	}
	}
	
}
