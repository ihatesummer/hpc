using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wWineLinkManager2 : MonoBehaviour
{
    public bool onStatus = false;
    public float beamRadius;
    public int n_wWINE;
    public Material Ray_material;
    public List<GameObject> transceivers;
    public GameObject beam;
    
    void Update()
    {
        if(onStatus){
            onStatus = false;
            transceivers = this.gameObject.GetComponent<rWineLinkManager2>().transceivers;
            // Hardcoding for figure
            wWINE_manual(10, 23);
            wWINE_manual(13, 5);
            wWINE_manual(21, 32);
            wWINE_manual(31, 50);
            wWINE_manual(41, 54);
            wWINE_manual(65, 78);
            wWINE_manual(90, 62);
            wWINE_manual(96, 82);
            wWINE_manual(38, 43);
            wWINE_manual(14, 27);
            wWINE_manual(19, 28);
            wWINE_manual(17, 8);
            wWINE_manual(83, 77);
        }
    }
    void wWINE_manual(int tx_no, int rx_no){
        GameObject tx = transceivers[tx_no];
        GameObject rx = transceivers[rx_no];
        float dist = Vector3.Distance(
            tx.transform.position, rx.transform.position);
        Vector3 direction = rx.transform.position - tx.transform.position;
        GameObject beam_tx2rx = Instantiate(beam);
        beam_tx2rx.transform.position = rx.transform.position;
        beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
        beam_tx2rx.transform.Rotate(180f, 0f, 0f);
        beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
        beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2rx.transform.parent = this.transform;
        beam_tx2rx.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
        beam_tx2rx.tag = "beam";
        Rigidbody RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
        RB_tx2rx.isKinematic = true;
    }
}
