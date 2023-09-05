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

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _material.color = Color.red;
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 v = other.transform.position;
        v.y = transform.position.y;
        transform.LookAt(v);

        Vector3 dir = (transform.position - v);
        if (dir.magnitude > 1)
            transform.Translate(dir.normalized * _translateSpeed * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other)
    {
        _material.color = Color.yellow;
    }
}
