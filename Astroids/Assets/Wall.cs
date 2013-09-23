using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > 27)
		  {
			   Vector3 pos = transform.position;
	   
			   pos.x = -27;
   
			   transform.position = pos;
		  }
	  else if(transform.position.x < -27)
		  {
			   Vector3 pos = transform.position;
   
			   pos.x = 27;
   
  				 transform.position = pos;
  		  }
 	 else if(transform.position.z < -12)
 		  {
 			  Vector3 pos = transform.position;
   
 			  pos.z = 12;
 			  
			   transform.position = pos;
		  }
	  else if(transform.position.z > 12)
		  {
    			Vector3 pos = transform.position;
   
   			  pos.z = -12;
   
   transform.position = pos;
  }
	}
}
