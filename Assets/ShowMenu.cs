using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowMenu : MonoBehaviour
{
    public Transform player;

    public float distPlayer = 3.0f;

    public GameObject menu;

    public InputActionProperty showButton;
    
    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame()){
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = player.position + new Vector3(player.forward.x,0,player.forward.z).normalized * distPlayer;

        }

        menu.transform.LookAt(new Vector3(player.position.x,menu.transform.position.y, player.position.z));

        menu.transform.forward *=-1;
    }
}
