using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Level1 (1)":
                SceneManager.LoadScene("Scene1");
                break;
            case "Level1 (2)":
                SceneManager.LoadScene("Scene2");
                break;
            case "Level1 (3)":
                SceneManager.LoadScene("Scene3");
                break;
            case "Level1 (4)":
                SceneManager.LoadScene("Scene4");
                break;
            case "Level1 (5)":
                SceneManager.LoadScene("Scene5");
                break;
            case "Level1 (6)":
                SceneManager.LoadScene("Scene6");
                break;
            case "Level1 (7)":
                SceneManager.LoadScene("Scene7");
                break;
            case "Level1 (8)":
                SceneManager.LoadScene("Scene8");
                break;
            case "Level1 (9)":
                SceneManager.LoadScene("Scene9");
                break;
        }
    }
}
