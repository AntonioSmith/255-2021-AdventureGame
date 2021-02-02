using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory _main;
    public static Inventory instance;
    public static Inventory main
    {
        get { return _main; }
    }

    #region Variables
    public bool hasVine1 = false;
    public bool hasVine2 = false;
    public bool hasLog = false;
    public bool hasGear = false;
    public bool hasKey1 = false;
    public bool hasKey2 = false;
    public bool hasKey3 = false;
    public bool hasTorch = false;
    #endregion

    private void Start()
    {
        if (_main == null)
        {
            _main = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (hasTorch == true)
        {
            print("ladies and gentlemen.......we got 'em");
        }
    }
}
