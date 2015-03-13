using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private float speed;
	private static bool isDown;
	
	// Use this for initialization
	void Start () {
		if(speed == 0)
			speed *= -1;
		speed = 5f;
		isDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if(Input.GetMouseButtonDown (0))
		{
			speed = 0;
			gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
		}
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Prato" || other.gameObject.tag == "Pedaco01"){
			isDown = true;

		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "SpawnnerRight")
			speed *= -1;
		if(other.tag == "SpawnnerLeft")
			speed *= -1;

	}

	public static bool getIsDown(){
		return isDown;
	}

	public static void setIsDown (bool option){
		isDown = option;
	}
}
