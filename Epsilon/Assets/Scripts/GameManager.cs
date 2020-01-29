using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject pauseMenu;
	private AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
		backgroundMusic = GetComponent<AudioSource>();
		//backgroundMusic.volume = 0;
		backgroundMusic.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1) 
		{
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
			backgroundMusic.Pause();
		} else if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
		{
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
			backgroundMusic.UnPause();
		}
			
    }
}
