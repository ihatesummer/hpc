using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class rWineLinkManager3 : MonoBehaviour
{
    public float beamRadius;
    public int n_rWINE;
    public Material Ray_material;
    public List<GameObject> transceivers;
    public List<GameObject> panels;
    private GameObject transceiver;
    public GameObject beam;

    void Start()
    {
        GameObject racks2 = GameObject.Find("Racks_3");
        foreach(Transform child in racks2.transform)
        {
            if(child.name[0]=='r'){
                transceiver = child.Find("Transceiver").gameObject;
                transceivers.Add(transceiver);
            }
        }

        GameObject irs3 = GameObject.Find("IRS_3/Panels");
        foreach(Transform child in irs3.transform)
        {
            panels.Add(child.gameObject);
        }

        // Hardcoding for figure
        rWINE_manual(90, 90, 82);
        rWINE_manual(11, 4, 7);
        rWINE_manual(33, 43, 61);
        rWINE_manual(80, 81, 75);
        rWINE_manual(55, 67, 99);
        rWINE_manual(25, 16, 9);
        rWINE_manual(36, 36, 45);
        rWINE_manual(85, 73, 53);
        rWINE_manual(92, 93, 76);
        rWINE_manual(70, 60, 42);
        rWINE_manual(40, 52, 55);
        rWINE_manual(20, 21, 23);
        rWINE_manual(31, 1, 3);
        rWINE_manual(73, 84, 95);
        rWINE_manual(96, 87, 67);
        rWINE_manual(58, 78, 78);
        rWINE_manual(83, 95, 97);
        rWINE_manual(47, 48, 39);
        rWINE_manual(44, 46, 27);

        // // Random connection
        // for(int n=0; n<n_rWINE; n++)
        // {
        //     int tx_idx = Random.Range(0, transceivers.Count);
        //     int rand_int = Random.Range(0, transceivers.Count);
        //     while(rand_int == tx_idx){
        //         rand_int = Random.Range(0, transceivers.Count);
        //     }
        //     int rx_idx = rand_int;
        //     int panel_idx = Random.Range(0, panels.Count);
            
        //     rWINE_manual(tx_idx, panel_idx, rx_idx);

        //     if(tx_idx<rx_idx){
        //         transceivers.RemoveAt(tx_idx);
        //         transceivers.RemoveAt(rx_idx-1);
        //     }
        //     else{
        //         transceivers.RemoveAt(rx_idx);
        //         transceivers.RemoveAt(tx_idx-1);
        //     }
        //     panels.RemoveAt(panel_idx);
        // }
    
    }

    void rWINE_manual(int tx_no, int panel_no, int rx_no){
        GameObject tx = transceivers[tx_no];
        GameObject panel = panels[panel_no];
        GameObject rx = transceivers[rx_no];
        // TX to panel
        float dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        Vector3 direction = panel.transform.position - tx.transform.position;
        GameObject beam_tx2panel = Instantiate(beam);
        beam_tx2panel.transform.position = tx.transform.position + direction;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
        beam_tx2panel.transform.Rotate(180f, 0f, 0f);
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        Rigidbody RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;

        GameObject beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);

        // GameObject beam_panel2rx = Instantiate(beam);
        // beam_panel2rx.transform.position = rx.transform.position;
        // beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        // beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
        // beam_panel2rx.transform.Rotate(180f, 0f, 0f);
        // beam_panel2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);

        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        Rigidbody RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;
    }

}
