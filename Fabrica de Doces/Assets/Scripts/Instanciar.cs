using UnityEngine;
using System.Collections;

public class Instanciar : MonoBehaviour {

	public float minSpawnTime;
	public float maxSpawnTime;
	public float spawnItem;

	public GameObject[] Itens;
	private GameObject item;
	private int i;

	public float downForce = -200;
	//public float leftForce = 200f;
	public static float minX, maxX; //posicao do instanciador

	// Use this for initialization
	void Start () {
		minX = GerenciarCamera.MinX ();
		maxX = GerenciarCamera.MaxX ();
		StartCoroutine("Instanciador");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool RandomItem(){
		if (Itens.Length > 0) {
			i = Random.Range(0, Itens.Length);
			return true;
		}
		return false;
	}

	private IEnumerator Instanciador(){
		spawnItem = Random.Range (minSpawnTime, maxSpawnTime);
		yield return new WaitForSeconds (spawnItem);

		if (RandomItem ()) {
			//item = Instantiate(Itens[i], new Vector2 (Random.Range(minX, maxX), transform.position.y), 
			                  // Quaternion.Euler(0,0,Random.Range(-60,60))) as GameObject;

			item = Instantiate(Itens[i], new Vector2 (transform.position.x, transform.position.y), 
			                   Quaternion.identity) as GameObject;

			if(item.transform.position.x > 0){
				//item.GetComponent<Rigidbody2D>().AddForce(new Vector2 (-leftForce, downForce));
				item.GetComponent<Rigidbody2D>().AddForce(new Vector2 (0f, downForce));
			} else {
				//item.GetComponent<Rigidbody2D>().AddForce(new Vector2 (leftForce, downForce));
				item.GetComponent<Rigidbody2D>().AddForce(new Vector2 (0f, downForce));
			}


			StartCoroutine("Instanciador");

		}

	}

}
