using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bench : MonoBehaviour, EnumInterface
{
    
    public EnumInterface PlayerModel;

    public CharacterSwitching SwitchIt;

    public void ChangePlayer()
    {
        SwitchIt.TPose.SetActive(false);
        SwitchIt.Bench.SetActive(true);
        SwitchIt.Chair.SetActive(false);
        SwitchIt.Hydrant.SetActive(false);
    }

}
