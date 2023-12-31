﻿namespace frontend;

using System;

public class Makanan
{
    private string _foodName;

    private float _calorie;
    private float _carbohydrate;
    private float _fat;
    private float _protein;
  
    public string FoodName
    {
        get { return _foodName; }
    }

    public float Calorie
    {
        get { return _calorie; }
        set { _calorie = value; }
    }

    public float Carbohydrate
    {
        get { return _carbohydrate; }
        set { _carbohydrate = value; }
    }

    public float Fat
    {
        get { return _fat; }
        set { _fat = value; }
    }

    public float Protein
    {
        get { return _protein; }
        set { _protein = value; }
    }
    public Makanan(string name)
    {
        _foodName = name;
    }
}
