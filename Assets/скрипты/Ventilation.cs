using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ventilation : MonoBehaviour
{
    [SerializeField]
    Animator ventaAnimator;
    [SerializeField]
    Button but; 
    [SerializeField]
    Canvas DoorMessage;
    [SerializeField]
    float openVentilation;
    [SerializeField]
    float closeVentilation;
    float speed = 1;
    private string openTrigger = "open";

    public bool isOpen;
    public bool isLocked;
    public int id;

    void Start()
    {
        but.onClick.AddListener(OpenVentilation);
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
    void OpenVentilation()
    {
        ventaAnimator.SetTrigger(openTrigger);

    }
}
