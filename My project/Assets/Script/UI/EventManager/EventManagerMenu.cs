using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManagerMenu : MonoBehaviour
{
    [SerializeField] private Button buttonPlay; // nút bắt sự kiện khi bắt đầu trò chơi
    [SerializeField] private Button buttonQuit; // nút bắt sự kiện khi thoát trò chơi
    [SerializeField] private LoadsceneManager loadsceneManager; // class quản lý load scene

    void Start()
    {
        buttonPlay.onClick.AddListener(OnclickButtonPlay);
        buttonQuit.onClick.AddListener(OnclickButtonQuit);
    }


    private void OnclickButtonPlay()
    {
        /*
            Hàm chạy khi bắt được event nút play (menu -> chọn map -> vào game):
                - gọi hàm load scene bằng StartCoroutine
        */


        StartCoroutine(loadsceneManager.LoadGame("SceneMapMenu"));
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


    

    

}
