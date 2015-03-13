using UnityEngine;
using System.Collections;

public class Prato : MonoBehaviour {
	
	//public Vector2 startPos;
	//public Vector2 direction;
	//public bool directionChosen;
	//public string teste = "";
	//private Vector3 wantedPos;
	//private HingeJoint2D hinge2d;

	public float speed = 2.5f; //for mouse
	private Vector3 target; //for mouse
	
	// Use this for initialization
	void Start () {
		//hinge2d = GetComponent <HingeJoint2D>();
		target = transform.position;// for mouse
	}
	
	void Update() {
		// Track a single touch as a direction control.
		/*
		if (Input.touchCount > 0) {
			var touch = Input.GetTouch(0);
			
			// Handle finger movements based on touch phase.
			switch (touch.phase) {
				// Record initial touch position.
			case TouchPhase.Began:
				//startPos = touch.position;
				//directionChosen = false;
				break;
				
				// Determine direction by comparing the current touch position with the initial one.
			case TouchPhase.Moved:
				//direction = touch.position - startPos;
				direction = touch.position;
				break;
				
				// Report that a direction has been chosen when the finger is lifted.
			case TouchPhase.Ended:
				directionChosen = true;
				break;
			}

			Vector3 pos = transform.position;
			wantedPos = Camera.main.ScreenToWorldPoint (new Vector3(direction.x, 0, 10));
			pos.x = wantedPos.x;
			transform.position = pos;
			*/



 	}
	/*
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Pedaco01"){
			HingeJoint2D myJoint = gameObject.AddComponent<HingeJoint2D>();
			myJoint.connectedBody = other.rigidbody;
			myJoint.connectedAnchor = new Vector2 (-0.05868936f, -0.6646059f);
		}
	}
	 */


}