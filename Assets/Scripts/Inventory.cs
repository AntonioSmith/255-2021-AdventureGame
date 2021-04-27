using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private static Inventory _main;
    public static Inventory main
    {
        get { return _main; }
    }

    #region Variables
    /// <summary>
    /// Whether or not the player has the axe
    /// </summary>
    public bool hasAxe = false;

    /// <summary>
    /// Whether or not the player has the Log
    /// </summary>
    public bool hasLog = false;

    /// <summary>
    /// Whether or not the player has the Lever
    /// </summary>
    public bool hasLever = false;

    /// <summary>
    /// Whether or not the player has the first key
    /// </summary>
    public bool hasKey1 = false;

    /// <summary>
    /// Whether or not the player has the second key
    /// </summary>
    public bool hasKey2 = false;

    /// <summary>
    /// Whether or not the player has the third key
    /// </summary>
    public bool hasKey3 = false;

    /// <summary>
    /// Whether or not the player has the torch
    /// </summary>
    public bool hasTorch = false;

    /// <summary>
    /// Whether or not the player has triggered the pedastal
    /// </summary>
    public bool pedastalActive = false;

    /// <summary>
    /// Whether or not the player has moved the boulder
    /// </summary>
    public bool boulderMoved = false;

    /// <summary>
    /// Whether or not the player has triggered the holster
    /// </summary>
    public bool holsterActive = false;

    /// <summary>
    /// Whether or not the player has triggered the lever
    /// </summary>
    public bool leverVisible = false;

    /// <summary>
    /// Whether or not the player has rotated the room
    /// </summary>
    public bool roomRotated = false;

    // Variables that reference the 8 buttons in the Inventory UI
    public Button button1; 
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;

    public Text itemDescription;
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

        // Disables and hides all inventory buttons on start
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (hasAxe) // If the player has the axe...
        {
            button1.gameObject.SetActive(true); // Activate the axe button in the UI
        }

        if (hasLog) // If the player has the log...
        {
            button2.gameObject.SetActive(true); // Activate the log button in the UI
        }

        if (hasLever) // If the player has the lever...
        {
            button3.gameObject.SetActive(true); // Activate the lever button in the UI
        }
    }
}
