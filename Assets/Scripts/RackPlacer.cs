using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackPlacer : MonoBehaviour
{
    public GameObject rackPrefab;
    public static int n_column = 10;
    public static int n_row = 10;
    public float space_btwn_column;
    public float space_btwn_row;
    public float rack_width_z;
    public List<GameObject> transceivers = new List<GameObject>();
    public bool bComplete = false;
    public Material cable_material;
    private float left_anchor;
    private float bottom_anchor;
    private float pos_x;
    private float pos_z;
    private GameObject transceiver;

    void Awake()
    {
        GameObject racks = new GameObject("Racks");

        left_anchor = -(n_column-1)/2 * space_btwn_column; // x position
        bottom_anchor = -(n_row-1)/2 * rack_width_z; // z position

        pos_x = left_anchor;
        pos_z = bottom_anchor;
        for (int i = 0; i < n_column ; i++)
        {
            for (int j = 0; j < n_row; j++)
            {
                GameObject rack = Instantiate(
                    rackPrefab,
                    new Vector3(pos_x, 1, pos_z),
                    Quaternion.identity);
                rack.transform.parent = racks.transform;
                rack.name = string.Format("rack_{0}_{1}", i, j);
                transceiver = rack.transform.Find("Transceiver").gameObject;
                // transceiver.transform.localPosition += new Vector3(Random.Range(-0.3f, 0.3f), 0, 0);
                transceivers.Add(transceiver);
                if(i == n_column-1) {
                    GameObject cable_hor = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                    cable_hor.transform.position = new Vector3((pos_x+left_anchor)/2, 0.5f, pos_z);
                    cable_hor.transform.parent = racks.transform;
                    cable_hor.transform.rotation *= Quaternion.Euler(new Vector3(0, 0f, 90f));
                    cable_hor.transform.localScale = new Vector3(0.07f, 9f, 0.07f);
                    cable_hor.GetComponent<MeshRenderer>().material = cable_material;
                    cable_hor.name = string.Format("cable_hor_{0}", j);
                }
                if (j != n_row-1){
                    pos_z += rack_width_z + space_btwn_row;
                }
            }

            GameObject cable_vert = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cable_vert.transform.position = new Vector3(pos_x, 0.5f, (pos_z+bottom_anchor)/2);
            cable_vert.transform.parent = racks.transform;
            cable_vert.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
            cable_vert.transform.localScale = new Vector3(0.07f, 6f, 0.07f);
            cable_vert.GetComponent<MeshRenderer>().material = cable_material;
            cable_vert.name = string.Format("cable_vert_{0}", i);

            pos_z = bottom_anchor;
            pos_x += space_btwn_column;
        }

        GameObject racks2 = GameObject.Instantiate(racks);
        racks2.transform.name = "Racks_2";
        racks2.transform.position += new Vector3(22.5f, 0f, 0f);

        bComplete = true;
    }
}
