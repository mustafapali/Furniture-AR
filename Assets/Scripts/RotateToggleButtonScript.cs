using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotateToggleButtonScript : MonoBehaviour {

	public static int rotateTOggle = 0;
	Image buttonBG;
	// Use this for initialization
	void Start () {
		buttonBG = GetComponent<Image> ();
		rotateTOggle = 0;
	}
	
	public void rotate()
	{
		if (rotateTOggle == 0) {
			rotateTOggle = 1;
			buttonBG.color = new Color (167f,255f,0.0f,112f);
		} else {
			rotateTOggle = 0;
			buttonBG.color = new Color (255f,255f,255f,112f);
		}
	}	
}
