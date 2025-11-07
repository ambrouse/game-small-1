using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackManager : MonoBehaviour
{
    [SerializeField] private Image BarHpImage; //Image bar của thanh Hp.
    [SerializeField] private Image BarHpImageBackgroundRed; //Image background bar của thanh Hp.
    [SerializeField] private Image BarHpImageBackgroundGreen; //Image background bar của thanh Hp.

    private float delay; //Thông số delay khi va chạm với quái (vừa va chạm thì 3s nữa mới va chạm tiếp).


    void Start()
    {
        this.delay = 0;
        this.BarHpImageBackgroundRed = ServiceManager.Get<PlayerManager>().playerTransform.Find("Canvas").Find("Panel").Find("HpBarBackgroundRed").GetComponent<Image>();
        this.BarHpImageBackgroundGreen = ServiceManager.Get<PlayerManager>().playerTransform.Find("Canvas").Find("Panel").Find("HpBarBackgroundGreen").GetComponent<Image>();
        this.BarHpImage = ServiceManager.Get<PlayerManager>().playerTransform.Find("Canvas").Find("Panel").Find("HpBar").GetComponent<Image>();
    }


    void Update()
    {
        ColiderEvent();
        DownHpEvent();
    }


    private void ColiderEvent()
    {
        /*
            Hàm bắt va chạm của player:
                - Dùng cơ chế tính toán vật lý bằng tay.
                - Dùng hàm OverlapBox bắt theo hình hộp (chiều rộng, chiều dài).
                - Trừ máu Player bằng enemy dame khi va chạm.
        */


        if (delay > 1)
        {
            this.delay -= 1f * Time.deltaTime;
            return;
        }


        Collider2D enemyColider = Physics2D.OverlapBox(transform.position, new Vector2(1, 2), 0f, ServiceManager.Get<EnemyManager>().layerMaskEnemy);

        if (enemyColider != null)
        {
            Debug.Log("Va chạm voi: " + enemyColider.gameObject.name);
            ServiceManager.Get<PlayerManager>().hpPlayer -= ServiceManager.Get<EnemyManager>().dameEnemy;
            this.delay = 5f;
        }

    }


    private void DownHpEvent()
    {
        /*
            Hàm trừ Hp của player:
                - Trừ Hp gốc của player.
                - Kéo thanh slide của bar Hp cho đồng bộ với thông số Hp.
        */


        this.BarHpImage.fillAmount = ServiceManager.Get<PlayerManager>().hpPlayer / 100f ;

        this.BarHpImageBackgroundGreen.fillAmount = Mathf.MoveTowards(
            this.BarHpImageBackgroundGreen.fillAmount,
            (ServiceManager.Get<PlayerManager>().hpPlayer / 100f),
            Time.deltaTime * 5f);
        
        this.BarHpImageBackgroundRed.fillAmount = Mathf.MoveTowards(
            this.BarHpImageBackgroundRed.fillAmount,
            (ServiceManager.Get<PlayerManager>().hpPlayer / 100f),
            Time.deltaTime * 0.2f);



        

    }

    
}
