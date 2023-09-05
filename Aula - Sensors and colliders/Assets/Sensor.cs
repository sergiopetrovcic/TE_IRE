using UnityEngine;

public class Sensor : MonoBehaviour
{
    private Material _material;
    private float _translateSpeed = 1f;

    void Start()
    {
        _material = GetComponent<Renderer>().material;
        _material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        _material.color = Color.red;
    }

    Vector3 v, dir;

    private void OnTriggerStay(Collider other)
    {
        v = other.transform.position;
        v.y = transform.position.y;
        transform.LookAt(v);

        dir = (transform.position - v);
        if (dir.magnitude > 1)
            transform.Translate(dir.normalized * _translateSpeed * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other)
    {
        _material.color = Color.yellow;
    }
}
