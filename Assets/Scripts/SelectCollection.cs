using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCollection : MonoBehaviour {

	public GameObject[] imag=new GameObject[12];

	public Sprite[] im = new Sprite[12];

	public bool Shop;

	public GameObject Collection;
	void OnMouseDown()
	{
		for (int i = 0; i < imag.Length; i++) {
			imag[i].GetComponent<Image> ().sprite = im[i];

			if (Shop == true) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			 else 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (161, 153, 153, 155);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(0,0);
				Collection.GetComponent<Image> ().color = new Color32 (161, 153, 153, 155);
			}
		}
	}

}
