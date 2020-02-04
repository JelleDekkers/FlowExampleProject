using Utils.Core.Flow;

public class TestRule : Rule
{
    public override string DisplayName => "On ";
    public override bool IsValid => base.IsValid;

    public override void OnActivate() { }

    public override void OnDeactivate() { }
}
