using UnrealBuildTool;

public class CheckLatencyTarget : TargetRules
{
	public CheckLatencyTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CheckLatency");
	}
}
