// Converted from gold and bamboozle update
// Author: Author
// Description: Description (Write in RTF)

using System;
using System.Collections.Generic;
using RBot;
using RBot.Options;
public class Script
{


    public void ScriptMain(ScriptInterface bot)
    {
        bot.Options.SafeTimings = true;
        bot.Options.RestPackets = true;
        bot.Options.ExitCombatBeforeQuest = true;
        bot.Options.InfiniteRange = true;
        bot.Options.PrivateRooms = true;
        
       	bot.Skills.LoadSkills("Skills/generic.xml");
		bot.Skills.StartSkills("Skills/generic.xml");
		
        
        bot.Player.LoadBank();
        bot.Bank.ToInventory("Escherion's Helm");
        bot.Bank.ToInventory("Tainted Core");
        bot.Bank.ToInventory("Unidentified 13");
        bot.Bank.ToInventory("Voucher of Nulgath");
        bot.Bank.ToInventory("Voucher of Nulgath (non-mem)");
        bot.Bank.ToInventory("Dark Crystal Shard");
        bot.Bank.ToInventory("Diamond of Nulgath");
        bot.Bank.ToInventory("Gem of Nulgath");
        bot.Bank.ToInventory("Tainted Gem");
        bot.Bank.ToInventory("Totem of Nulgath");
        bot.Bank.ToInventory("Tainted Soul");
        bot.Bank.ToInventory("Cursed Bone Axe");
        bot.Bank.ToInventory("Cursed Dread Face Mace");
        
        bot.Drops.Add("Tainted Core");
        bot.Drops.Add("Cursed Bone Axe");
        bot.Drops.Add("Cursed Dread Face Mace");
        bot.Drops.Add("Tainted Soul");
        bot.Drops.Enabled = true;
        
	bot.Quests.EnsureAccept(609);
	bot.Quests.EnsureAccept(2857);

while(!bot.ShouldExit()){
        if (String.Equals(bot.Map.Name,"tercessuinotlim") == false) 
        {
            bot.Player.Join("citadel", "m22", "Right", false);
            bot.Player.Join("tercessuinotlim", "m10C", "Top", false);
        }
 		
 		bot.Player.Jump("m10C", "Top", false);
 		bot.Quests.EnsureAccept(609);
        bot.Player.HuntForItem("Tainted Elemental", "Tainted Core", 13, false, true);
        
        if (bot.Inventory.Contains("Tainted Core", 13)) 
            bot.Player.Jump("Enter", "Spawn", false);
	
	while(bot.Inventory.GetQuantity("Tainted core") > 0) {
	
		bot.Sleep(1000);
	
	    bot.Quests.EnsureAccept(609);
	    bot.Quests.EnsureComplete(609);
	    bot.Player.Pickup("Escherion's Helm");
	    
	    bot.Sleep(1000);
	    
	    bot.Quests.EnsureAccept(2857);
	    bot.Quests.EnsureComplete(2857);
	    bot.Player.Pickup("Unidentified 13", "Voucher of Nulgath", "Voucher of Nulgath (non-mem)", "Dark Crystal Shard", "Diamond of Nulgath", "Gem of Nulgath", "Tainted Gem", "Totem of Nulgath");
	    
	    bot.Sleep(1000);
	    
	    bot.Shops.SellItem("Tainted Soul");
        bot.Shops.SellItem("Voucher of Nulgath");
        bot.Shops.SellItem("Cursed Bone Axe");
        bot.Shops.SellItem("Cursed Dread Face Mace");
	}
	
  }  
 }
}
//    tested by   🥔tato🥔                            
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