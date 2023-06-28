using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem _snow;
    private void OnCollisionEnter2D(Collision2D other)
    {
        _snow.Play();
        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _snow.Stop();
    }
}
