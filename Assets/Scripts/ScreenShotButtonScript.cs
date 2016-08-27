using UnityEngine;
using System;
using System.Collections;

public class ScreenShotButtonScript : MonoBehaviour {
	
	public void onScreenShot()
	{
		String dateTime = DateTime.Now.Minute.ToString () + DateTime.Now.Hour.ToString () + DateTime.Now.Date.Day.ToString ();
		String fileName = "ScreenShot" + dateTime+".png";
		Debug.Log (fileName);
		Application.CaptureScreenshot (fileName);

	}
}
