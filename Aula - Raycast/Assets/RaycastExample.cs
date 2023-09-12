using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    LayerMask mask;

    private void Start()
    {
        mask = LayerMask.GetMask("Sphere");
        Debug.Log(mask);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * 200 * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        //Ray ray = new Ray(transform.position, new Vector3(0, 0, 1));
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            print("Acertou algo a " + hit.distance + " metros.");
            Debug.DrawLine(ray.origin, hit.point);
        }

        Debug.DrawRay(ray.origin, ray.direction, Color.green);
        
    }
}
