using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class rWineLinkManager2 : MonoBehaviour
{
    public float beamRadius;
    public int n_rWINE;
    public Material Ray_material;
    public List<GameObject> transceivers;
    public List<GameObject> panels;
    private GameObject transceiver;

    void Start()
    {
        GameObject racks2 = GameObject.Find("Racks_2");
        foreach(Transform child in racks2.transform)
        {
            if(child.name[0]=='r'){
                Debug.Log(child.name);
                transceiver = child.Find("Transceiver").gameObject;
                transceivers.Add(transceiver);
            }
        }

        GameObject irs2 = GameObject.Find("IRS_2/Panels");
        foreach(Transform child in irs2.transform)
        {
            panels.Add(child.gameObject);
        }

        GameObject tx = transceivers[11];
        GameObject panel = panels[4];
        GameObject rx = transceivers[7];
        // TX to panel
        float dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        Vector3 direction = panel.transform.position - tx.transform.position;
        GameObject beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
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
        GameObject beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        Rigidbody RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;

        tx = transceivers[33];
        panel = panels[43];
        rx = transceivers[61];
        // TX to panel
        dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        direction = panel.transform.position - tx.transform.position;
        beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;
        beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;

        // For figure - central
        tx = transceivers[80];
        panel = panels[81];
        rx = transceivers[75];
        // TX to panel
        dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        direction = panel.transform.position - tx.transform.position;
        beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;
        beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;

        tx = transceivers[55];
        panel = panels[67];
        rx = transceivers[99];
        // TX to panel
        dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        direction = panel.transform.position - tx.transform.position;
        beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;
        beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;

        tx = transceivers[25];
        panel = panels[16];
        rx = transceivers[9];
        // TX to panel
        dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        direction = panel.transform.position - tx.transform.position;
        beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;
        beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;

        tx = transceivers[36];
        panel = panels[36];
        rx = transceivers[45];
        // TX to panel
        dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        direction = panel.transform.position - tx.transform.position;
        beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;
        beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;

        tx = transceivers[85];
        panel = panels[73];
        rx = transceivers[53];
        // TX to panel
        dist = Vector3.Distance(
            tx.transform.position, panel.transform.position);
        direction = panel.transform.position - tx.transform.position;
        beam_tx2panel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_tx2panel.transform.position = tx.transform.position + direction / 2;
        beam_tx2panel.transform.rotation = Quaternion.LookRotation(direction);
        beam_tx2panel.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_tx2panel.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_tx2panel.GetComponent<MeshRenderer>().material = Ray_material;
        beam_tx2panel.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_tx2panel.transform.parent = this.transform;
        beam_tx2panel.name = string.Format(
            "{0}_to_{1}", tx.transform.parent.name, panel.transform.name);
        beam_tx2panel.tag = "beam";
        RB_tx2panel = beam_tx2panel.AddComponent<Rigidbody>();
        RB_tx2panel.isKinematic = true;
        // panel to RX
        dist = Vector3.Distance(panel.transform.position, rx.transform.position);
        direction = rx.transform.position - panel.transform.position;
        beam_panel2rx = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        beam_panel2rx.transform.position = panel.transform.position + direction / 2;
        beam_panel2rx.transform.rotation = Quaternion.LookRotation(direction);
        beam_panel2rx.transform.rotation *= Quaternion.LookRotation(new Vector3(0f, 90f, 0f));
        beam_panel2rx.transform.localScale = new Vector3(beamRadius, dist / 2, beamRadius);
        beam_panel2rx.GetComponent<MeshRenderer>().material = Ray_material;
        beam_panel2rx.GetComponent<MeshRenderer>().shadowCastingMode = 0;
        beam_panel2rx.transform.parent = this.transform;
        beam_panel2rx.name = string.Format(
            "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
        beam_panel2rx.tag = "beam";
        RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
        RB_panel2rx.isKinematic = true;
    
        this.gameObject.GetComponent<wWineLinkManager2>().onStatus = true;
    }

}
