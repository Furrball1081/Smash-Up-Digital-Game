using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class FactionScript : MonoBehaviour {
	public float deckNum = 20f;
	public List<GameObject> Cards;
	public string factionName;

	
	// Use this for initialization
	void Start () {



	}


	public void AddToDeck(){
	
		foreach (Transform child in transform) {
			if (child.tag == ("Card")) {
				Cards.Add(child.gameObject);
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
