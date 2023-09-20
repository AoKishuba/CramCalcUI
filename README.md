# CramCalcUI
 A lightweight CRAM Cannon calculator for Brilliant Skies' game From the Depths
 Written by Ao Kishuba. Thanks to Al on the Discord for ripping the equations

 Source: https://github.com/AoKishuba/CramCalcUI
 Discord repository containing my other tools: https://discord.gg/GJ794YxSxj

 To run:
 - Install .NET 7.0: https://dotnet.microsoft.com/en-us/download/dotnet/7.0
 - Run "CramCalc.exe"

 Parameters
 Gauge: Cannon gauge in millimetres. Note gauge can be set in firing piece UI.

 Total pellets: Total packer/pellet box connections. Shown as "Pellets" in
	firing piece UI.

 Hardener pellets: Total packer/hardener pellet box connections. Shown as part
	of the "Pellets" breakdown.

 Payload pellets: Remaining pellet slots are filled by payload pellets (Explosive,
	Frag, or EMP).

 Compactors: Total packer/pellet compactor connections. Not shown in UI; must be
	counted. For each Compactor, add the indicated "Connected packers" to this 
	value.

 Prep time: Time in seconds between firing and packing. 3-6 seconds depending on
	gauge.

 Packing time: Time in seconds spent packing (reload time minus prep time).

 Reload time: Time in seconds between shots.

 Max packed: Shell capacity in pellets. Increases with gauge and compactors.

 KD: Kinetic damage (or thump damage, if hollow point is selected).

 Impact angle: Angle in degrees at which the shell strikes the target. Higher
	angles reduce applied KD.
 
 AP: Armour Pierce rating

 Payload type dropdown: Selects the pellet type for payload pellets.

 Payload damage: Explosive, Frag, or EMP damage.

 Flash suppressor: Check to use a Flash suppression barrel. Reduces speed and 
	detection range.

 Shell speed: Speed in m/s. Affected by Flash suppressor (and by recoil, but 
	there is no reason ever to use recoil).

 Detection range: Range at which detectors will register shell, allowing 
	CIWS/LAMS engagement.

 Shell health: Shell health, with fixed AC of 20.

 Max incoming DPS: Maximum CIWS/LAMS damage per second the shell can withstand.
	Based on speed, detection range, and health.

 Fuzes: Check to include various fuzes. Note all fuzes reduce health.

 Hollow point: Check to make shell Hollow point. Hollow point shells deal 
	thump damage instead of kinetic, spreading horizontally rather than 
	penetrating into the armor. Thump reduces max damage but ignores damage 
	reduction due to impact angle.

 Target Armor Configuration: Armor layout of target craft, outermost layer at 
	top.

 KD/Thump Req'd: If Hollow point is not selected, KD required to penetrate 
	target armor configuration at current AP and impact angle.
	If Hollow point is selected, thump required to destroy the given blocks.
	Note that thump damage does not penetrate in the same way KD does, so a 
	Hollow point shell will not actually "penetrate" a given armor configuration
	the way a kinetic shell would.

 Excess KD/Thump: Shell KD - Required KD. Positive values indicate successful
	armor penetration.

 Armor layer dropdown: Use to select armor layers to add to the configuration.
	Angled blocks have "Shallow" and "Steep" orientations. "Shallow" blocks are
	orientated such that the shell will have a larger damage reduction.

 Add/Del: Add or delete bottom (innermost) armor layer.