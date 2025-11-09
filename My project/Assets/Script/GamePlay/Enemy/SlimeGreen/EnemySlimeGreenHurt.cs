using UnityEngine;
using UnityEngine.UI;

public class EnemySlimeGreenHurt : MonoBehaviour
{

    void Update()
    {
        HpManagerController();
    }


    private void HpManagerController()
    {
        if (ServiceManager.Get<SlimeGreenManager>().slimeGreens.Count == 0)
            return;

        foreach (var item in ServiceManager.Get<SlimeGreenManager>().slimeGreens)
        {
            ServiceManager.Get<HpManager>().DownHpEvent(item.barHpImage, item.barHpImageBackgroundGreen, item.barHpImageBackgroundRed);
        }
    }



    
}
