using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LinkRecorder : MonoBehaviour
{
    private GameObject cabinet;
    private GameObject transceiver;
    private List<GameObject> transceivers = new List<GameObject>();
    private LineRenderer lineRenderer;
    private Ray ray;

    void Start()
    {
        for (int i = 0; i < CabinetPlacer.n_column ; i++)
        {
            for (int j = 0; j < CabinetPlacer.n_cabinet_per_column; j++)
            {
                cabinet = GameObject.Find(string.Format("cabinet_{0}_{1}", i, j));
                transceiver = cabinet.transform.Find("Transceiver").gameObject;
                transceivers.Add(transceiver);
            }
        }
        Debug.Log(transceivers.Count + " transceivers found");        
        


        GameObject tx = transceivers[0];
        GameObject rx = transceivers[11];
        float ray_dist = Vector3.Distance(tx.transform.position, rx.transform.position);
        Debug.Log("tx: " + tx.transform.parent.name);
        Debug.Log("rx: " + rx.transform.parent.name);
        Debug.Log("dist: " + ray_dist);

        ray = new Ray(tx.transform.position, transceiver.transform.forward);
        Physics.Raycast(ray.origin, ray.direction, ray_dist);
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, tx.transform.position);
        lineRenderer.SetPosition(1, rx.transform.position);
    }

    void Update()
    {
        //Debug.Log(transceiver.GetComponent<RaycastReflection>());
    }
    
}
