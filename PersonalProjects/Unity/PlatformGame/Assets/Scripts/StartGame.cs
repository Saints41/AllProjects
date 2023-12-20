using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public string startLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame(){

        SceneManager.LoadScene(startLevel);
        
    }

    public void quitGame(){

        Application.Quit();
        Debug.Log("GAME QUIT");
        
    }

}
