using UnityEngine;
using System.Collections;

public class FurnitureSelectionObjectActivatorScript : MonoBehaviour {

	public GameObject[] furnitures;
	public int rotationSpeed = 5;
	// Use this for initialization
	void Start () {

		for (int i = 0; i < furnitures.Length; i++)
			furnitures [i].SetActive (false);

		furnitures [FurnitureSelectionIndexSwitcherScript.index].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		if (FurnitureSelectionIndexSwitcherScript.index >= furnitures.Length)
			FurnitureSelectionIndexSwitcherScript.index = 0;

		if (FurnitureSelectionIndexSwitcherScript.index < 0)
			FurnitureSelectionIndexSwitcherScript.index = furnitures.Length -1;

		for (int i = 0; i < furnitures.Length; i++)
			furnitures [i].SetActive (false);

		furnitures [FurnitureSelectionIndexSwitcherScript.index].SetActive (true);

		if (RotateToggleButtonScript.rotateTOggle == 1)
			furnitures [FurnitureSelectionIndexSwitcherScript.index].transform.Rotate (Vector3.up * Time.deltaTime * rotationSpeed, Space.World);

	}
}
