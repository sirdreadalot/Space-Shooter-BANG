using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerHitSound, fireLaserSound, fireRocketSound, enemyDeathSound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {

        playerHitSound = Resources.Load<AudioClip>("PlayerHit");
        fireLaserSound = Resources.Load<AudioClip>("Laser");
        fireRocketSound = Resources.Load<AudioClip>("Rocket");
        enemyDeathSound = Resources.Load<AudioClip>("EnemyDeath");

        audioSrc = GetComponent<AudioSource>();

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "PlayerHit":
                audioSrc.PlayOneShot(playerHitSound, volumeScale: 0.5f);
                break;
            case "Laser":
                audioSrc.PlayOneShot(fireLaserSound, volumeScale: 0.5f);
                break;
            case "Rocket":
                audioSrc.PlayOneShot(fireRocketSound, volumeScale: 0.5f);
                break;
            case "EnemyDeath":
                audioSrc.PlayOneShot(enemyDeathSound, volumeScale: 0.5f);
                break;
        }
    }

    public void SetSFXVolume(float volume)
    {
        audioSrc.volume = volume;
    }
}
