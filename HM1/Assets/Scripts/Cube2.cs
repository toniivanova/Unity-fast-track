using UnityEngine;
using System.Collections;

public class Cube2 : MonoBehaviour {

	public Transform Cube1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Cube1.position);
	}
	
	void LateUpdate()
	{
		if(Input.GetKey("up"))
		{
			transform.position += new Vector3(0f, 0f, 10f * Time.deltaTime);
		}
		if(Input.GetKey("down"))
		{
			transform.position -= new Vector3(0f, 0f, 10f * Time.deltaTime);
		}
		if(Input.GetKey("right"))
		{
			transform.position += new Vector3(14f * Time.deltaTime, 0f, 0f);
		}
		if(Input.GetKey("left"))
		{
			transform.position -= new Vector3(14f * Time.deltaTime, 0f, 0f);
		}
	}
}