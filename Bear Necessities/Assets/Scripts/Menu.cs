using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void PlayButton()
    {
        //Need to add scene
        //SceneManager.LoadScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }

    public void OptionsMenu()
    {

    }
}
