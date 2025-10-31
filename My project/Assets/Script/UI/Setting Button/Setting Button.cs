using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    [SerializeField] private Button button1;

    void Start()
    {
        button1.onClick.AddListener(OnclickButton1);
    }


    void Update()
    {

    }

    private void OnclickButton1()
    {
        Debug.Log("Button clicked!");
    }
    

}
