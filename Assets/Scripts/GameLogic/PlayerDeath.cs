using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour, LogicInterface
{
    public void DeathScene()
    {
        SceneManager.LoadScene(2);
    }

}
