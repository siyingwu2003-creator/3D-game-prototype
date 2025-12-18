using UnrealBuildTool;

public class ThreeDprototypeTarget : TargetRules
{
	public ThreeDprototypeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ThreeDprototype");
	}
}
