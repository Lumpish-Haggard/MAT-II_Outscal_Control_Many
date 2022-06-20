using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{

    private void OnCollisionEnter(Collision Collide) 
    {
        LogicInterface Logic = Collide.gameObject.GetComponent<LogicInterface>();
        if (Logic != null)
        {
            Logic.DeathScene();
        }
        
    }

}
