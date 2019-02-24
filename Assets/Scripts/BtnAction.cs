using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Firebase;
using Firebase.Analytics;

public class BtnAction : MonoBehaviour
{

    private void Awake()
    {
        //FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith()
    }

    public void ReportBtnClick()
    {
        Debug.Log("Report Btn click");


    }
}
