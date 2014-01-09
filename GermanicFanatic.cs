﻿using UnityEngine;
using System.Collections;

public class GermanicFanatic : Unit, FiniteStateMachine
{
	void Start ()
	{
		this.playerManaged = GameManager.i.germanicsByPlayer;
		this.side = Side.Germanic;
		BaseStart ();
		statesSupported.Add (StateChase);
		maxMovement = 3.0F;				
	}
 
	void Update ()
	{
		UnitUpdate ();				
	}


	public override int ComputeAttackForceAgainst (Unit unit)
	{
		return 2;
	}
	
	public override int ComputeDefenceForceAgainst (Unit unit)
	{
		return 0;
	}


}
