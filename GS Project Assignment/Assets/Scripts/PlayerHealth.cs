using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealthDisplay.healthLevel < 5)
        {
            SceneManager.LoadScene(4);
            CleanerPickupDisplay.cleanerAmount = 0;
            MaskPickUpDisplay.maskAmount = 0;
            PlayerHealthDisplay.healthLevel = 100;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Virus"))
        {
            PlayerHealthDisplay.healthLevel -= 5;
        }
   }
}
