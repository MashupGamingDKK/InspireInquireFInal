using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Prompting : MonoBehaviour
{
    public string[] Roles;
    public string[] Tasks;
    public string[] Formats;
    [SerializeField] private string Role;
    [SerializeField] private string Task;
    [SerializeField] private string Format;
    [SerializeField] private string promptText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Role = Roles[GameObject.Find("GameManager").GetComponent<promptDetail>().roles];
        Task = Tasks[GameObject.Find("GameManager").GetComponent<promptDetail>().tasks];
        Format = Formats[GameObject.Find("GameManager").GetComponent<promptDetail>().formats];
    }

    public void Prompt()
    {

        promptText = "As a " + Role + ", you want to " + Task + ", in a format of a " + Format + ".";
        StartCoroutine(TypeWriter(promptText));
        if (!GameObject.Find("GameManager").GetComponent<promptDetail>().match)
        {
            this.GetComponent<TextMeshProUGUI>().color = UnityEngine.Color.red;
        }
        else
        {
            this.GetComponent<TextMeshProUGUI>().color = new Color32(0,160,10,255);
        }
        


    }
    IEnumerator TypeWriter(string fullText)
    {


        float delay = 0.02f;
        string currentText = "";
        for (int i = 0; i - 1 < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<TextMeshProUGUI>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        yield return new WaitForSeconds(0.3f);
        
    }
}
