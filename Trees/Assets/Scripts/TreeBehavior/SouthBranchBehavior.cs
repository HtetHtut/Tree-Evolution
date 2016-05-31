using UnityEngine;
using System.Collections;

public class SouthBranchBehavior : MonoBehaviour
{
    GameObject
        testBranch,
        Branch,
        Side;
    float
        h, w, hyp, d,
        theta;

    // Use this for initialization
    void Start()
    {
        testBranch = GameObject.Find("southBranch");
        Branch = GameObject.Find("southBranchBase");
        Side = GameObject.Find("northSide");


        h = testBranch.transform.localScale.y;
        w = testBranch.transform.localScale.x;
        theta = testBranch.transform.localRotation.z;
        d = (Mathf.Sqrt((h * h) + (w * w)) * Mathf.Sin(theta));
    }

    // Update is called once per frame
    void Update()
    {

        //SHIFT Y VALUE of Branch
        if (Side.transform.position.y != testBranch.transform.position.y)
        {
            testBranch.transform.position = new Vector3(Side.transform.position.x - d, Side.transform.position.y, 0);
        }

    }
}
