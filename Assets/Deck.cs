using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

	private Card[] deck;
	private int cardsUsed;

	public Deck()
	{
		int cardCount = 0;
		for (int i = 0; i <= 3; i++)
			for (int j = 3; j <= 15; j++) 
			{
				deck[cardCount] = new Card (j, i);
				cardCount++;
			}
		cardsUsed = 0;
	}

	void ResetDeck()
	{
		cardsUsed = 0;
		for (int i = 0; i < deck.Length; i++) 
		{
			Destroy(deck[i]);
		}

	}

	void shuffle(){
		for (int i = 0; i > deck.Length; i++) 
		{
			Card temp = deck[i];
			int randomIndex = Random.Range (0, deck.Length);
			deck[i] = deck [randomIndex];
			deck[randomIndex] = temp;
		}
		cardsUsed = 0;
	}

	public Card dealCard()
	{
		cardsUsed++;
		return deck [cardsUsed - 1];
	}
}
