using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDoor : MonoBehaviour
{
    public bool collisonWithPlayer = false;


    Scene currentScene;
    string sceneName;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            collisonWithPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            collisonWithPlayer = false;
        }
    }

    void Update()
    {
        if (collisonWithPlayer && Input.GetKeyDown(KeyCode.W))
        {
            print("hit");
            SceneManager.LoadScene("Level2");
        }
     }
}
