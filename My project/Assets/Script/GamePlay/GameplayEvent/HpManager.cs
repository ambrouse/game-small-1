using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    void Awake()
    {
        ServiceManager.Register<HpManager>(this);
    }

    public void DownHpEvent(Image barHpImage, Image barHpImageBackgroundGreen, Image barHpImageBackgroundRed)
    {
        /*
            Hàm trừ Hp của player:
                - Trừ Hp gốc của player.
                - Kéo thanh slide của bar Hp cho đồng bộ với thông số Hp.
        */


        barHpImage.fillAmount = ServiceManager.Get<PlayerBody>().hpPlayer / 100f;

        barHpImageBackgroundGreen.fillAmount = Mathf.MoveTowards(
            barHpImageBackgroundGreen.fillAmount,
            (ServiceManager.Get<PlayerBody>().hpPlayer / 100f),
            Time.deltaTime * 5f);

        barHpImageBackgroundRed.fillAmount = Mathf.MoveTowards(
            barHpImageBackgroundRed.fillAmount,
            (ServiceManager.Get<PlayerBody>().hpPlayer / 100f),
            Time.deltaTime * 0.2f);
    }
}
