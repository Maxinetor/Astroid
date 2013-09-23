using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		for(int i = 0; i < 10; i++)
  		{
  			 Vector3 astPos = new Vector3(Random.Range(-23,23),0,Random.Range(-10,10));
  			 GameObject astro = Instantiate(Resources.Load("Astroid"),astPos,Quaternion.identity) as GameObject;
  		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
