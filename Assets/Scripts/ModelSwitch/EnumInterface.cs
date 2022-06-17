using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerModels { //discontinued enums.
    Null = 0,
    TPose = 1,
    Bench = 2,
    Chair = 3,
    Hydrant = 4
}

public interface EnumInterface {
    public void ChangePlayer();
}
