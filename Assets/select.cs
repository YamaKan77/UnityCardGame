using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class select : MonoBehaviour, IPointerClickHandler
{

	public void OnPointerClick(PointerEventData eventData) // 3
	{
		print("I was clicked");
		transform.position = transform.position + Vector3.up * 10;
	}


}
