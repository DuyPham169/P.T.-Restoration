using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBath : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("BathOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
