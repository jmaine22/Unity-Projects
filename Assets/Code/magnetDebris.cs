using UnityEngine;
using System.Collections;

public class magnetDebris : MonoBehaviour 
{
	/*The*/
	public GameObject player;
	public bool magnetTrigger = false;
	public float mSpeed = 30f;
	public Vector3 transferDirection;
	public ParticleSystem particle;

	// Use this for initialization
	void Start () 
	{
		//Get a reference of the player
		player = GameObject.Find("player");
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Object entered the trigger");
		//Activate Trigger Zone
		magnetTrigger = true;

	}
	void OnTriggerStay(Collider other)
	{
		Debug.Log ("Object stayed at the trigger");
		//When trigger is activated move the particles
		//
		ParticleSystem.Particle []ParticleList = new ParticleSystem.Particle[particle.particleCount];
		particle.GetParticles (ParticleList);
		for (int i = 0; i < ParticleList.Length; ++i) 
		{
			ParticleList [i].velocity = new Vector3 (0, 5f, 0);
		}

		particle.SetParticles (ParticleList, particle.particleCount);
		//Determine how much gravity to apply to particle system.
		particle.gravityModifier = 10;
	}
	void OnTriggerExit(Collider other)
	{
		//Test to see if the trigger work
		Debug.Log ("Object exit the trigger");
		//Determine how much gravity to apply to particle system.
		particle.gravityModifier = 0;
	}
	// Update is called once per frame
	void Update () 
	{
	
	}
}
