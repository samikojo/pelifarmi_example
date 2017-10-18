using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public float Speed;

	void Update()
	{
		float vertical = Input.GetAxis( "Vertical" );
		float horizontal = Input.GetAxis( "Horizontal" );
		
		Move( new Vector3(horizontal, 0, vertical) );
	}

	void Move( Vector3 input )
	{
		Vector3 movementVector = input * Speed;
		transform.Translate( movementVector * Time.deltaTime );
	}
}
