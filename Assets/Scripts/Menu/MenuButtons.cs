using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuButtons : MonoBehaviour
{

    public void PlayGame()
    {
     
        SceneManager.LoadScene(1);
        
    }

    public void Menu()
    {
     
        SceneManager.LoadScene(0);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
