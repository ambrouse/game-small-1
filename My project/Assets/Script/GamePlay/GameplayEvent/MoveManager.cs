using UnityEngine;

public class MoveManager : MonoBehaviour
{
    void Awake()
    {
        ServiceManager.Register<MoveManager>(this); // Đăng ký với ServiceManager.
    }
    

    public void move(Transform transformOnject, Vector3 targetPos, float speed)
    {
        /*
            Hàm di chuyển một object đến một điểm được truyền vào:
                - Dùng hàm MoveTowards để tạo độ mượt.
                - Dùng để di chuyển các nhân vật.
        */


        transformOnject.transform.position = Vector3.MoveTowards(
                transformOnject.transform.position,
                targetPos,
                speed * Time.deltaTime
            );
    }
}
