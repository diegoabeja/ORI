using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonBongoe : MonoBehaviour {

	GameObject Nivel1;
	GameObject MenuGame;
	GameObject StartGame;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClick()
	{
		Debug.Log("Hola Funciono");
		Nivel1= (GameObject)Instantiate(Resources.Load("Prefabs/Nivel1"), transform.position, transform.rotation);
		Nivel1.name = "Nivel1";
		MenuGame = GameObject.Find ("MenuGame");
		Destroy (MenuGame);

	}
}
