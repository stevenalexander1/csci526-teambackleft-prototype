using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CorrectAnswer:MonoBehaviour
{
    // Player's Atrributes
    Shape testShapeObject;
    Pattern testPatternObject;
    ColorObject testColorObject;

    // Correct Answer attributes
    Shape.ShapeType answer_shape;
    Pattern.PatternType answer_pattern;
    ColorObject.ColorType answer_color;

    public CorrectAnswer(Shape shape_object, Pattern pattern_object, ColorObject color_object)
    {
        this.testShapeObject= shape_object;
        this.testPatternObject =pattern_object;
        this.testColorObject =color_object;

    }
    
 
    // Start is called before the first frame update
    void Start()
    {
        answer_shape = generateRandomShape();
        answer_pattern = generateRandomPattern();
        answer_color = generateRandomColor();

        Debug.Log("Answer Shape is : " + answer_shape);
        Debug.Log("Answer Pattern is : " + answer_pattern);
        Debug.Log("Answer Color is : " + answer_color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Shape.ShapeType generateRandomShape()
    {
        Shape.ShapeType[] enumValues = (Shape.ShapeType[])Enum.GetValues(typeof(Shape.ShapeType));
        System.Random random = new System.Random();
        int randomIndex = random.Next(0, enumValues.Length);
        return enumValues[randomIndex];

    }

    Pattern.PatternType generateRandomPattern()
    {
      Pattern.PatternType[] enumValues = (Pattern.PatternType[])Enum.GetValues(typeof(Pattern.PatternType));
      System.Random random = new System.Random();
      int randomIndex = random.Next(0, enumValues.Length);
      return enumValues[randomIndex];

    }

    ColorObject.ColorType generateRandomColor()
    {
        ColorObject.ColorType[] enumValues = (ColorObject.ColorType[])Enum.GetValues(typeof(ColorObject.ColorType));
        System.Random random = new System.Random();
        int randomIndex = random.Next(0, enumValues.Length);
        return enumValues[randomIndex];
    }


    void validation()
    {
        // compare correct answer attributes and player's  attributes
        // code for opening the doors accordingly here.
    }




}
