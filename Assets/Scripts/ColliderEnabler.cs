using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnabler : MonoBehaviour
{
    public GameObject objectToEnable;                           //Object to enable after trigger.
    [Tooltip("Set if a Tag is required for the collitionning Object")]
    public bool tagRequired = false;

    [Tooltip("Enter the required Tag")]
    public string requiredTag = "Player";                             //Required tag by the other object 
    // Start is called before the first frame update
    void Start()
    {
        objectToEnable.SetActive(false);                        //Disables the object.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (tagRequired == true)                                        //Checks if a tag is required from the object collitionning
        {
            if (other.tag == requiredTag)                          
            {
                objectToEnable.SetActive(true);                 //Enables the object if Tag matches
            }
        }
        else if(tagRequired==false)
        {
            objectToEnable.SetActive(true);                     //Enables the object ignoring the other object's tag.
       }
    }
}
