using Godot;
using System;

public partial class AudioStreamPlayer3d : AudioStreamPlayer3D
{
	[Export] Player player;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        player.DamageTaken += OnPlayerDamageTaken;

    }
    private void OnPlayerDamageTaken(object sender, EventArgs e)
    {  
         Play();  

    }


}
