using UnityEngine;
using System.Collections;

public class GerenciarCamera : MonoBehaviour {

	public Camera camera;

	private static float minX;
	private static float maxX;
	private static float minY;
	private static float maxY;
	private int i;
	private float distanciaZ;
	private static Vector2 cameraPosition;
	private static bool isIncrement;

	// Use this for initialization
	void Start () {
		isIncrement = false;
		i = 0;
		distanciaZ = transform.position.z - camera.transform.position.z;
		minX = camera.ScreenToWorldPoint (new Vector3 (0, 0, distanciaZ)).x;
		maxX = camera.ScreenToWorldPoint (new Vector3 (Screen.width, 0, distanciaZ)).x;

		minY = camera.ScreenToWorldPoint (new Vector3 (0, 0, distanciaZ)).y;
		maxY = camera.ScreenToWorldPoint (new Vector3 (0, Screen.height, distanciaZ)).y;

	}
	
	// Update is called once per frame
	void Update () {
		if(isIncrement){
			Debug.Log("entrou");
			i+=1;
			cameraPosition = new Vector2(transform.position.x, transform.position.y + i);
			transform.position = cameraPosition;
			isIncrement = false;
		}
	}

	public static float MaxX(){
		return maxX;
	}
	
	public static float MinX(){
		return minX;
	}

	public static float MaxY(){
		return maxY;
	}

	public static float MinY(){
		return minY;
	}

	public static void setIsIncrement(bool option){
		isIncrement = option;
	}

	public static bool getIsIncrement(){
		return isIncrement;
	}

	/*
	void OnGUI(){
		
		GUI.contentColor = Color.black;
		
		GUI.Label(new Rect (10,0,100,50),"MAX X " + maxX, "color");
		GUI.Label(new Rect (10,30,100,50),"MIN X " + minX, "color");
	}
	*/
}
