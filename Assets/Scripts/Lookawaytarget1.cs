using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Lookawaytarget1 : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string booleanParameterName = "LookAt_Sliot grp 1"; // Name of the Animator boolean parameter

    public void OnTrackerLost()
    {
        StartCoroutine(ExecuteAfterDelay(15f));
    }

    private IEnumerator ExecuteAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Implement your desired logic here
        animator.SetBool(booleanParameterName, false);
    }
}
