using UnityEngine;
using System.Collections;

public class vectorfun : MonoBehaviour {

	public Vector3 pointA, pointB;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F) ) {
			float distance = Vector3.Magnitude ( pointB.position - pointA.position );
				Debug.Log ( "these two points are this many apart: " + distance.ToString () );

		}
	}
}
