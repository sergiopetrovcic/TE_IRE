using UnityEngine;

public class RaycastExample : MonoBehaviour
{
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

        Ray ray = new Ray(transform.position, new Vector3(0, 0, 1));
        if (Physics.Raycast(ray, out hit))
        {
            print("Acertou algo a " + hit.distance + " metros.");
        }

        Debug.DrawRay(ray.origin, ray.direction, Color.green);
    }
}
