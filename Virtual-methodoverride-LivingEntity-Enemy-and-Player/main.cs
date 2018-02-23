using System;

class LivingEntity {
  public float health = 100;
  
  public virtual void TakeDamage(float damage) {
    health -= damage;
    Console.WriteLine("HP: " + health);
  }
}

class Enemy : LivingEntity {
  public override void TakeDamage(float damage) {
    if (damage >= health) {
      Console.WriteLine("Add user's xp point");
      Console.WriteLine("Death effect");
      health = 0;
    } else 
      base.TakeDamage(damage);
  }
}

class Player : LivingEntity {
  public override void TakeDamage(float damage) {
    if (damage >= health) {
      Console.WriteLine("Revive");
      health = 100;
    } else 
      base.TakeDamage(damage);
  }  
}

class MainClass {
  public static void Main (string[] args) {
    Enemy anEnemy = new Enemy();
    Player aPlayer = new Player();
    
    anEnemy.TakeDamage(10);
    Console.WriteLine(anEnemy.health == 90);
    aPlayer.TakeDamage(100);
    Console.WriteLine(aPlayer.health == 100);
    
    LivingEntity[] le = new LivingEntity[2];
    le[0] = new Enemy();
    le[1] = new Player();
    
    foreach(LivingEntity anEntity in le) {
      anEntity.TakeDamage(20);
    }
    Console.WriteLine(le[0].health == 80);
    Console.WriteLine(le[1].health == 80);
    
    le[0].TakeDamage(100);
  }
}






