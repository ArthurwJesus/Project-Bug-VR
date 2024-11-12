using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCene : MonoBehaviour
{
    public GameObject destruir;

    public void Start()
    {
        AudioManager.Instance.musicSource.Play();
    }

    public void GoToSceneAfideo(){
        SceneManager.LoadScene("Game Afideo");
        AudioManager.Instance.musicSource.Stop();
        Destroy(destruir);
    }

    public void GoToSceneParasitoide(){
        SceneManager.LoadScene("Game Parasitoide");
        AudioManager.Instance.musicSource.Stop();
        Destroy(destruir);


    }
}