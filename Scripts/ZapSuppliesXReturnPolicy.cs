//bot by Zap
using RBot;

public class Script {

		// Change Quantity below
		public int diamondQuantity = 1000;
		public int taintedQuantity = 900;
		public int darkcrystalQuantity = 300;
		public int bloodgemQuantity = 30;
		public int gemofnulQuantity = 180;

	public void ScriptMain(ScriptInterface bot){
		bot.Options.SafeTimings = true;
		bot.Options.RestPackets = true;
		bot.Options.ExitCombatBeforeQuest = true;
		bot.Options.LagKiller = true;
		bot.Options.InfiniteRange = true;
		bot.Options.AutoRelogin = true;
		bot.Options.PrivateRooms = true;
		
		bot.Events.PlayerDeath += b => {
    	bot.Sleep(7500);
    	ScriptManager.RestartScript();
		};
    	bot.Events.PlayerAFK += b => {
        ScriptManager.RestartScript();
   	 	}; 
   	 	// Change file and file location below
		bot.Skills.StartSkills("skills/generic.xml");
		
		
		string[] requiredItems = {
		"Unidentified 10",
		"Unidentified 13",
		"Tainted Gem", 
		"Dark Crystal Shard", 
		"Diamond of Nulgath", 
		"Voucher of Nulgath (non-mem)", 
		"Voucher of Nulgath", 
		"Gem of Nulgath",
		"Unidentified 1", 
		"Unidentified 6",
		"Unidentified 9", 
		"Unidentified 16",
		"Unidentified 20",
		"Blood Gem of the Archfiend",
		"Receipt of Swindle"
		};
		
		bot.Player.LoadBank();
		 foreach (var item in requiredItems) {
        bot.Bank.ToInventory(item);
    	};
	
		
			while (!bot.ShouldExit()) { 
				if (bot.Map.Name != "escherion") bot.Player.Join("Escherion", "Boss", "Left");
    			if (bot.Player.Cell != "Boss") bot.Player.Jump("Boss", "Left");
					bot.Quests.EnsureAccept(2857);
				
				if(bot.Monsters.Exists("Staff of Inversion")) bot.Player.Kill("Staff of Inversion");
					bot.Player.Attack("Escherion");
					
				if(bot.Player.DropExists("Escherion's Helm")) bot.Player.Pickup("Escherion's Helm");
					bot.Player.RejectExcept("Escherion's Helm");
			
			
			while(bot.Inventory.Contains("Escherion's Helm", 1))
			{
					bot.Player.Jump("Wait", "Left");
					bot.Sleep(500);
					bot.Quests.EnsureComplete(2857);
			foreach (var item in requiredItems) {
        			bot.Player.Pickup(item);
    		};
            		bot.Player.RejectExcept(requiredItems);
            		bot.Log("Supplies Completed.");
            	
            	if(bot.Inventory.Contains("Voucher of Nulgath")) bot.Shops.SellItem("Voucher of Nulgath");
            
            }
           		
            	if(bot.Inventory.Contains("Unidentified 1", 1)  && bot.Inventory.Contains("Unidentified 6", 1)  && bot.Inventory.Contains("Unidentified 16", 1)  && bot.Inventory.Contains("Unidentified 20", 1)  && bot.Inventory.Contains("Unidentified 9", 1))
            {
            		bot.Player.Join("evilmarsh-" + 9999999);  
            		bot.Quests.EnsureAccept(7551);
            		bot.Player.HuntForItem("Dark Makai", "Dark Makai Rune", 1, true);
            		bot.Player.Jump("blank", "wait");
            	if(bot.Quests.CanComplete(7551)){
            	if(!bot.Inventory.Contains("Diamond of Nulgath", diamondQuantity)) bot.Quests.EnsureComplete(7551, 4771, false);
				if(!bot.Inventory.Contains("Tainted Gem", taintedQuantity)) bot.Quests.EnsureComplete(7551, 4769, false);
				if(!bot.Inventory.Contains("Blood Gem of the Archfiend", bloodgemQuantity)) bot.Quests.EnsureComplete(7551, 22332, false);
				if(!bot.Inventory.Contains("Gem of Nulgath", gemofnulQuantity)) bot.Quests.EnsureComplete(7551, 6136, false);
				if(!bot.Inventory.Contains("Dark Crystal Shard", darkcrystalQuantity)) bot.Quests.EnsureComplete(7551, 4770, false);   			//4769 TGs, 6136 GemsofNulgath, 22332 BloodGems, 4770 DarkCrystalShards, 4771 DiamondsofNulgath
				}
            	foreach (var item in requiredItems) {
        		if (bot.Player.DropExists(item)) bot.Player.Pickup(item);
        		}
        		bot.Player.RejectExcept(requiredItems);		
            		bot.Log("Return Policy Completed.");
            	
        	}	
		}					
	}
}

// 	  created by;  Zap
//    tested by   🥔Tato🥔                                                         
//                              ▓▓▓▓████████████████▓▓▓▓▒▒              
 //                         ▓▓▓▓████░░░░░░░░░░░░░░░░██████▓▓            
  //                      ▓▓████░░░░░░░░░░░░░░░░░░░░░░░░░░████          
   //                   ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██        
    //                ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██      
    //              ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██      
   //             ▓▓██░░░░░░▓▓██░░  ░░░░░░░░░░░░░░░░░░░░▓▓██░░  ░░██    
   //           ▓▓██░░░░░░░░██████░░░░░░░░░░░░░░░░░░░░░░██████░░░░░░██  
    //          ▓▓██░░░░░░░░██████▓▓░░░░░░██░░░░██░░░░░░██████▓▓░░░░██  
   //         ▓▓██▒▒░░░░░░░░▓▓████▓▓░░░░░░████████░░░░░░▓▓████▓▓░░░░░░██
   //       ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░██░░░░░░░░░░░░░░░░░░░░██
   //      ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
   //       ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
   //     ░░▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
   //     ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
  //      ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
   //     ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
  //    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
   //  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
   //   ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
  //    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
  //  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
 //   ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
  //  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
  //  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
//   ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
//  ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
//    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
//    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
//    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
 //   ░░▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
  //    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░  
   //     ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    
    //      ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██      
      //    ▓▓██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██        
      //      ▓▓████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██          
      //        ▓▓▓▓████████░░░░░░░░░░░░░░░░░░░░░░░░████████░░          
      //        ░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░            
