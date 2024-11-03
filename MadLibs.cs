using UnityEngine;
using TMPro;
//example link
//https://www.youtube.com/watch?v=d-KpW2YYLf4&list=PLFgjYYTq6xyhtVK6VzLiFe3pmBu-XSNlX&index=5
public class MadLibs : MonoBehaviour
{

    public bool statement = true;
    public string verb = "steal";
    public string noun = "earrings";
    public string adjective = "relable";
    public int number = 2;
    public string pluralNoun = "thieves";
    public float percent = 99.9f;

    private TextMeshProUGUI textMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The is statement is {statement}. I did not {verb} the {noun}. I am not guily. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
