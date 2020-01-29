using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{

	public GameObject gameManager;	

    public void SetLevel (float sliderValue)
	{
		AudioSource backgroundMusic = gameManager.GetComponent<AudioSource>();
		backgroundMusic.volume = sliderValue;
	}
}
