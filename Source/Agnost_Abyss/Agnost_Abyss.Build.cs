// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Agnost_Abyss : ModuleRules
{
	public Agnost_Abyss(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Agnost_Abyss",
			"Agnost_Abyss/Variant_Horror",
			"Agnost_Abyss/Variant_Horror/UI",
			"Agnost_Abyss/Variant_Shooter",
			"Agnost_Abyss/Variant_Shooter/AI",
			"Agnost_Abyss/Variant_Shooter/UI",
			"Agnost_Abyss/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
