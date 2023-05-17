using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class cameraController : MonoBehaviour
{
    public Camera main_cam1;
    public Camera main_cam2;
    public Camera main_cam3;
    public Camera main_cam4;
    public Camera irs_cam;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            main_cam1.enabled = false;
            main_cam2.enabled = false;
            main_cam3.enabled = false;
            main_cam4.enabled = false;
            irs_cam.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            main_cam1.enabled = true;
            main_cam2.enabled = true;
            main_cam3.enabled = true;
            main_cam4.enabled = true;
            irs_cam.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            System.DateTime now = DateTime.Now;
            string filename = now.Year + now.Month + now.Day + "-" + now.Hour + now.Minute + now.Second + ".png";
            ScreenCapture.CaptureScreenshot(filename);
        }
    }
}
