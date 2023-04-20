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
    
    void Update()
    {
        if(onStatus){
            onStatus = false;
            transceivers = this.gameObject.GetComponent<rWineLinkManager>().transceivers;
            int n = 0;
            while(n<n_wWINE)
            {
                if(transceivers.Count<=2){
                    break;
                }
                // Choose TX, RX
                int rand_idx_tx = Random.Range(0, transceivers.Count);
                GameObject tx = transceivers[rand_idx_tx];
                int rand_idx_rx = Random.Range(0, transceivers.Count);
                GameObject rx = transceivers[rand_idx_rx];
                float dist = Vector3.Distance(
                    tx.transform.position, rx.transform.position);
                if(dist > 5 || dist < 0.5){
                    continue;
                }

                if(rand_idx_tx<rand_idx_rx){
                    transceivers.RemoveAt(rand_idx_tx);
                    transceivers.RemoveAt(rand_idx_rx-1);
                }
                else{
                    transceivers.RemoveAt(rand_idx_rx);
                    transceivers.RemoveAt(rand_idx_tx-1);
                }
                n++;

                // TX to RX
                Vector3 direction = rx.transform.position - tx.transform.position;
                GameObject beam_tx2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                beam_tx2rx.transform.position = tx.transform.position + direction / 2;
                beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
                beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
                beam_tx2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
                beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
                beam_tx2rx.transform.parent = this.transform;
                beam_tx2rx.name = string.Format(
                    "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
                beam_tx2rx.tag = "beam";
                Rigidbody RB_tx2panel = beam_tx2rx.AddComponent<Rigidbody>();
                RB_tx2panel.isKinematic = true;
            }

        }
    }
}
