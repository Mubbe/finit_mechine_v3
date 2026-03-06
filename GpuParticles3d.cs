using Godot;
using System;

public partial class GpuParticles3d : GpuParticles3D
{
	[Export] Player player;
    
    public override void _Ready()
    {
       player.DamageTaken += OnPlayerDamageTaken;
       
       Emitting = false; 
   
    }

    private void OnPlayerDamageTaken(object sender, EventArgs e)
    {
        GD.Print("Player took damage! Emitting particl");
        Restart();       
        Emitting = true; 
    }
}
