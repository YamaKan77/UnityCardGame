using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{

	private Card[] deck;

	public Deck()
	{
		int cardCount = 0;
		for (int i = 0; i <= 3; i++)
			for (int j = 3; j <= 15; j++) {
				deck [cardCount] = new Card (j, i);
				cardCount++;
			}


	}

}
