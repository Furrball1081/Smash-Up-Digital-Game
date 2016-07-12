using UnityEngine;
using System.Collections;


public class Drawcard : MonoBehaviour {

	public bool Draw = false;
	string factionName;
	
	// Use this for initialization
	void Start () {

		//GameObject theDeck = GameObject.Find (factionName);
		//FactionScript factionScript= theDeck.GetComponent<FactionScript> ();
		//factionScript.AddToDeck ();


	}
	
	// Update is called once per frame
	void Update () {

		}


	public void onClick(){
		Draw = !Draw;
		if (Draw == true) {
			//GameObject theDeck = GameObject.Find ("Zombies");
			//FactionScript factionScript = theDeck.GetComponent<FactionScript> ();

			Draw = !Draw;
		}

	}
}

