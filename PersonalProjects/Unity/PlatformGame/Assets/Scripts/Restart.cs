using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    Vector3 originalPos;

    public GameObject player;

    public string endScreen;
    

    void Start()
    {
        //Debug.Log("Hi");
        originalPos = player.transform.position; //new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);//
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Respawn" || collision.gameObject.name == "Fall"){
            player.transform.position = originalPos;
            Debug.Log("Restart");
            //Debug.Log(player.transform.position);
        }
    
        if(collision.gameObject.name == "Checkpoint 1" && collision.gameObject.tag == "Checkpoint"){
            Debug.Log("Checkpoint 1!");
            originalPos = new Vector3(5.7f, 17f, 37.25f);
            //player.transform.position = originalPos;
            //Debug.Log(player.transform.position);
        }

        if(collision.gameObject.name == "Checkpoint 2" && collision.gameObject.tag == "Checkpoint"){
            Debug.Log("Checkpoint 2!");
            originalPos = new Vector3(5.7f, 17f, 55.74f);
            //player.transform.position = originalPos;
            //Debug.Log(player.transform.position);
        }

        if(collision.gameObject.name == "Checkpoint 3" && collision.gameObject.tag == "Checkpoint"){
            Debug.Log("Checkpoint 3!");
            originalPos = new Vector3(5.7f, 17f, 67f);
            SceneManager.LoadScene(endScreen);
            //player.transform.position = originalPos;
            //Debug.Log(player.transform.position);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.tag == "Respawn" || collision.gameObject.name == "Fall"){
            player.transform.position = originalPos;
            Debug.Log("Restart");
            //Debug.Log(player.transform.position);
        }
    
        if(collision.gameObject.name == "Checkpoint 1" && collision.gameObject.tag == "Checkpoint"){
            Debug.Log("Checkpoint 1!");
            originalPos = new Vector3(5.7f, 17f, 37.25f);
            //player.transform.position = originalPos;
            //Debug.Log(player.transform.position);
        }

        if(collision.gameObject.name == "Checkpoint 2" && collision.gameObject.tag == "Checkpoint"){
            Debug.Log("Checkpoint 2!");
            originalPos = new Vector3(5.7f, 17f, 55.74f);
            //player.transform.position = originalPos;
            //Debug.Log(player.transform.position);
        }

        if(collision.gameObject.name == "Checkpoint 3" && collision.gameObject.tag == "Checkpoint"){
            Debug.Log("Checkpoint 3!");
            originalPos = new Vector3(5.7f, 17f, 67f);
            SceneManager.LoadScene(endScreen);
            //player.transform.position = originalPos;
            //Debug.Log(player.transform.position);
        }

    }

}