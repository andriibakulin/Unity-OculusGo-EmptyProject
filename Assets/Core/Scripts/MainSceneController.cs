using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Duksel.Helpers;

public class MainSceneController : MonoBehaviour
{
	void Update()
	{
		if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
		{
            FPS.ShowMessage("Trigger down");
		}
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            FPS.ClearMessage();
        }

        if (OVRInput.GetDown(OVRInput.Button.Back))
		{
            FPS.ShowMessage("Back button down");
		}
        else if (OVRInput.GetUp(OVRInput.Button.Back))
        {
            FPS.ClearMessage();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
		{
            FPS.ShowMessage("PrimaryTouchpad down");
		}
        else if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            float x = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).x;
            float y = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).y;

            FPS.ShowMessage("Touchpad [" + x.ToString("F2") + "x" + y.ToString("F2") + "]");
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryTouchpad))
        {
            FPS.ClearMessage();
        }
	}
}
