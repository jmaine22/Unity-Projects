using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour 
{
	public float h;
	public float v;
	public float wSpeed = 50f;
	public float rSpeed = 50f;
	public float movementDistance;
	public float z;
	public Animator player;

	// Use this for initialization
	void Start () 
	{
		player = GetComponent<Animator>();
		z = transform.position.z;
		movementDistance = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{
		v = Input.GetAxis("Vertical");
		h = Input.GetAxis("Horizontal");
	}

	void FixedUpdate () 
	{
		transform.Translate(new Vector3 (h * Time.deltaTime * wSpeed, 0, v * Time.deltaTime * wSpeed));
		//transform.Translate(new Vector3 (h, 0 * Time.deltaTime * rSpeed, 0));
	}
}
