using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWin : MonoBehaviour, WinInterface
{
    public void WinScene()
    {
        SceneManager.LoadScene(3);
    }
    
}
