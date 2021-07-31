using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolymorphismColumn : AbstractionColumn
{
    // POLYMORPHISM

    private int polymorph_timesClicked = 0;

    private string polymorphismName = "Polymorphism";
    private string polymorphismDesc = "In the PolymorphismColumn class, the DisplayInformation() function, which is virtual in the parent AbstractionColumn class, is overridden entirely. Due to variables in the AbstractionColumn class being private from the PolymorphismColumn class, this necessitates declaring new UI text objects in a similar manner as in the AbstractionColumn class, and likewise similarly displaying them, though they are both now contained to the same single function.";

    public override void DisplayInformation()
    {
        Text poly_titleField = GameObject.Find("Title Text").GetComponent<Text>();
        Text poly_descriptionField = GameObject.Find("Description Text").GetComponent<Text>();

        polymorph_timesClicked = polymorph_timesClicked + 1;
        poly_titleField.text = polymorphismName;
        poly_descriptionField.text = polymorphismDesc + "\n\nTimes Clicked: " + polymorph_timesClicked;
    }


}
