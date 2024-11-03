using UnityEngine;
using TMPro;

public class ButtonFunc : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public string firstName1="default1";
    public string lastName1= "default2";

    private TextMeshProUGUI textMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        SendMassage(firstName,lastName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendMassage(string firstName, string lastName)
    {
        textMeshPro.text =$"{firstName} {lastName} Clicked the Button!";
    }

    public void OnClickTheButton() 
    {
        Debug.Log("OnClickTheButton running");
        ButtonRename(firstName1, lastName1);

    }
    public void ButtonRename(string firstName1, string lastName1)
    {
        Debug.Log("ButtonRename running");
        textMeshPro.text = $"{firstName1} {lastName1} Clicked the Button!";
    }





}
