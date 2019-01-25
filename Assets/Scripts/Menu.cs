using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


    public string level_1;
    public string level_2;
    public string level_3;

    public void StartLevel1() {

        SceneManager.LoadScene(level_1);
    }
    public void StartLevel2()
    {

        SceneManager.LoadScene(level_2);
    }

    public void Startlevel3() {

        SceneManager.LoadScene(level_3);
    }



    public void QuitGame() {
        Application.Quit();

    }
   


}
