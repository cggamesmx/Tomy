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

    [Tooltip("Set if a pressing the M key is required")]
    public bool mKeyPressRequired = false;                          //Select if a KeyPress is required to do the action.

    [Tooltip("Set if you want to disable the object once there is no collition")]
    public bool disableObjectOnExitTrigger = false;             //Select if you need to disable the object once there is no collision detected.

    // Start is called before the first frame update
    void Start()
    {
        objectToEnable.SetActive(false);                        //Disables the object.
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if ((mKeyPressRequired == true) && (Input.GetKeyDown(KeyCode.M)))                       //FIRST check if a Key Press is required.
            {
            if (tagRequired == true)                                        //Checks if a tag is required from the object collisionning
            {
                if (other.tag == requiredTag)
                {
                    objectToEnable.SetActive(true);                 //Enables the object if Tag matches
                }
            }
            else if (tagRequired == false)
            {
                objectToEnable.SetActive(true);                     //Enables the object ignoring the other object's tag.
            }
        }else if (mKeyPressRequired == false)        //does the same then previous block, but it requires a keypress
        {
            if (tagRequired == true)                                        //Checks if a tag is required from the object collisionning
            {
                if (other.tag == requiredTag)
                {
                    objectToEnable.SetActive(true);                 //Enables the object if Tag matches
                }
            }
            else if (tagRequired == false)
            {
                objectToEnable.SetActive(true);                     //Enables the object ignoring the other object's tag.
            }
        }
    }

    private void OnTriggerStay(Collider other)                      //ACTIVATES while On Trigger Stay
    {
        if ((mKeyPressRequired == true) && (Input.GetKeyDown(KeyCode.M)) )                      //FIRST check if a Key Press is required.
        {
            if (tagRequired == true)                                        //Checks if a tag is required from the object collisionning
            {
                if (other.tag == requiredTag)
                {
                    objectToEnable.SetActive(true);                 //Enables the object if Tag matches
                }
            }
            else if (tagRequired == false)
            {
                objectToEnable.SetActive(true);                     //Enables the object ignoring the other object's tag.
            }
        }
    }


    private void OnTriggerExit(Collider other)                  //Disables the object after the collision
    {
        if (disableObjectOnExitTrigger == true)
        {
            objectToEnable.SetActive(false);
        }
    }

}
