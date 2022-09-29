using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkRecorder : MonoBehaviour
{
    private GameObject cabinet;
    private GameObject transceiver;
    private List<GameObject> transceivers = new List<GameObject>();

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
    }

    void Update()
    {
        //Debug.Log(transceiver.GetComponent<RaycastReflection>());
    }
    
}
