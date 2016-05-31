using UnityEngine;
using System.Collections;

public class TreeGrowthScript : MonoBehaviour
{
    GameObject stump;
    GameObject stumpBase;
    float randint;
    float pastheight;

    void Start()
    {
        stump = GameObject.Find("Stump");
        stumpBase = GameObject.Find("Base");

    }

    void Update()
    {
        //TRUNK HEIGHT
        //Make sure tree doesn't pierce through earth
        if (stumpBase.transform.position.y != 0)
        {
            stump.transform.position = new Vector3(0,stump.transform.localScale.y / 2,0);
        }

        //INCREASE SCALE
        if (Input.GetKeyDown(KeyCode.G))
        {
            stump.transform.localScale += new Vector3(0, 1, 0);
        }
        //DECREASE SCALE
        if (Input.GetKeyDown(KeyCode.V))
        {
            stump.transform.localScale += new Vector3(0, -1, 0);
        }

        //Evolution Program
        if (Input.GetKeyDown(KeyCode.U))
        {
            pastheight = stump.transform.localScale.y; 
            randint = Random.Range(-5, 20);
            stump.transform.localScale += new Vector3(0, randint, 0);
        }
        while (stump.transform.localScale.y > 400)
        {
            stump.transform.localScale -= new Vector3(0, 1, 0);
        }

    }
}