using UnityEngine;
using UnityEngine.UI;


public class PlayerMovementMeteor : MonoBehaviour
{
	AndroidButonMeteor ab;

	void Start()
	{

		ab = GameObject.FindGameObjectWithTag("Canvas").GetComponent<AndroidButonMeteor>();
	}


	public Rigidbody rb;

	public float SidewaysForce = 30f;

	
	void FixedUpdate()
	{
		Android();



		if (Input.GetKey("d"))
		{
			rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //bu sag içim 
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // buda sol 
		}
		
	}
	void Android()
	{

		if (ab.sag)
		{

			rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}

		if (ab.sol)
		{

			rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}
	}



}