using Godot;
using System;

namespace EasyPool.Samples;

public partial class ToggleNormalSpawner : CheckButton
{
    [Export] private NormalSpawner _normalSpawner;

    public override void _Ready()
    {
        _normalSpawner.Toggle(ButtonPressed);
    }

    public override void _Toggled(bool toggledOn)
    {
        base._Toggled(toggledOn);

        _normalSpawner.Toggle(toggledOn);
    }
}
