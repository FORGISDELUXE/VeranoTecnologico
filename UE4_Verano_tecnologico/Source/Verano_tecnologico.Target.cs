// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Verano_tecnologicoTarget : TargetRules
{
	public Verano_tecnologicoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Verano_tecnologico" } );
	}
}
