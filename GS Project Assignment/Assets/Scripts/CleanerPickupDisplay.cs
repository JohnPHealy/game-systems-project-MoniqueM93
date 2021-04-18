using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanerPickupDisplay : MonoBehaviour
{
    Text text;
    public static int cleanerAmount = 0;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (cleanerAmount > 0)
            text.text = "Sanitizer: " + cleanerAmount + "%";
        else
            text.text = "Out of Sanitizer";
    }
}
