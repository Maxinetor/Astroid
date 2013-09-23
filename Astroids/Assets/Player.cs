using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private bool firepress = false;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//rigidbody.velocity = Vector3.zero;
		if (Input.GetKey(KeyCode.W))
		{
			rigidbody.AddRelativeForce(new Vector3(0, 0, 100));
		}
		else if (Input.GetKey(KeyCode.S))
		{
			rigidbody.AddRelativeForce(new Vector3(0, 0, -100));	
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			transform.Rotate(0, -4, 0);	
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, 4, 0);
		}
		
		if (Input.GetAxis("Fire1") == 1)
		{
			if(firepress == false)
			{
				firepress = true;
				GameObject bullet = Instantiate(Resources.Load("Bullet"),transform.position,transform.rotation) as GameObject;
			}
		}
		else
		{
			firepress = false;
		}
		
		
	
	}
}