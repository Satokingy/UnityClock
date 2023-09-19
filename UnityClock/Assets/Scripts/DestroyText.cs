using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
public GameObject targetObj;

    void Start()
    {
        //GameObjectを破棄します。
        Destroy(targetObj);
    }
}
