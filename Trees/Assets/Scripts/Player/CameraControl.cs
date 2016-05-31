using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    new GameObject camera;
    float speed = 5.0f;

    // Use this for initialization
    void Start () {
        camera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {

        //CAMERA MOVEMENT
        //CAMERA RIGHT
        if (Input.GetKey(KeyCode.D))
        {
            camera.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //CAMERA LEFT
        if (Input.GetKey(KeyCode.A))
        {
            camera.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //CAMERA FORWARD
        if (Input.GetKey(KeyCode.W))
        {
            camera.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        //CAMERA BACKWARD
        if (Input.GetKey(KeyCode.S))
        {
            camera.transform.position += Vector3.back * speed * Time.deltaTime;
        }
        //CAMERA UP
        if (Input.GetKey(KeyCode.Tab))
        {
            camera.transform.position += Vector3.up * speed * Time.deltaTime;
        }
        //CAMERA DOWN
        if (Input.GetKey(KeyCode.LeftShift))
        {
            camera.transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
