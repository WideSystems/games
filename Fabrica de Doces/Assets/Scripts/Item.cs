using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private float speed;
	private static bool isDown;
	private static bool rotation;
	GameObject audioController;
	AudioSource soundDown;
	
	// Use this for initialization
	void Start () {
		audioController = GameObject.Find("AudioController");
		soundDown = audioController.GetComponent<AudioSource>();
		rotation = false;
		if(speed == 0)
			speed *= -1;
		if(InstanciarOne.getInstanciadorPositionX() < 0)
			speed = 5f;
		else
			speed = -5f;
		isDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Z "+transform.rotation.z);
		if(Mathf.Abs(transform.rotation.z) > 0.1f){
			rotation = true;
		}

		Vector3 pos = transform.position;
		if(Input.GetMouseButtonDown (0)) {
			speed = 0;
			gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

			soundDown.Play();
		}
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Prato" || other.gameObject.tag == "Pedaco01"
		   || other.gameObject.tag == "Pedaco02" || other.gameObject.tag == "Pedaco03"){
			soundDown.Stop();
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

	public static bool isRotation(){
		return rotation;
	}
}
