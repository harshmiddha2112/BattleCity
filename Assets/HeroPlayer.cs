using UnityEngine;
using System.Collections;

public class HeroPlayer : MonoBehaviour {

	public GameObject ground;
	private bool walking = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (walking) {
			transform.position = transform.position + Camera.main.transform.forward * 2f * Time.deltaTime;
		}
	}

}