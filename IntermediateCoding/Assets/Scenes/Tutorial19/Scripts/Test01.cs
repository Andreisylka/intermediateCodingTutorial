using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    private float speed = 6;
 
    void Update()
    {
        float direction = Input.GetAxisRaw("Vertical");
        float velocity = direction * speed;
        Vector3 movement = Vector3.up * velocity * Time.deltaTime;
        transform.Translate(movement);
        
        Ray hitCheck = new Ray(transform.position , Vector3.left);
        RaycastHit hitTo;

        if (Physics.Raycast(hitCheck , out hitTo))
        {
           Debug.DrawLine(hitCheck.origin, hitTo.point, Color.red);
           Debug.Log(hitTo.transform.name);
        }
        else
        {
            ClearLogConsole();
        }

        
        
    }
    public static void ClearLogConsole() {
        Assembly assembly = Assembly.GetAssembly (typeof(SceneView));
        Type logEntries = assembly.GetType ("UnityEditor.LogEntries");
        MethodInfo clearConsoleMethod = logEntries.GetMethod ("Clear");
        clearConsoleMethod.Invoke (new object (), null);
    }
}
