using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitching : MonoBehaviour
{
    public GameObject TPose;
    public GameObject Bench;
    public GameObject Chair;
    public GameObject Hydrant;

    // Start is called before the first frame update
    void Start()
    {
        TPose.SetActive(true);
        Bench.SetActive(false);
        Chair.SetActive(false);
        Hydrant.SetActive(false);
        
    }

    void OnTriggerStay(Collider Convert)

    {   
        EnumInterface ModelInterface = Convert.GetComponent<EnumInterface>();
        if(ModelInterface != null)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                ModelInterface.ChangePlayer();
            }
        }
        
    }

}
