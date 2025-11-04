using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptEventManagerMenu : MonoBehaviour
{
    [SerializeField] private Button buttonPlay; // nút bắt sự kiện khi bắt đầu trò chơi
    [SerializeField] private Button buttonQuit; // nút bắt sự kiện khi thoát trò chơi

    void Start()
    {
        buttonPlay.onClick.AddListener(OnclickButtonPlay);
        buttonQuit.onClick.AddListener(OnclickButtonQuit);
    }


    private void OnclickButtonPlay()
    {
        /*
            Hàm chạy khi bắt được event nút play (menu -> chọn map -> vào game).
                - gọi hàm load scene bằng StartCoroutine
        */


        StartCoroutine(LoadGame());
        Debug.Log("Button Play clicked!");
    }


    private void OnclickButtonQuit()
    {
        /*
            Hàm xử lý khi quit game
        */


        Application.Quit(); // hàm chạy khi app đã build
        EditorApplication.isPlaying = false; //hàm chạy khi edit
    }


    private IEnumerator LoadGame()
    {
        /*
            Hàm load scene.
                - Gọi LoadSceneAsync để load scene 
                - Cập nhật thanh slide tiến độ theo % của progress load.
        */


        // AsyncOperation op = SceneManager.LoadSceneAsync("SceneMapMenu");
        // op.allowSceneActivation = false;

        // while (op.progress < 0.9f)
        // {
        //     Debug.Log(op.progress);
        //     yield return null;
        // }

        // progressBar.value = 1f;
        // op.allowSceneActivation = true;


        /*
            Hàm fake load scene để test các màn hình loading.
        */

        AsyncOperation op = SceneManager.LoadSceneAsync("SceneMapMenu");
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
