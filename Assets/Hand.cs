using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand {

	ArrayList hand = new ArrayList();
	bool roundDone;
	bool gameDone;
	bool start;
	string ID;

	public Hand()
	{
		roundDone = false;
		gameDone = false;
		start = false;
		ID = null;
	}

	public void addCard(Card c)
	{
		hand.Add(c);
	}

	public void remove(Card c)
	{
		for (int i = 0; i < hand.Count; i++) {
			
		}
	}
}
