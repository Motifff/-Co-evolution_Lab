using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RenderOnlySkeleton : MonoBehaviour
{
    public Transform rootBone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void DrawBone(Transform t)
    {
        foreach ( Transform child in t)
        {
            float len = 0.05f;
            Vector3 loxalX = new Vector3(len,0,0);
            Vector3 loxalY = new Vector3(0,len,0);
            Vector3 loxalZ = new Vector3(0,0,len);

            var ro = child.rotation;
            var po = child.position;
            loxalX = ro * loxalX;
            loxalY = ro * loxalY;
            loxalZ = ro * loxalZ;
           
            Debug.DrawLine(t.position * 0.1f + po * 0.9f,  t.position * 0.9f + po * 0.1f, Color.white);
           
            Debug.DrawLine(po,  po+loxalX, Color.white);
            Debug.DrawLine(po,  po+loxalY, Color.white);
            Debug.DrawLine(po,  po+loxalZ, Color.white);
            DrawBone(child);
        }
    }
    // Update is called once per frame
    void Update()
    {
        DrawBone(rootBone);
    }
}
