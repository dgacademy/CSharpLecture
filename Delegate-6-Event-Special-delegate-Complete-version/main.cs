using System;

delegate void Event();

class LivingEntity {
  public float health = 100;
  
  public virtual void TakeDamage(float damage) {
    health -= damage;
  }
}

class Enemy : LivingEntity {
  public event Event OnDeath;
  
  public override void TakeDamage(float damage) {
    if (damage >= health) {
      OnDeath();
      health = 0;
    } else 
      base.TakeDamage(damage);
  }
  public void DrawEffect() {
    Console.WriteLine("Death effect");
  }
}

class Player : LivingEntity {
  public int XP { get; private set; } = 100;
  public override void TakeDamage(float damage) {
    if (damage >= health) {
      Console.WriteLine("Revive");
      health = 100;
    } else 
      base.TakeDamage(damage);
  }
  public void IncreaseExp() {
    XP += 50;
    Console.WriteLine("Add user's XP point: " + XP);    
  }
}


class MainClass {
  public static void Main (string[] args) {
    Enemy anEnemy = new Enemy();
    Player aPlayer = new Player();
    
    anEnemy.OnDeath += aPlayer.IncreaseExp;
    anEnemy.OnDeath += anEnemy.DrawEffect;

    Console.WriteLine(aPlayer.XP == 100);
    anEnemy.TakeDamage(120);
    Console.WriteLine(aPlayer.XP == 150);
    
    // anEnemy.OnDeath();
    
  }
}






