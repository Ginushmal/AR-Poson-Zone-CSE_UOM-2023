using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Lookattarget : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string booleanParameterName = "LookAt_Sliot grp 1"; // Name of the Animator boolean parameter

    public void OnTrackerDetected()
    {
        // Implement your desired logic here
        animator.SetBool(booleanParameterName, true);
    }
}

