using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioTrigger : MonoBehaviour
{
    public AudioSource radioSound;
    public AudioSource radioTalk;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            radioSound.enabled = false;
            radioTalk.enabled = true;
        }
    }
}
