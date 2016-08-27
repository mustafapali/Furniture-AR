using UnityEngine;
using System.Collections;

public class FurnitureSelectionIndexSwitcherScript : MonoBehaviour {

    public static int index = 0;
	// Use this for initialization
	void Start () {
        index = 0;
	}
	
	public void onNext()
    {
        index++;
    }
    public void onPrev()
    {
        index--;
    }
}
