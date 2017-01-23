using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public float speedMin;
	public float speedMax;


	enum BrickState { Normal, Dying};

	private BrickState _state;

	// Use this for initialization.
	void Start () {
		_state = BrickState.Normal;
		float thisSpeed = Random.Range(speedMin, speedMax);
		this.GetComponent<Rigidbody>().velocity = transform.forward * thisSpeed;
	}


	/// <summary>
	/// Check and see if our enemy is in a dying state. We need this because occasionally
	/// momentum drives a "dead" enemy through the end zone.
	/// </summary>
	/// <returns><c>true</c> if this enemy is dying; otherwise, <c>false</c>.</returns>
	public bool IsDying() {
		return (_state == BrickState.Dying);
	}


	/// <summary>
	/// Remove the game object after a short moment so we can watch it get knocked around.
	/// </summary>
	public void DieSoon() {
		if (_state == BrickState.Normal) {
			Debug.Log("I'm here");
			// Let's let the enemy get knocked back a bit.
			_state = BrickState.Dying;
//			GameController gameController = FindObjectOfType<GameController>();
//			gameController.GotOne();
//			this.GetComponent<AudioSource>().Play();
			Destroy(gameObject);
		}
	}



}

