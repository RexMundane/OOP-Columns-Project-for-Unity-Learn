using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AbstractionColumn : MonoBehaviour
{
    private Text titleField;
    private Text descriptionField;

    private string columnName;
    private string columnDescription;

    // ENCAPSULATION
    public virtual int timesClicked { get; set; }

    private string abstractionName = "Abstraction";
    private string abstractionDesc = "In the AbstractionColumn class, higher-level functionality for changing the text here is defined with the SetTextFields() function, which identifies the UI text objects, and the SetNameAndDesc(string, string) function, which receives two parameters to set the string variables columnName and columnDescription. The DisplayInformation() function is called for all column icons with a simple Event Trigger, and changes the text accordingly, incorporating the class-specific counter to indicate how many times that icon has been clicked.";
    
    // POLYMORPHISM
    public virtual void DisplayInformation()
    {
        timesClicked = timesClicked + 1;
        titleField.text = columnName;
        descriptionField.text = columnDescription + "\n\nTimes Clicked: " + timesClicked;
    }

    // ABSTRACTION

    public void SetNameAndDesc(string _name, string _desc)
    {
        columnName = _name;
        columnDescription = _desc;
    }

    public void SetTextFields()
    {
        titleField = GameObject.Find("Title Text").GetComponent<Text>();
        descriptionField = GameObject.Find("Description Text").GetComponent<Text>();
    }

    private void Start()
    {
        SetNameAndDesc(abstractionName, abstractionDesc);
        SetTextFields();
    }
}
