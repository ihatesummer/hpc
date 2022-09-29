using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetPlacer : MonoBehaviour
{
    public GameObject cabinetPrefab;
    public static int n_column = 10;
    public static int n_cabinet_per_column = 20;
    public float space_btwn_column;
    public float rack_width_z;

    private float left_anchor;
    private float bottom_anchor;
    private float pos_x;
    private float pos_z;
    private GameObject transceiver;

    void Awake()
    {
        GameObject cabinets = new GameObject("Cabinets");

        left_anchor = -(n_column-1)/2 * space_btwn_column; // x position
        bottom_anchor = -(n_cabinet_per_column-1)/2 * rack_width_z; // z position

        pos_x = left_anchor;
        pos_z = bottom_anchor;
        for (int i = 0; i < n_column ; i++)
        {
            for (int j = 0; j <n_cabinet_per_column; j++)
            {
                GameObject cabinet = Instantiate(cabinetPrefab, new Vector3(pos_x, 1, pos_z), Quaternion.identity);
                cabinet.transform.parent = cabinets.transform;
                cabinet.name = string.Format("cabinet_{0}_{1}", i, j);
                transceiver = cabinet.transform.Find("Transceiver").gameObject;
                transceiver.transform.localPosition += new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
                pos_z += rack_width_z;
            }
            pos_z = bottom_anchor;
            pos_x += space_btwn_column;
        }
    }
}
