using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading_bar : MonoBehaviour
{
    public Image loadingfill;

    void Start() {
        StartCoroutine(Loading());
    }

    IEnumerator Loading() {
        AsyncOperation loading = SceneManager.LoadSceneAsync("Menu_utama");

        while (!loading.isDone) {
        
        // float progressValue = Mathf.Clamp01(operatio.prograss / 0.9f)
            loadingfill.fillAmount = loading.progress/0.9f;
            print(loading.progress);
            yield return null;
        }
    }
}
