using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TouchRotatorScript : MonoBehaviour {
	public Text debugText;
	public GameObject[] furnitures;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 1) 
		{
			float touchValue = Input.GetTouch (0).deltaPosition.x;
			furnitures [FurnitureSelectionIndexSwitcherScript.index].transform.Rotate (-1f * Vector3.up * touchValue * rotationSpeed * Time.deltaTime, Space.World);
		}

	}
}
