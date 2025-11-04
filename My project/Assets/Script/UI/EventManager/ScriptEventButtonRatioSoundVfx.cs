using UnityEngine;
using UnityEngine.EventSystems;

public class ScriptEventButtonRatioSoundVfx : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler // ke thua lai cac interface thiet ke san de bat su kien chuot cho UI
{
    [SerializeField] private RectTransform handle; // đối tượng mà chuột sẽ tác động tới (nút ratio(handle)).
    [SerializeField] private RectTransform bar; // thanh slide dùng để đo phần trăm của ratio.
    private bool dragging = false; // biến xác định trạng thái của mouse mouse (true: dang duoc nhap, false: khi đang thả chuột).

    public void OnPointerDown(PointerEventData eventData)
    {
        /*
            Hàm bắt sự kiện khi chuột được nhấn
                - thay đổi trạng thái biến trạng thái.
                - gọi hàm cập nhật lại vịt trí của handle.
        */


        dragging = true;
        UpdateHandle(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        /*
            Hàm bắt sự kiện khi chuột được nhã
                - thay đổi trạng thái biến trạng thái.
        */


        dragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        /*
            Hàm bắt sự kiện khi chuột được kéo
                - gọi hàm để liên tục cập nhật lại vịt trí của handle(nút ratio).
        */


        if (dragging)
            UpdateHandle(eventData);
    }

    private void UpdateHandle(PointerEventData eventData)
    {
        /*
            Hàm cập nhật lại ví trí của handle(nút ratio)
                - tính toán lại vị trí của handle bằng cách chuyển đổi vị trí của mouse sang tọa độ của rectranform.
                - tính toán ratio bằng cách chia tỉ lệ của vị trí của handle hiện tại so với slide (0-1)
        */


        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(bar, eventData.position, eventData.pressEventCamera, out localPos); // chuyển đổi vị trí chuột trên màn hình (Screen Space) → thành vị trí toạ độ cục bộ (Local Space) trong RectTransform của một UI element và gán vào biến localPos.

        float halfWidth = bar.rect.width / 2f;
        localPos.x = Mathf.Clamp(localPos.x, -halfWidth, halfWidth);
        localPos.y = 0;

        handle.localPosition = localPos;

        float ratio = Mathf.Round((localPos.x + halfWidth) / bar.rect.width * 10f)/10;
        Debug.Log($"Volume sound vfx: {ratio}");
    }
}
