using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject defenderPrefab;
    public static GameObject selectedDefender;

    private button[] buttonarray;
    private Text costText;
    // Start is called before the first frame update
    void Start()
    {
        buttonarray = GameObject.FindObjectsOfType<button>();

        costText = GetComponentInChildren<Text>();
        if(!(costText))
        {
            Debug.LogWarning(name + " has no cost text!");
        }
        costText.text = defenderPrefab.GetComponent<Defenders>().starCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log(name + " is selected !");
        foreach(button thisbutton in buttonarray)
        {
            thisbutton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.green;
        selectedDefender = defenderPrefab;
        print(selectedDefender + " is selected");
    }
}
