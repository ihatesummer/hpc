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

            // For figure - uniform
            GameObject tx = transceivers[10];
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
            rx = transceivers[50];
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

            tx = transceivers[41];
            rx = transceivers[54];
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

            tx = transceivers[65];
            rx = transceivers[78];
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

            tx = transceivers[90];
            rx = transceivers[62];
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
            rx = transceivers[82];
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

            tx = transceivers[38];
            rx = transceivers[43];
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

            tx = transceivers[19];
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

            tx = transceivers[83];
            rx = transceivers[77];
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
            
        }
    }
}
