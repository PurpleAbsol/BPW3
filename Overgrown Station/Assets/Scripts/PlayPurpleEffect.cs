using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayPurpleEffect : MonoBehaviour
{
    public VisualEffect PurpleEffect;
    // Start is called before the first frame update
    void Start()
    {
        PurpleEffect.Stop();
    }

    void OnTriggerEnter (Collider other)
    {
        PurpleEffect.Play();
    }

    void OnTriggerExit (Collider other)
    {
        PurpleEffect.Stop();
    }
}
