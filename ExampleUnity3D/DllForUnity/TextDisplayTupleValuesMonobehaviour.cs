using System;
using UnityEngine;
using UnityEngine.UI;

namespace HD
{
  public class TextDisplayTupleValuesMonobehaviour : MonoBehaviour
  {
    protected void Awake()
    {
      (string name, int age, string language, double score) = GetExampleTuple();

      Text text = GetComponent<Text>();
      text.text = $@"
Item1: {name}
Item2: {age}
Item3: {language}
Item4: {score}";
    }

    (string name, int age, string language, double score) GetExampleTuple()
    {
      return ("Bob", 83, "English", 191.001);
    }
  }
}
