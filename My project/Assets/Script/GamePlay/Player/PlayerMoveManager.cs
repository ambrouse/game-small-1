using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
    [SerializeField] private MouseEventManager mouseEventManager; //Class quản lý các thông số và sự kiên chung của chuột 
    [SerializeField] private PlayerManager playerManager; //Class quản chung của player (chứa các thông tin cơ bản của player)


    void Update()
    {
        moveMouse();
    }

    public void moveMouse()
    {
        /*
            Hàm di chuyển theo vị trí chuột:
                - Gọi biến theo dõi vị trí chuột từ MouseEventManager và kéo nhân vật theo vị trí đó.
        */


        transform.position = Vector3.MoveTowards(
            transform.position,
            mouseEventManager.mousePos,
            playerManager.speedPlayer * Time.deltaTime
        );

    }


}
