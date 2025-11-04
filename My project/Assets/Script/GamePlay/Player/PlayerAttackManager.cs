using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager; //Class quản chung của player (chứa các thông tin cơ bản của player)
    [SerializeField] private LayerMask layerMaskEnemy; //Layer của quái
    [SerializeField] private float delay; //Thông số delay khi va chạm với quái (vừa va chạm thì 4s nữa mới va chạm tiếp)
    void Start()
    {
        this.delay = 0;
    }


    void Update()
    {
        coliderEvent();
    }


    private void coliderEvent()
    {
        /*
            Hàm bắt va chạm của player:
                - Dùng cơ chế tính toán vật lý bằng tay.
                - Dùng hàm OverlapBox bắt theo hình hộp (chiều rộng, chiều dài).
        */

        if (delay <= 1)
        {
            this.delay = 1;
            Collider2D hit = Physics2D.OverlapBox(transform.position, new Vector2(1, 2), 0f, layerMaskEnemy);
            if (hit != null) {
                Debug.Log("Va chạm");
                this.delay = 4;
            }

        }
        else
        {
            this.delay -= this.delay * Time.deltaTime;
        }
    }

    
}
