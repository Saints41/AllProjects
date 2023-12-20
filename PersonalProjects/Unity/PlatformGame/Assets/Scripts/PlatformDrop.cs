using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{

    bool isFalling = false;
    float downSpeed = 0;
    Vector3 platPosition;
    // Start is called before the first frame update
    void Start()
    {
        platPosition = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(isFalling){
           Invoke("MyFunction", 2);
            
        }
    }
    void MyFunction()
    {
        downSpeed += Time.deltaTime/10;
        transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);
        //Debug.Log("Stall!");  
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player"){
            //Debug.Log("Falling");
            isFalling = true;
        }

        if(collision.gameObject.name == "Fall"){
            Invoke("respawnPlatformsFun",5);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.name == "Player"){
            //Debug.Log("Falling");
            isFalling = true;
        }

        if(collision.gameObject.name == "Fall"){
            Invoke("respawnPlatformsFun",5);
        }
    }

    void respawnPlatformsFun(){
        StartCoroutine("respawnPlatform");
    }

    IEnumerator respawnPlatform() {
        Destroy(gameObject);
        Instantiate(gameObject, platPosition, Quaternion.identity);
        yield return null;
    }

}
