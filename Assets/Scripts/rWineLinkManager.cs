using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class rWineLinkManager : MonoBehaviour
{
    public float beamRadius;
    public int n_rWINE;
    public Material Ray_material;
    public List<GameObject> transceivers;
    public List<GameObject> panels;

    void Start()
    {
        // while (!bSetupComplete)
        // {
        //     bool rackPlaced = GameObject.Find("Rack Placer").GetComponent<RackPlacer>().bComplete;
        //     bool irsPlaced = GameObject.Find("IRS Placer").GetComponent<IRSPlacer>().bComplete;
        //     bSetupComplete = rackPlaced && irsPlaced;
        //     Debug.Log("setup complete");
        // }

        transceivers = GameObject.Find("Rack Placer").GetComponent<RackPlacer>().transceivers;
        panels = GameObject.Find("IRS Placer").GetComponent<IRSPlacer>().panels;

        for(int n=0; n<n_rWINE; n++)
        {
            // Choose TX, RX
            int rand_idx = Random.Range(0, transceivers.Count);
            GameObject tx = transceivers[rand_idx];
            transceivers.RemoveAt(rand_idx);
            rand_idx = Random.Range(0, transceivers.Count);
            GameObject rx = transceivers[rand_idx];
            transceivers.RemoveAt(rand_idx);

            // Choose panel
            rand_idx = Random.Range(0, panels.Count);
            GameObject panel = panels[rand_idx];
            panels.RemoveAt(rand_idx);

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
            beam_panel2rx.transform.parent = this.transform;
            beam_panel2rx.name = string.Format(
                "{0}_to_{1}", panel.transform.name, rx.transform.parent.name);
            beam_panel2rx.tag = "beam";
            Rigidbody RB_panel2rx = beam_panel2rx.AddComponent<Rigidbody>();
            RB_panel2rx.isKinematic = true;
        }
        this.gameObject.GetComponent<wWineLinkManager>().onStatus = true;
    }

}
