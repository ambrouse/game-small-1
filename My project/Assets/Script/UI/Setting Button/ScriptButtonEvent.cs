using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    [SerializeField] private Button buttonPlay;
    [SerializeField] private Button buttonQuit;

    void Start()
    {
        buttonPlay.onClick.AddListener(OnclickButtonPlay);
        buttonQuit.onClick.AddListener(OnclickButtonQuit);
    }


    void Update()
    {

    }

    private void OnclickButtonPlay()
    {
        Debug.Log("Button Play clicked!");
    }
    private void OnclickButtonQuit()
    {
        Debug.Log("Button Quit clicked!");
    }
    

}
