using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource musicAudioSource;

    public static float musicVolume;

    public static bool musicMute;

    public void SetMusicValue(float _value)
    {
        musicAudioSource.volume = _value;
        musicVolume = _value;
    }

    public void SetMuteStatus(bool _value)
    {
        musicAudioSource.mute = _value;
        musicMute = _value;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
