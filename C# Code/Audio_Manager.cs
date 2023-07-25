using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour {

    [Header("----------Audio Source----------")]
    [SerializeField] AudioSource volumeSource;
    [SerializeField] AudioSource sfxSource;

    [Header("----------Audio Clip----------")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip short_jump;
    public AudioClip long_jump;
    public AudioClip forward;
    public AudioClip backward;
    public AudioClip land;
    public AudioClip collect_prize;
    public AudioClip coin1;
    public AudioClip coin2;
    public AudioClip finish_line;

    private void Start() {
    volumeSource.clip = background;
    volumeSource.Play();
    }

}
