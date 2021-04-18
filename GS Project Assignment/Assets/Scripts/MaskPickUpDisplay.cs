using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskPickUpDisplay : MonoBehaviour
{
    Text text;
    public static int maskAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (maskAmount > 0)
            text.text = "Masks: " + maskAmount;
        else
            text.text = "No Masks";
    }
}
