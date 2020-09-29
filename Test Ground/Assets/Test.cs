using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TP.Pose a = new TP.Pose(
            new Vector3(1, 2, 0),
            new Quaternion(0, 0, 0, 0),
            new Vector3(1, 1, 1)
        );

        TP.Pose b = new TP.Pose(
            new Vector3(3, 0, 1),
            new Quaternion(0, 0, 0, 0),
            new Vector3(1, 1, 1)
        );

        Debug.Log(string.Format("Pose 1 {0}\nPose 2 {1}", a, b));
    }
}
