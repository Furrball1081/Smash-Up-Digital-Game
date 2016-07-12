using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public string playerName = "Kyle";
    public bool hasDeckOne = false;
    public bool hasDeckTwo = false;
    public List<GameObject> deckOne;
    public List<GameObject> deckTwo;
    public List<GameObject> mainDeck;
    public int playerVP = 0;
    // Use this for initialization
    void Start () {
   
}
	public void playerReport()
    {
        Debug.Log(playerName);
        Debug.Log(playerVP);
        if (hasDeckOne == true)
            Debug.Log("Has Deck One");
        else if (hasDeckOne == false)
            Debug.Log("Doesn't have Deck One");
        if (hasDeckTwo == true)
            Debug.Log("Has Deck Two");
        else if (hasDeckTwo == false)
            Debug.Log("Doesn't have Deck Two");
    }

    public void passToPlayer(List<GameObject> aCard)
    {
        if ((hasDeckOne == false) &(hasDeckTwo == false))
        {
            buildOne(aCard);
        }
        else if ((hasDeckOne == true)&(hasDeckTwo==false))
        {
            buildTwo(aCard);
        }

    }

    public void buildOne(List<GameObject> bCard)
    {
        foreach (GameObject i in bCard)
        {
            deckOne.Add(i);
            Debug.Log("Cards Deck1 Added");
        }
        hasDeckOne = true;
    }
    public void buildTwo(List<GameObject> cCard)
    {
        foreach (GameObject i in cCard)
        {
            deckTwo.Add(i);
            Debug.Log("Cards Deck2 Added");
        }
        hasDeckTwo = true;
        startingShuffle();
    }

    public void startingShuffle()
    {
        System.Random rnd = new System.Random();
        System.Random arnd = new System.Random();
        for (int p = 0; p<deckOne.Count; p++)
        {
            GameObject temp = deckOne[p];
            int randomIndex = rnd.Next(p, deckOne.Count);
            deckOne[p] = deckOne[randomIndex];
            deckOne[randomIndex] = temp;
        }
        for (int q = 0; q < deckOne.Count; q++)
        {
            GameObject atemp = deckTwo[q];
            int randomIndex = arnd.Next(q, deckTwo.Count);
            deckTwo[q] = deckTwo[randomIndex];
            deckTwo[randomIndex] = atemp;
        }
        foreach (GameObject w in deckOne)
        {
            mainDeck.Add(w);
        }
        foreach (GameObject y in deckTwo)
        {
            mainDeck.Add(y);
        }
        for (int l = 0; l<3; l++)
        {

            System.Random zrnd = new System.Random();

            for (int z = 0; z < mainDeck.Count; z++)
            {
                GameObject temp = mainDeck[z];
                int randomIndex = zrnd.Next(z, mainDeck.Count);
                mainDeck[z] = mainDeck[randomIndex];
                mainDeck[randomIndex] = temp;
            }
        }
    }

    void Update () {
	
	}
}
