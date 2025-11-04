using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManagerMenuMap : MonoBehaviour
{
    [SerializeField] private Button buttonMap1; // nút bắt sự kiện khi vào map 1
    [SerializeField] private Button buttonMap2; // nút bắt sự kiện khi vào map 2
    [SerializeField] private Button buttonMap3; // nút bắt sự kiện khi vào map 3
    [SerializeField] private Button buttonBackMenu; // nút bắt sự kiện khi quay lại menu
    [SerializeField] private LoadsceneManager loadsceneManager; // class quản lý load scene


    void Start()
    {
        buttonMap1.onClick.AddListener(OnclickButtonMap1);
        buttonMap2.onClick.AddListener(OnclickButtonMap2);
        buttonMap3.onClick.AddListener(OnclickButtonMap3);
        buttonBackMenu.onClick.AddListener(OnclickButtonBackMenu);
    }


    private void OnclickButtonMap1()
    {
        /*
            Hàm bắt event click để chuyển scene
        */


        StartCoroutine(loadsceneManager.LoadGame("SceneGameMap1"));
    }
    private void OnclickButtonMap2()
    {

    }
    private void OnclickButtonMap3()
    {

    }
    private void OnclickButtonBackMenu()
    {
        /*
            Hàm bắt event click để chuyển scene
        */


        StartCoroutine(loadsceneManager.LoadGame("SceneMenu"));
    }

    
}
