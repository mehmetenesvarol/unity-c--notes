using UnityEngine;
using TMPro;

//https://gamedevbeginner.com/
//https://www.youtube.com/playlist?list=PLFgjYYTq6xyhtVK6VzLiFe3pmBu-XSNlX
public class Notes : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    
    //It is used to make private variables accessible in the Unity editor without making them public.
    //[SerializeField]

    public string firstName;
    public string lastName;

    public int num1 = 0;

    public bool checkBox = false;

    //const is a constant variable
    private const float  pi = 3.14f;

    //array
    public int[] integers;

    private void Awake()
    {
        //write console
        Debug.Log("Hello World!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //change text on game start menu
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName} {lastName}!";
    }

    // Update is called once per frame
    void Update()
    {        
        //input keyboard and joystick
        if (Input.GetKeyDown(KeyCode.Space))
        {
            num1++;
        }
    }

}
