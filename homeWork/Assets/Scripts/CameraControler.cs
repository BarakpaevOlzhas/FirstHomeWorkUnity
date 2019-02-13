using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {

	[SerializeField]
	private Transform terget;	
	
	[SerializeField]
	private Vector3 offset;

	void Update () {
		transform.position = terget.position + offset;		
	}
}
