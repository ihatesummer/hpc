using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RaycastReflection : MonoBehaviour
{
    public int n_reflections;
    public float maxLength;
    public List<string> available_links;

    private LineRenderer lineRenderer;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 direction;
    private float rotateSpeed;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //rotateSpeed = Random.Range(-30f, 30f);
        rotateSpeed = 30f;
    }

    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float remainingLength = maxLength;

        for (int i = 0; i <= n_reflections ; i++)
        {
            if(Physics.Raycast(ray.origin, ray.direction, out hit, remainingLength))
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                remainingLength -= Vector3.Distance(ray.origin, hit.point);
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
            }
            else
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLength);
            }
        }
        // TODO: make rotation stop after full circle
        transform.Rotate(0f, Time.deltaTime * rotateSpeed, 0f);
        Debug.Log(hit.collider.gameObject.transform.parent.name);
        // if (available_links.Contains(hit.collider.gameObject.name))
        // {
        //     available_links.Add(hit.collider.gameObject.name);
        // }
    }
}
