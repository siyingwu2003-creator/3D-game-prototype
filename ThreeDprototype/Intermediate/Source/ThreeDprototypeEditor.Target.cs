using UnrealBuildTool;

public class ThreeDprototypeEditorTarget : TargetRules
{
	public ThreeDprototypeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ThreeDprototype");
	}
}
