using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private Button StartButton;
    [SerializeField] private GameObject NameInput;
    private TMP_InputField NameInputField;

    // Start is called before the first frame update
    void Start()
    {
        NameInputField =  NameInput.GetComponent<TMP_InputField>();
        StartButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame() {
        DataManager.Instance.PlayerName = NameInputField.text;
        SceneManager.LoadScene(1);
    }
}
