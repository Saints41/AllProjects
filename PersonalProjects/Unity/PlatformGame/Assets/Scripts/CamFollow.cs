// using UnityEngine;
// // This complete script can be attached to a camera to make it
// // continuously point at another object.

// public class CamFollow : MonoBehaviour
// {
//      Vector3 originalPos;
     

//     void Start()
//     {
//         Debug.Log("Hi");
//         //originalPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
          
//     }

//     void Update()
//     {
//         Debug.Log("Restart");
//         GameObject player = GameObject.FindWithTag("Player"); 
//         gameObject.transform.position = player.transform.position;
//     }
// }
using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

    public GameObject player;        //Public variable to store a reference to the player game object


    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start () 
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}