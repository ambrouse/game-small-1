using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float angle;
    
    void Update()
    {
        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(ServiceManager.Get<MouseEventManager>().mousePos);
        Vector2 direction =  (ServiceManager.Get<MouseEventManager>().mousePos - transform.position).normalized;
        this.angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, this.angle - 45f);
    }
}
