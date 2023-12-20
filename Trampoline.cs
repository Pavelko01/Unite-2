using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpStrength1 = 10;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpStrength1;

    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpStrength1;
    }
}
