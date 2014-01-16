using UnityEngine;
using System.Collections;

/*
 * The name of this file starts with an underscore
 * so that it pops to the beginning of the list.
 * This is purely a cosmetic purpose, so whether we call it 
 * call it, _GameFlow, GameFlow or elephant, it won't 
 * affect how the application behaves.
 */

public class GameFlow {
    
	public static readonly IGameState gsInitializeGame 	= new GSInitializeGame();
	public static readonly IGameState gsLevelVolcano 	= new GSLevelVolcano();
	public static readonly IGameState gsMenuMain 		= new GSMenuMain();
	public static readonly IGameState gsMenuPause 		= new GSMenuPause();
	
	public static readonly IGameState gsMock = new GSMock();
        
	public static IGameState GetInitialGameState() {
		return gsInitializeGame;
	}    
}