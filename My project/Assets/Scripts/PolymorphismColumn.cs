using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismColumn : AbstractionColumn
{
    public override void DisplayInformation()
    {
        TimesClicked = TimesClicked + 1;
        TitleField.text = "Polymorphism";
        DescriptionField.text = "Polymorphism Description" + TimesClicked;
    }


}
