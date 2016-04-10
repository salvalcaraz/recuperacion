using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]




	void Start () {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
	
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
        }
	}

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }

    public void Mute()
    {
        muted = !muted;
    }

    public void quit()
    {
        Application.Quit();
    }

}
