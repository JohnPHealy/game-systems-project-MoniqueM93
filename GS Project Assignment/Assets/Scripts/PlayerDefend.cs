using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefend : MonoBehaviour
{
    public GameObject maskItem;
    public Transform throwPoint;
    public bool hasMasks = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (MaskPickUpDisplay.maskAmount > 0)
        {
            hasMasks = true;
        } else
        {
            hasMasks = false;
        }
    }

    void Shoot()
    {
        if (!hasMasks)
            return;

        MaskPickUpDisplay.maskAmount -= 1;
        GameObject si = Instantiate(maskItem, throwPoint);
        si.transform.parent = null;
    }
}
