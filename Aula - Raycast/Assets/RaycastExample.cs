using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    int mask;
    private LineRenderer _lineRenderer;

    private void Start()
    {
        mask = LayerMask.GetMask("Sphere");
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.SetPosition(1, transform.forward);
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * 200 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        Ray ray = new Ray(transform.position, transform.forward);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50, ~mask))
        {
            print("Acertou algo a " + hit.distance + " metros.");
            Debug.DrawLine(ray.origin, hit.point);
            _lineRenderer.SetPosition(1, hit.point);
        }
        else
        {
            _lineRenderer.SetPosition(1, transform.forward);
        }

        Debug.DrawRay(ray.origin, ray.direction, Color.green);
        
    }
}
