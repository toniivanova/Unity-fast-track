using UnityEngine;
using System.Collections;

public class MainSphere : MonoBehaviour {

	bool right;
	bool forward;
	bool left;
	bool back;
	bool up;
	bool down;
	public Transform Cube1;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			right = true;
		}
		else if(Input.GetKeyUp(KeyCode.RightArrow))
		{
			right = false;
		}
		
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			forward = true;
		}
		else if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			forward = false;
		}
		
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			left = true;
		}
		else if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			left = false;
		}
		
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			back = true;
		}
		else if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			back = false;
		}
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			up = true;
		}
		else if(Input.GetKeyUp(KeyCode.Space))
		{
			up = false;
		}
		
		if(Input.GetKeyDown(KeyCode.Z))
		{
			down = true;
		}
		else if(Input.GetKeyUp(KeyCode.Z))
		{
			down = false;
		}
		
		
		if(forward)
		{
			transform.position += new Vector3(0f, 0f, 10f * Time.deltaTime);
		}
		
		if(back)
		{
			transform.position -= new Vector3(0f, 0f, 10f * Time.deltaTime);
		}
		
		
		if(right)
		{
			transform.position += new Vector3(10f * Time.deltaTime, 0f, 0f);
		}
		
		if(left)
		{
			transform.position -= new Vector3(10f * Time.deltaTime, 0f, 0f);
		}
		
		if(up)
		{
			transform.position += new Vector3(0f, 10f * Time.deltaTime, 0f);
		}
		
		if(down)
		{
			transform.position -= new Vector3(0f, 10f * Time.deltaTime, 0f);
		}
	}
	
	void LateUpdate()
	{
		
	}
	
}