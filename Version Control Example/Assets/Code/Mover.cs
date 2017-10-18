using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public float TurnSpeed = 1;

	void Update()
	{
		float turn = Input.GetAxis( "Turn" );

		Turn( turn );
	}

	void Turn( float amount )
	{
		transform.Rotate( Vector3.up * TurnSpeed * Time.deltaTime * amount );
	}
}
