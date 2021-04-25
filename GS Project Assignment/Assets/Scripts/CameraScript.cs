using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float startPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, startPoint, transform.position.z);
    }
}
