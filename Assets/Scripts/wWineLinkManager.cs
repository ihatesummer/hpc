using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wWineLinkManager : MonoBehaviour
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
            transceivers = this.gameObject.GetComponent<rWineLinkManager>().transceivers;

            // Hardcoding for figure
            // Dispersed
            wWINE_manual(11, 23);
            wWINE_manual(13, 5);
            wWINE_manual(21, 32);
            wWINE_manual(31, 49);
            // Mixed
            wWINE_manual(38, 27);
            wWINE_manual(14, 27);
            wWINE_manual(16, 28);
            wWINE_manual(17, 8);

            // Cohesive
            wWINE_manual(64, 75);
            wWINE_manual(66, 75);
            wWINE_manual(84, 75);
            wWINE_manual(96, 75);

            // // Random connection
            // int n = 0;
            // while(n<n_wWINE)
            // {
            //     if(transceivers.Count<=2){
            //         break;
            //     }
            //     int rand_idx_tx = Random.Range(0, transceivers.Count);
            //     GameObject tx = transceivers[rand_idx_tx];
            //     int rand_idx_rx = Random.Range(0, transceivers.Count);
            //     GameObject rx = transceivers[rand_idx_rx];
            //     float dist = Vector3.Distance(
            //         tx.transform.position, rx.transform.position);
            //     if(dist > 5 || dist < 0.5){
            //         continue;
            //     }

            //     wWINE_manual(rand_idx_tx, rand_idx_rx);

            //     if(rand_idx_tx<rand_idx_rx){
            //         transceivers.RemoveAt(rand_idx_tx);
            //         transceivers.RemoveAt(rand_idx_rx-1);
            //     }
            //     else{
            //         transceivers.RemoveAt(rand_idx_rx);
            //         transceivers.RemoveAt(rand_idx_tx-1);
            //     }
            //     n++;
            // }
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
