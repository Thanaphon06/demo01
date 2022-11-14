using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class openCode : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI codeText;
    public GameObject opentext;
    private bool atDoor = false;
    string codeTextValue = "";
    public string safeCode;
    public GameObject codePanal;
    public GameObject gamechar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == safeCode)
        {
            codePanal.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
        if (Input.GetKey(KeyCode.E) && atDoor == true)
        {
            codePanal.SetActive(true);
            opentext.SetActive(false);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        if (Input.GetKey(KeyCode.Escape) && codePanal == true)
        {
            codePanal.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            atDoor = true;
            opentext.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        atDoor = false;
        codePanal.SetActive(false);
        opentext.SetActive(false);

        //Cursor.visible = false;
        //gamechar.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
