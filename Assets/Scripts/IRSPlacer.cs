using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IRSPlacer : MonoBehaviour
{
    public GameObject IRS_boardPrefab;
    public GameObject IRS_panelPrefab;
    public int n_column = 10;  // x boundary
    public int n_row = 10;  // z boundary
    public float left_anchor = -5.5f; // x boundary
    public float right_anchor = 9.5f;  // x boundary
    public float bottom_anchor = 0.5f; // z boundary
    public float top_anchor = 9.5f; // z boundary
    public float x_spacing;
    public float z_spacing;
    public bool bComplete = false;
    public List<GameObject> panels = new List<GameObject>();
    private float pos_x;
    private float pos_z;
    void Awake()
    {
        GameObject irs = new GameObject("IRS");
        GameObject IRSboard = Instantiate(
            IRS_boardPrefab,
            new Vector3(2f, 5.9f, 5f),
            Quaternion.Euler(0f, 0f, 0f));
        IRSboard.name = string.Format("IRS_board");
        IRSboard.transform.parent = irs.transform;
        IRSboard.transform.localScale = new Vector3(16f, 0.1f, 10f);

        GameObject IRSpanels = new GameObject("Panels");
        IRSpanels.transform.parent = irs.transform;

        pos_x = left_anchor;
        pos_z = bottom_anchor;
        x_spacing = (right_anchor - left_anchor) / (n_column - 1);
        z_spacing = (top_anchor - bottom_anchor) / (n_row - 1);
        for (int i = 0; i < n_column; i++)
        {
            for (int j = 0; j < n_row; j++)
            {
                GameObject panel = Instantiate(
                    IRS_panelPrefab,
                    new Vector3(pos_x, 5.825f, pos_z),
                    Quaternion.Euler(0f, 0f, 0f));
                panel.transform.parent = IRSpanels.transform;
                panel.transform.localScale = new Vector3(0.5f, 0.05f, 0.5f);
                panel.name = string.Format("panel_{0}_{1}", i, j);
                panel.tag = "IRS_panel";
                panels.Add(panel);
                pos_z += z_spacing;
            }
            pos_z = bottom_anchor;
            pos_x += x_spacing;
        }
        bComplete = true;
    }
}
