using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName="Sword")]
public class Sword : ScriptableObject
{
   public string name;
   public int price;
   public Sprite artwork;
   public string level;
   public string plote;
   public int attack;
   public int def;
   public int speed;
   public int knowladge;
   public int power;
}
