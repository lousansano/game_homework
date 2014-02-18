using UnityEngine;
using System.Collections;

public class tenprint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// to get a random Whole number thats either 0 or 2
		int randomNumber = Random.Range (0, 2);

		if (randomNumber == 0) {
			GetComponent<TextMesh>().text += "\\";
		} else {
			GetComponent<TextMesh>().text += "/";
		}
	}
}