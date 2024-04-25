using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{  
    public void OpenURL()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1jQrxu23I280Cuu5--M_M6Rl6zPsACvja?usp=drive_link");
        Debug.Log("is this working");
    }
}
