using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void btn_keluargame()
    {
        Application.Quit();
    }

    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume",volume);
    }

    
}
