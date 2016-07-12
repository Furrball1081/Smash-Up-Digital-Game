using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class FactionScript : MonoBehaviour {
    Player player;
    public float deckNum = 20f;
	public List<GameObject> Cards;
	public string factionName;
	
	// Use this for initialization
	void Start () {



	}


    public void AddToDeck(string afactionName) {
        factionName = afactionName;
        foreach (Transform child in transform)
        {
            if (child.tag == ("Card"))
            {
                Cards.Add(child.gameObject);
            }
        }
        GameObject player = GameObject.Find("PlayerOne");
        Player playerscript = player.GetComponent<Player>();
        playerscript.passToPlayer(Cards);
        
    }



    // Update is called once per frame
    void Update () {
	
	}
}
