using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class select : MonoBehaviour, IPointerClickHandler
{
	public delegate void ClickAction();
	public static event ClickAction OnClicked;

	public void OnPointerClick(PointerEventData data)
	{
		Debug.Log ("Clicked");
	}


}
