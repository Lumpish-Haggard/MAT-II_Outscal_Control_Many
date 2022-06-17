using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour, EnumInterface
{
    
    public EnumInterface PlayerModel;

    public CharacterSwitching SwitchIt;

    public void ChangePlayer()
    {
        SwitchIt.TPose.SetActive(false);
        SwitchIt.Bench.SetActive(false);
        SwitchIt.Chair.SetActive(true);
        SwitchIt.Hydrant.SetActive(false);
    }

}
