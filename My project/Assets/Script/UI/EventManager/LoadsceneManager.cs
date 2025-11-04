using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadsceneManager : MonoBehaviour
{
   public IEnumerator LoadGame(String nameScene)
    {
        /*
            Hàm load scene.
                - Gọi LoadSceneAsync để load scene 
                - Cập nhật thanh slide tiến độ theo % của progress load.
        */


        // AsyncOperation op = SceneManager.LoadSceneAsync(nameScene);
        // op.allowSceneActivation = false;

        // while (op.progress < 0.9f)
        // {
        //     Debug.Log(op.progress);
        //     yield return null;
        // }

        // progressBar.value = 1f;
        
        // op.allowSceneActivation = true;


        /*
            Hàm fake load scene để test các màn hình loading
        */

        AsyncOperation op = SceneManager.LoadSceneAsync(nameScene);
        op.allowSceneActivation = false;
        float progress = 0f;
        while (progress < 1f)
        {
            progress += Time.deltaTime * 1f; // 1s đầy
            Debug.Log("Fake Progress: " + progress + "___" + Time.deltaTime);
            yield return null;
        }
        op.allowSceneActivation = true;


    }
}
