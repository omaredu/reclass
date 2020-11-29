using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public int next_level;
    // Start is called before the first frame update
    void Start()
    {
        next_level = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(next_level);
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
