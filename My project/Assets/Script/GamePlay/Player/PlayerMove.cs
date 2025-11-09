using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        MoveMouse();
    }

    public void MoveMouse()
    {
        /*
            Hàm di chuyển theo vị trí chuột:
                - Gọi biến theo dõi vị trí chuột từ MouseEventManager và kéo nhân vật theo vị trí đó.
        */


        ServiceManager.Get<PlayerBody>().playerTransform.transform.position = Vector3.MoveTowards(
            transform.position,
            ServiceManager.Get<MouseEventManager>().mousePos, //Trỏ tới Class MouseEventManager trong serviceManager.
            ServiceManager.Get<PlayerBody>().speedPlayer * Time.deltaTime //Trỏ tới class PlayerManager trong serviceManager.
        );

    }


}
