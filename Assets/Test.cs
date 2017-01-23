using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.1f, 0f));
		}
	}
}
