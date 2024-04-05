using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    private float m_Money = 50;
    public float Money
    {
        get { return m_Money; }
        set {
            if (value >= 0) {
                m_Money = value;
                if (moneyText) {
                    moneyText.text = m_PlayerName+": "+m_Money.ToSafeString()+"$";
                }
            }
        }
    }

    public TextMeshProUGUI moneyText;

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
