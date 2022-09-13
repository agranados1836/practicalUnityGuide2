using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class touch : MonoBehaviour
{
    public TextMeshProUGUI PhaseDisplayText;
    private Touch theTouch;
    private float TouchTime, displayTime = 0.5f;

    void Start()
    {

    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            PhaseDisplayText.SetText(theTouch.phase.ToString());
            if (theTouch.phase == TouchPhase.Ended)
            {
                TouchTime = Time.time;
            }
        }
        else if (Time.time - TouchTime > displayTime)
        {
            PhaseDisplayText.SetText(" ");
        }
    }
}
