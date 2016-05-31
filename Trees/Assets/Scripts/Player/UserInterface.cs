using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour {

    GameObject stump,treeHeight,nBranch,branchPos,northSide;
    string heighttext;
    string nBranchPos;


    // Use this for initialization
    void Start()
    {
        stump = GameObject.Find("Stump");
        treeHeight = GameObject.Find("treeHeight");
        nBranch = GameObject.Find("NorthBranchBase");
        branchPos = GameObject.Find("northSidePosition");
        northSide = GameObject.Find("northSide");
    }
    

    // Update is called once per frame
    void Update()
    {
        //USER INTERFACE
        //DISPLAY CURRENT TREE HEIGHT

        treeHeight.GetComponent<Text>().text = stump.transform.localScale.y.ToString();
        branchPos.GetComponent<Text>().text = northSide.transform.position.y.ToString();
    }
}
