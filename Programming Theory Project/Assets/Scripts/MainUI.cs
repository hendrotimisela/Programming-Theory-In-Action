using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {
        
        DataManager.Instance.moneyText = moneyText;
        moneyText.text = DataManager.Instance.PlayerName+": "+DataManager.Instance.Money.ToSafeString()+"$";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
