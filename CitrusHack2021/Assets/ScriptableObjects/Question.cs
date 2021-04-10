using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "Question")]

public class Question : ScriptableObject
{
    public bool typeOfQuestion;
    public string quesiton;
    public Answer[] answers;
    public Answer userAnswer;
}