using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritenceColumn : AbstractionColumn
{
    // INHERETANCE
    
    private string inheritenceName = "Inheritence";
    private string inheritenceDesc = "In the InheritenceColumn class, all higher-level functionality is directly inhereted from the AbstractionColumn class. Two additional strings are declared containing this definition text, which are, at Start(), used in the inhereted SetNameAndDesc() to define the columnName and columnDescription, which are used in the DisplayInformation() function in an otherwise-identical manner.";
        
    private void Start()
    {
        SetNameAndDesc(inheritenceName, inheritenceDesc);
        SetTextFields();
    }
}
