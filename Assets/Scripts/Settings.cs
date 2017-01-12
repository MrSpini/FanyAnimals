using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

	public GameObject settings;
	public GameObject GamePanel;
	public GameObject MenuPanel;


	void OnMouseUp()
	{
		if(settings.activeInHierarchy==false){
		settings.SetActive (true);
		GamePanel.SetActive (false);
		MenuPanel.SetActive (false);
		}
		else
		{
			settings.SetActive (false);
			GamePanel.SetActive (true);
			MenuPanel.SetActive (true);
		}
	}
}
