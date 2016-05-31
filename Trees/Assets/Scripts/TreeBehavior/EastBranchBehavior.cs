using UnityEngine;
using System.Collections;

public class EastBranchBehavior : MonoBehaviour
{
    GameObject
        testBranch,
        Branch,
        Side;
    float
        h, w, hyp, d, theta;

    // Use this for initialization
    void Start()
    {
        testBranch = GameObject.Find("eastBranch");
        Branch = GameObject.Find("eastBranchBase");
        Side = GameObject.Find("westSide");


        h = testBranch.transform.localScale.y;
        w = testBranch.transform.localScale.z;
        theta = testBranch.transform.localRotation.x;
        d = (Mathf.Sqrt((h * h) + (w * w)) * Mathf.Sin(theta));
    }

    // Update is called once per frame
    void Update()
    {

        //SHIFT Y VALUE of Branch
        if (Side.transform.position.y != testBranch.transform.position.y)
        {
            testBranch.transform.position = new Vector3(0, Side.transform.position.y, Side.transform.position.z + d);
        }

    }
}
