﻿namespace frontend;

using System;

public class Makanan
{
    private string _foodName;
    private int _calorie;
    private int _carbohydrate;
    private int _fat;
    private int _protein;
    
    public string FoodName
    {
        get { return _foodName; }
    }

    public int Calorie
    {
        get { return _calorie; }
        set { _calorie = value; }
    }

    public int Carbohydrate
    {
        get { return _carbohydrate; }
        set { _carbohydrate = value; }
    }

    public int Fat
    {
        get { return _fat; }
        set { _fat = value; }
    }

    public int Protein
    {
        get { return _protein; }
        set { _protein = value; }
    }
    public Makanan(string name)
    {
        _foodName = name;
    }
}
