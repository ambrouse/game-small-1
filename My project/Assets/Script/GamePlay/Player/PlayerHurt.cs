using UnityEngine;
using UnityEngine.UI;

public class PlayerHurt : MonoBehaviour
{
    [SerializeField] private Image BarHpImage; //Image bar của thanh Hp.
    [SerializeField] private Image BarHpImageBackgroundRed; //Image background bar của thanh Hp.
    [SerializeField] private Image BarHpImageBackgroundGreen; //Image background bar của thanh Hp.


    void Start()
    {
        this.BarHpImageBackgroundRed = ServiceManager.Get<PlayerBody>().playerTransform.Find("Canvas").Find("Panel").Find("HpBarBackgroundRed").GetComponent<Image>();
        this.BarHpImageBackgroundGreen = ServiceManager.Get<PlayerBody>().playerTransform.Find("Canvas").Find("Panel").Find("HpBarBackgroundGreen").GetComponent<Image>();
        this.BarHpImage = ServiceManager.Get<PlayerBody>().playerTransform.Find("Canvas").Find("Panel").Find("HpBar").GetComponent<Image>();
    }


    void Update()
    {
        ServiceManager.Get<HpManager>().DownHpEvent(this.BarHpImage, this.BarHpImageBackgroundGreen, this.BarHpImageBackgroundRed);
    }
}
