using System;

delegate void Event();

class Mob {
  public event Event OnDeath;
  public void TakeDamage(int damage) {
    OnDeath();
  }
}

class Player {
  public void IncreaseExp() {
    Console.WriteLine("IncreaseExp");
  }
  public void Attack(Mob mob) {
    mob.TakeDamage(120);
  }
}

class GameUI {
  public void UpdateMinimap() {
    Console.WriteLine("UpdateMinimap");
  }
}

class MainClass {
  
  public static void Main (string[] args) {
    Mob mob = new Mob();
    Player player = new Player();
    GameUI ui = new GameUI();
    
    mob.OnDeath += player.IncreaseExp;
    mob.OnDeath += ui.UpdateMinimap;

    player.Attack(mob);
    
    // mob.OnDeath();  // Error !!!
  }
  
}



