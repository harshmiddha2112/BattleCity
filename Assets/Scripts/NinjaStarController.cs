using UnityEngine;
using System.Collections;

public class NinjaStarController : MonoBehaviour {

	float starSpeed = 9.0f;
	float rotationSpeed = 0f;
	
	void Start () {
		this.GetComponent<Rigidbody>().velocity = this.transform.up * starSpeed;
		this.GetComponent<Rigidbody>().angularVelocity = this.transform.forward * rotationSpeed;
    }
	
	void OnCollisionEnter (Collision collision) {
//		Debug.Log("Aman");
		//print("here");
		if (collision.collider.name == "Enemy") {
			collision.collider.GetComponent<EnemyMover>().DieSoon();
			Destroy(gameObject);
		}
		else if (collision.collider.tag == "Wall") {
			collision.collider.GetComponent<Brick>().DieSoon();
			Destroy(gameObject);
		}
	}


}
