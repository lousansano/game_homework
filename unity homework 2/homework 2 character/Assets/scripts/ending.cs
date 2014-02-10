using UnityEngine;
using System.Collections;

public class ending : MonoBehaviour {
public TextMesh mytextmesh;

	void OnTriggerEnter (){
		mytextmesh.text = "your guess was too high";
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
}
