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

            // For figure - uniform
            GameObject tx = transceivers[11];
            GameObject rx = transceivers[23];
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

            tx = transceivers[13];
            rx = transceivers[5];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
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
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[21];
            rx = transceivers[32];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
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
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[31];
            rx = transceivers[49];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            // For figure - central
            tx = transceivers[64];
            rx = transceivers[75];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[66];
            rx = transceivers[75];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[84];
            rx = transceivers[75];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[96];
            rx = transceivers[75];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            // For figure - mix
            tx = transceivers[38];
            rx = transceivers[27];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[14];
            rx = transceivers[27];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[16];
            rx = transceivers[28];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            tx = transceivers[17];
            rx = transceivers[8];
            dist = Vector3.Distance(
                tx.transform.position, rx.transform.position);
            direction = rx.transform.position - tx.transform.position;
            beam_tx2rx = Instantiate(beam);
            beam_tx2rx.transform.position = rx.transform.position;
            beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 0f, 90f));
            beam_tx2rx.transform.Rotate(180f, 0f, 0f);
            beam_tx2rx.transform.localScale = new Vector3(beamRadius, beamRadius, dist);
            beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            beam_tx2rx.transform.parent = this.transform;
            beam_tx2rx.name = string.Format(
                "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            beam_tx2rx.tag = "beam";
            RB_tx2rx = beam_tx2rx.AddComponent<Rigidbody>();
            RB_tx2rx.isKinematic = true;

            // // Random connection
            // int n = 0;
            // while(n<n_wWINE)
            // {
            //     if(transceivers.Count<=2){
            //         break;
            //     }
            //     // Choose TX, RX
            //     int rand_idx_tx = Random.Range(0, transceivers.Count);
            //     GameObject tx = transceivers[rand_idx_tx];
            //     int rand_idx_rx = Random.Range(0, transceivers.Count);
            //     GameObject rx = transceivers[rand_idx_rx];
            //     float dist = Vector3.Distance(
            //         tx.transform.position, rx.transform.position);
            //     if(dist > 5 || dist < 0.5){
            //         continue;
            //     }

            //     if(rand_idx_tx<rand_idx_rx){
            //         transceivers.RemoveAt(rand_idx_tx);
            //         transceivers.RemoveAt(rand_idx_rx-1);
            //     }
            //     else{
            //         transceivers.RemoveAt(rand_idx_rx);
            //         transceivers.RemoveAt(rand_idx_tx-1);
            //     }
            //     n++;

            //     // TX to RX
            //     Vector3 direction = rx.transform.position - tx.transform.position;
            //     GameObject beam_tx2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //     beam_tx2rx.transform.position = tx.transform.position + direction / 2;
            //     beam_tx2rx.transform.rotation = Quaternion.LookRotation(direction);
            //     beam_tx2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
            //     beam_tx2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
            //     beam_tx2rx.GetComponent<MeshRenderer>().material = Ray_material;
            //     beam_tx2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
            //     beam_tx2rx.transform.parent = this.transform;
            //     beam_tx2rx.name = string.Format(
            //         "{0}_to_{1}", tx.transform.parent.name, rx.transform.parent.name);
            //     beam_tx2rx.tag = "beam";
            //     Rigidbody RB_tx2panel = beam_tx2rx.AddComponent<Rigidbody>();
            //     RB_tx2panel.isKinematic = true;
            // }
            
        }
    }
}
