using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefend2 : MonoBehaviour
{
    public GameObject sprayItem;
    public Transform throwSprayPoint;
    public bool hasSpray = false;
    public AudioSource spraySound;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            SprayShoot();
        }

        if (CleanerPickupDisplay.cleanerAmount > 0)
        {
            hasSpray = true;
        } else
        {
            hasSpray = false;
        }
    }

    void SprayShoot()
    {
        if (!hasSpray)
            return;

        CleanerPickupDisplay.cleanerAmount -= 5;
        GameObject si = Instantiate(sprayItem, throwSprayPoint);
        si.transform.parent = null;

        spraySound.Play();
    }
}
