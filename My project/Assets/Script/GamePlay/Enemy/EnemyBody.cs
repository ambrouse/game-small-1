using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class EnemyBody
{
    public Transform transformEnemy { get; set; } //Tranform của quái.
    public float dameEnemy { get; set; } //Dame của quái.
    public float hpEnemy { get; set; } //Dame của quái.
    public Image barHpImage { get; set; } //Image bar của thanh Hp.
    public Image barHpImageBackgroundRed { get; set; } //Image background bar của thanh Hp.
    public Image barHpImageBackgroundGreen { get; set; } //Image background bar của thanh Hp.
}
