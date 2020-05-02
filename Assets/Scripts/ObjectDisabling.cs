using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisabling : MonoBehaviour
{
    public GameObject objectToDisable;
    public float timeToWaitBeforeToggle=10f;
    public float timeSinceDeactivation;
    public float timeSinceActivation;
    private Rigidbody bodyToDisable;
    // Start is called before the first frame update
    void Start()
    {
        timeSinceDeactivation = timeToWaitBeforeToggle;                     //Sets de time Since Deactivation for script logic ease of use.            
        timeSinceActivation = timeToWaitBeforeToggle;                     //Sets de time Since Activation for script logic ease of use.  
    }

    // Update is called once per frame
    void Update()
    {

        #region Key press handler and Activation timer.
        if (Input.GetKeyDown(KeyCode.E))                                                            //Checks if a specific Key is pressed.
        {
            if ((objectToDisable.activeSelf==true)&&(timeSinceActivation>=timeToWaitBeforeToggle))          //IF object is enable and if it has been more than the time to wait it will disable it.
            {
                objectToDisable.SetActive(false);                                               //Disables the object.
                timeSinceDeactivation = 0f;                                                     //Resets the timer for logic purposes
            }
        }
        if ((objectToDisable.activeSelf == true) && (timeSinceActivation <= timeToWaitBeforeToggle))
        {
            timeSinceActivation += Time.deltaTime;                        //increases the time since object is activated.
        }
        #endregion

        #region Re-enable Object.
        if ((objectToDisable.activeSelf == false) && (timeSinceDeactivation >= timeToWaitBeforeToggle))
        {
            objectToDisable.SetActive(true);                                               //Enables the object.
            timeSinceActivation = 0f;
        }
        else if ((objectToDisable.activeSelf == false) && (timeSinceDeactivation < timeToWaitBeforeToggle))
        {
            timeSinceDeactivation += Time.deltaTime;                        //increases the timer
        }

        #endregion
    }



}
