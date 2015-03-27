using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	private Transform player;
	public float smooth = 5.0f;
	private static bool isDown;

	// Use this for initialization
	void Start () {
		isDown = false;
		player = GameObject.FindGameObjectWithTag("Instanciador").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isDown)
			cameraUp();
		else 
			cameraDown();
		
	}

	public static void setIsDown(bool param){
		isDown = param;
	}

	private void cameraUp(){
		Vector3 novaPosicao = new Vector3 (transform.position.x, Mathf.Abs(player.position.y), transform.position.z);
		transform.position = Vector3.Lerp (transform.position, novaPosicao, Time.deltaTime * smooth);
	}

	private void cameraDown(){
		Vector3 novaPosicao = new Vector3 (transform.position.x, Mathf.Abs(player.position.y), transform.position.z);
		while (novaPosicao.y > 1f){
			novaPosicao.y -= 1f;
			transform.position = Vector3.Lerp (transform.position, novaPosicao, Time.deltaTime * smooth);
		}
		//Application.LoadLevel(Application.loadedLevel);
	}
}
