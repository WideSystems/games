using UnityEngine;
using System.Collections;

public class Prato : MonoBehaviour {

	public Vector2 startPos;
	public Vector2 direction;
	public bool directionChosen;
	public string teste = "";

	// Use this for initialization
	void Start () {

	}

	void Update() {
		// Track a single touch as a direction control.

		if (Input.touchCount > 0) {
			var touch = Input.GetTouch(0);
			
			// Handle finger movements based on touch phase.
			switch (touch.phase) {
				// Record initial touch position.
			case TouchPhase.Began:
				startPos = touch.position;
				directionChosen = false;
				break;
				
				// Determine direction by comparing the current touch position with the initial one.
			case TouchPhase.Moved:
				direction = touch.position - startPos;
				break;
				
				// Report that a direction has been chosen when the finger is lifted.
			case TouchPhase.Ended:
				directionChosen = true;
				break;
			}
		

			if(direction.x > 0f){
				if(transform.position.x == 0f){
					transform.position = new Vector2(1.8f, transform.position.y);
				}else {
					transform.position = new Vector2(0f, transform.position.y);					
				}

			} else {
				if(transform.position.x == 0f){
					transform.position = new Vector2(-1.8f, transform.position.y);
				}else {
					transform.position = new Vector2(0f, transform.position.y);
				}
			}

		}

	}

	void OnGUI(){
		GUI.contentColor = Color.black;
		GUI.Label(new Rect (10,0,100,50),"Inicio " + startPos, "color");
		GUI.Label(new Rect (10,30,100,50),"Movido " + direction, "color");
		GUI.Label(new Rect (10,60,100,50),"Movido " + teste, "color");

		float merda = GerenciarCamera.MaxX();

		GUI.Label(new Rect (10,80,100,50),"MaxX " +  merda, "color");
		GUI.Label(new Rect (10,100,100,50),"MinX " + GerenciarCamera.MinX(), "color");

	}
}
