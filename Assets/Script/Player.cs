using UnityEngine;
using System.Collections;



public class Player : MonoBehaviour {

	// Use this for initialization

	public float VelocityWalk;
	public float VelocityFly;


	public float angles;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.eulerAngles = new Vector3(0, 0, (angles));
		angles = (angles + 0.1f) % 360;
	}
}
