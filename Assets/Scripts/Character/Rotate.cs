using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public Transform target;
    public bool rotate;
    private Quaternion targetRotation;

    void Update()
    {
        if (target && rotate)
        {
            transform.LookAt(target);
        }
    }

}
