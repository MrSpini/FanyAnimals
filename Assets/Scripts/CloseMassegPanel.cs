﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseMassegPanel : MonoBehaviour {
	public GameObject MassagPanel;
	public GameObject GamePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		MassagPanel.SetActive (false);
		GamePanel.SetActive (true);
	}
}
