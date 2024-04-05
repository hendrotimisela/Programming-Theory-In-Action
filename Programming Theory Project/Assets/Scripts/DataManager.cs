using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // ENCAPSULATION
    public static DataManager Instance {get; private set;}

    private string m_PlayerName;
    public string PlayerName
    {
        get { return m_PlayerName; }
        set {
            if (value != null) {
                m_PlayerName = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    class SaveData {
        public string PlayerName;
    }
}
