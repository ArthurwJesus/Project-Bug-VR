using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinGameMenu : MonoBehaviour
{

    public GameObject simulator;

    public void GoToSceneMenu(){
        SceneManager.LoadScene("Main menu");
        Destroy(simulator);
    }
}
