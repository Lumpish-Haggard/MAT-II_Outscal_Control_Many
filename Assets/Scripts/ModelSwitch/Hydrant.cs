using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrant : MonoBehaviour, EnumInterface
{
    
    public EnumInterface PlayerModel;

    CharacterSwitching SwitchIt;

    public void ChangePlayer()
    {
        SwitchIt.TPose.SetActive(false);
        SwitchIt.Bench.SetActive(false);
        SwitchIt.Chair.SetActive(false);
        SwitchIt.Hydrant.SetActive(true);
    }

}