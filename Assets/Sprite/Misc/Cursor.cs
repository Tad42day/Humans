using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	private static Vector2 Position;
	private float angle = 0f;


	private float VelRotation = 0.1f;

	// Use this for initialization
	void Start () {
		Position = new Vector2(10, 10);
	}

	public static float x
	{
		get
		{
			return Position.x;
		}

	}

	public static float y
	{
		get
		{
			return Position.y;
		}
	}
	
	// Update is called once per frame
	void Update () {

		Position = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
			
		angle = (angle + VelRotation) % 360;
	}
}
