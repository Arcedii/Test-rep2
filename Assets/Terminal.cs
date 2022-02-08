using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Terminal : MonoBehaviour
{
    [SerializeField]
    Button but;
    [SerializeField]
    Canvas DoorMessage;
    [SerializeField]
    float openTerminal;
    [SerializeField]
    float closeTerminal;
    float speed = 1;
   

    public bool isOpen;
    public bool isLocked;
    public int id;

    void Start()
    {
       
        DoorMessage.gameObject.SetActive(false);
    }

  

    private void OnCollisionEnter(Collision collision)
    {
        DoorMessage.gameObject.SetActive(true);

    }
    private void OnCollisionExit(Collision collision)
    {
        DoorMessage.gameObject.SetActive(false);

    }


    private void OnDestroy()
    {

        if (DoorMessage)
        {
            DoorMessage.gameObject.SetActive(false);
        }


    }
    public void NextLevel(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

}
