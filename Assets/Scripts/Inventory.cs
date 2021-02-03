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
    public bool hasAxe = false;
    public bool hasLog = false;
    public bool hasLever = false;
    public bool hasKey1 = false;
    public bool hasKey2 = false;
    public bool hasKey3 = false;
    public bool hasTorch = false;
    public bool pedastalActive = false;
    public bool boulderMoved = false;
    public bool holsterActive = false;
    public bool leverVisible = false;
    public bool roomRotated = false;
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

    }
}
