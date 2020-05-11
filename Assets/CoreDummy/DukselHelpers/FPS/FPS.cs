using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Duksel.Helpers
{
    public class FPS : MonoBehaviour
    {
        [Header("Text Mesh Label")]

        [SerializeField]
        TextMesh labelFps;

        [SerializeField]
        TextMesh labelMessage;

        static FPS instance;

        int FrameCounter;
        int FramePerSecondLast;
        string FramePerSecondString;

        void Awake()
        {
            instance = this;
            ClearMessage();
        }

        void OnDestroy()
        {
            instance = null;
        }

        void Start()
        {
            InvokeRepeating("TickFpsFixer", 0f, 1f);
        }

        void Update()
        {
            FrameCounter++;
        }

        void TickFpsFixer()
        {
            FramePerSecondLast = FrameCounter;
            FramePerSecondString = FramePerSecondLast.ToString() + " fps";
            FrameCounter = 0;

            if (labelFps != null)
                labelFps.text = FramePerSecondString;
        }

        public static void ShowMessage(string message)
        {
            if (instance != null && instance.labelMessage != null)
                instance.labelMessage.text = message;

            Debug.Log("FPS: " + message);
        }

        public static void ClearMessage()
        {
            ShowMessage("");
        }
    }
}
