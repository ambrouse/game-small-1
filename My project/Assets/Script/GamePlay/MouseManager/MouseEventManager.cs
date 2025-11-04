using UnityEngine;

public class MouseEventManager : MonoBehaviour
{

    public Vector3 mousePos; //Biến chứa thông tin vị trí của trỏ chuột


    void Update()
    {
        followMouse();
    }


    private void followMouse()
    {
        /*
            Hàm theo dõi vị trí của chuột:
                - Theo dõi và chuyển vị trí của chuột thành gameplay thay vì UI 
        */


        this.mousePos = Input.mousePosition;
        this.mousePos = Camera.main.ScreenToWorldPoint(this.mousePos);
        this.mousePos.z = 0f;
    }
}
