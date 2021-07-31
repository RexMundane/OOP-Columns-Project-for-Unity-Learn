using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncapsulationColumn : AbstractionColumn
{
    private string encapsulationName = "Encapsulation";
    private string encapsulationDesc = "In the EncapsulationColumn class, the timesClicked variable is overridden to have a newly defined setter and getter. Now, through use of the backing field m_timesClicked, and a simple if-then statement in the setter, the value is prevented from exceeding 10. All other code is inhereted, and applied similarly as in the InheretenceColumn class.";

    // ENCAPSULATION

    private int m_timesClicked;
    public override int timesClicked { 
        get
        {
            return m_timesClicked;
        }
        set
        {
            if (value > 10)
            {
                m_timesClicked = 10;
            }
            else
            {
                m_timesClicked = value;
            }
        }
    }

    private void Start()
    {
        SetNameAndDesc(encapsulationName, encapsulationDesc);
        SetTextFields();
    }
}
