using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
   public AudioSource PlaySound;

    private bool muted = true;

    public void playmutesound()
    {
        if (muted == true)
        {
            muted = false;
            PlaySound.mute = false;
        }
        else
        {
            muted = true;
            PlaySound.mute = true;
        }
    }
}
