using UnityEngine;
using System.Collections;

public class genz : MonoBehaviour {
	int buildingCount = 0;

	public GameObject thing_1Prefab;
	public GameObject thing_2Prefab;
	public GameObject thing_3Prefab;
	public GameObject thing_4Prefab;
	public GameObject thing_5Prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if ( buildingCount < 500 ) {
		float randomNumber = Random.Range (0f, 100f);
			
			if ( randomNumber < 25.0f ) {
				Instantiate ( thing_1Prefab, new Vector3( Random.Range (-200f, 200f), 0,  Random.Range (-200f, 200f) ), Quaternion.identity );
			}
			else if ( randomNumber < 50f && randomNumber > 25f ) {
	
				Instantiate ( thing_2Prefab, new Vector3( Random.Range (-200f, 200f), 0,  Random.Range (-200f, 200f) ), Quaternion.identity );
			}
			else if ( randomNumber < 70f && randomNumber > 50f ) {
	
				Instantiate ( thing_3Prefab, new Vector3( Random.Range (-200f, 200f), 0,  Random.Range (-200f, 200f) ), Quaternion.identity );
			}
			else if ( randomNumber < 90f && randomNumber > 70f ) {
	
				Instantiate ( thing_4Prefab, new Vector3( Random.Range (-200f, 200f), 0,  Random.Range (-200f, 200f) ), Quaternion.identity );
			}
			else if ( randomNumber < 100f && randomNumber > 90f ) {
	
				Instantiate ( thing_5Prefab, new Vector3( Random.Range (-200f, 200f), 0,  Random.Range (-200f, 200f) ), Quaternion.identity );
			}
				buildingCount = buildingCount + 1;
	}
}
}