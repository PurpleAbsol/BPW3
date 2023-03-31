using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayPinkEffect : MonoBehaviour
{
    public VisualEffect PinkEffect;
    // Start is called before the first frame update
    void Start()
    {
        PinkEffect.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        PinkEffect.Play();
    }

    void OnTriggerExit (Collider other)
    {
        PinkEffect.Stop();
    }

}

