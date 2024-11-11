using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCene : MonoBehaviour
{
    public GameObject destruir;

    public void GoToSceneAfideo(){
        SceneManager.LoadScene("Game Afideo");
        Destroy(destruir);
    }

    public void GoToSceneParasitoide(){
        SceneManager.LoadScene("Game Parasitoide");

    }
}