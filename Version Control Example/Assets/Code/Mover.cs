using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public float Speed;
	public float TurnSpeed = 1;

	void Update()
	{
		float vertical = Input.GetAxis( "Vertical" );
		float horizontal = Input.GetAxis( "Horizontal" );
		float turn = Input.GetAxis( "Turn" );
		
		Move( new Vector3(horizontal, 0, vertical) );
		Turn( turn );
	}

	void Move( Vector3 input )
	{
		Vector3 movementVector = input * Speed;
		transform.Translate( movementVector * Time.deltaTime );
	}
	
	void Turn( float amount )
	{
		transform.Rotate( Vector3.up * TurnSpeed * Time.deltaTime * amount );
	}
}
