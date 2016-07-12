using UnityEngine;
using System.Collections;

public class factionButtonScript : MonoBehaviour {
	FactionScript factionscript;
	string factionName;
	// Use this for initialization
	void Start () {


	
	}

	public void factionSelect(){
		
		if (tag == "Aliens") {
			factionName = tag;
			Debug.Log("FACTION ALIENS");
		}
		else
		if (tag == "Zombies") {
			factionName = tag;
			Debug.Log("FACTION ZOMBIES");
		}
		else
		if (tag == "Dinosaurs") {
			factionName = tag;
			Debug.Log("FACTION DINOSAURS");
		}
		else
		if (tag == "Wizards") {
			factionName = tag;
			Debug.Log("FACTION WIZARDS");
		}

		GameObject theDeck = GameObject.Find(factionName);
		FactionScript factionscript = theDeck.GetComponent<FactionScript> ();
        factionscript.AddToDeck(factionName);
        //factionscript.AddToDeck();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
