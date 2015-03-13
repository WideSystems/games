using UnityEngine;
using System.Collections;

public class InstanciarOne : MonoBehaviour {
	
	public GameObject[] Itens;
	private GameObject item;
	private int i;
	private int j;
	public int numberOfObjects; //numero de objetos a serem instanciados para cada cena;
	Vector2 oldPosition;
	
	// Use this for initialization
	void Start () {
		i = 0;
		createObject();
	}
	
	// Update is called once per frame
	void Update () {
		if(Item.getIsDown()){
			Item.setIsDown(false);
			i+=1;
			createObject();
		}
	}

	void createObject(){
		GerenciarCamera.setIsIncrement(true);
		Vector2 newPosition = new Vector2(transform.position.x, transform.position.y +i);
		transform.position = newPosition;
		item = Instantiate(Itens[j], new Vector2 (transform.position.x, transform.position.y), 
		                   Quaternion.identity) as GameObject;

		item.AddComponent<Item>();

		}

	/*
	void OnGUI(){
		
		GUI.contentColor = Color.black;
		
		GUI.Label(new Rect (10,0,100,50),"MAX X " + transform.position.y, "color");
		GUI.Label(new Rect (10,20,100,50),"MAX X " + oldPosition.y, "color");

	}
	*/
}
