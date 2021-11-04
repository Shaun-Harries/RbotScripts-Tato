using RBot;

public class Script {

	public void ScriptMain(ScriptInterface bot){
		bot.Options.SafeTimings = true;
		bot.Options.RestPackets = true;
		bot.Options.InfiniteRange = true;
		bot.Options.LagKiller = true;
		
		bot.Skills.Add( 1, 1 );
		bot.Skills.Add( 2, 1 );
		bot.Skills.Add( 3, 1 );
		bot.Skills.Add( 4, 1 );
		bot.Skills.StartTimer();
		
		
		bot.Player.Join("icestormarena-999999", "r3c", "Top");
		bot.Player.HuntForItem("frost spirit", "treasure chest", 9999, false, true);
	}
}
