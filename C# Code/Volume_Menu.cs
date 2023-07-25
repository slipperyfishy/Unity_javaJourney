using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume_Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume) {
        audioMixer.SetFloat("Volume_Slider", volume);
    }
}
