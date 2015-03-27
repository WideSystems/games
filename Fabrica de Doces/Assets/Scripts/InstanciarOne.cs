using UnityEngine;
using System.Collections;

public class InstanciarOne : MonoBehaviour {
	
	public GameObject[] Itens;
	private GameObject item;
	private int j;
	private float x = -3.838f;
	private float y = -1;
	private static float positionX;
	public int numberOfObjects; //numero de objetos a serem instanciados para cada cena;
	Vector2 pos;
	
	// Use this for initialization
	void Start () {
		pos = new Vector2(x, y);
		transform.position = pos;
		positionX = transform.position.x;
		createObject();
	}
	
	// Update is called once per frame
	void Update () {
		positionX = transform.position.x;
		if(Item.getIsDown()){
			x*=-1;
			if(y < 0)
				y*=-1;

			Item.setIsDown(false);
			if(!Item.isRotation() && numberOfObjects > 0)
				createObject();
			else 
				cameraDown();
			y+= 0.5f;
		}
	}

	void createObject(){
		Debug.Log("Criou");

		if(numberOfObjects < Itens.Length && numberOfObjects > 0){
			j+=1;
		}
		Vector2 newPosition = new Vector2(x, y);
		transform.position = newPosition;

		item = Instantiate(Itens[j], new Vector2 (transform.position.x, transform.position.y), 
		                   Quaternion.identity) as GameObject;

		item.AddComponent<Item>();
		Debug.Log("terminou");
		numberOfObjects -= 1;
	}

	public static float getInstanciadorPositionX(){
		return positionX;
	}

	private void cameraDown(){
		MainCamera.setIsDown(true);

	}

	/*
	void OnGUI(){
		
		GUI.contentColor = Color.black;
		
		GUI.Label(new Rect (10,0,100,50),"MAX X " + transform.position.y, "color");
		GUI.Label(new Rect (10,20,100,50),"MAX X " + oldPosition.y, "color");

	}
	*/


}
