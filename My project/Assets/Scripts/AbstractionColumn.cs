using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AbstractionColumn : MonoBehaviour
{
    public Text TitleField { get; private set; }
    public Text DescriptionField { get; private set; }
    public string ColumnName = "Abstraction";
    public string ColumnDescription = "Abstraction Description";
    public int TimesClicked = 0;

    public virtual void DisplayInformation()
    {
        TimesClicked = TimesClicked + 1;
        TitleField.text = ColumnName;
        DescriptionField.text = ColumnDescription + TimesClicked;
    }

    public void SetTextFields()
    {
        TitleField = GameObject.Find("Title Text").GetComponent<Text>();
        DescriptionField = GameObject.Find("Description Text").GetComponent<Text>();
    }

    private void Start()
    {
        SetTextFields();
    }
}
