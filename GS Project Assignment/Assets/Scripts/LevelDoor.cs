using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDoor : MonoBehaviour
{
    public bool collisonWithPlayer = false;
    public Sprite closedDoor;

    Scene currentScene;
    string sceneName;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collisonWithPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collisonWithPlayer = false;
        }
    }

    private void Update()
    {
        if (collisonWithPlayer = true && Input.GetKeyDown(KeyCode.W) && sceneName == "Level1")
        {
            SceneManager.LoadScene("Level2");
        } else if (collisonWithPlayer = true && Input.GetKeyDown(KeyCode.W) && sceneName == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
    }

}
