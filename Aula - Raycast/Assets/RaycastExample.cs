using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    int mask;

    private void Start()
    {
        mask = LayerMask.GetMask("Sphere");
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * 200 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        //Ray ray = new Ray(transform.position, transform.forward);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50, ~mask))
        {
            print("Acertou algo a " + hit.distance + " metros.");
            Debug.DrawLine(ray.origin, hit.point);
        }

        Debug.DrawRay(ray.origin, ray.direction, Color.green);
        
    }
}
