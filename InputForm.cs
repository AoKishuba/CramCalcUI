namespace CramCalcUI
{
    public enum PayloadType : int
    {
        Explosive,
        Frag,
        EMP,
        Incendiary
    }
    public partial class InputForm : Form
    {
        // Constants
        const float BoxCapacityFactor = 0.05f;
        const float HealthPerPayload = 3.6f;
        const float HardenerHealthPerPayload = 12f;
        const float KineticPerPayload = 5f;
        const float HardenerKineticPerPayload = 16f;
        const float ShellPowerPerPayload = 0.22f;

        float GaugeInM;
        float HardPerSec;
        float PayloadPerSec;
        float TotalPerSec;
        float PrepTime;
        float MaxCapacity;
        float MaxPackingTime;
        float ReloadTime;
        float HealthMultiplier;
        float DetectionRange;
        float ShellSpeed;
        float ShellHealth;
        float ImpactAngle;
        float RawKD;
        float AP;
        Scheme TargetArmorScheme;
        public InputForm()
        {
            InitializeComponent();

            PayloadTypeDD.DataSource = PayloadTypeItem.pTypeItemArr;
            PayloadTypeDD.DisplayMember = "ID";

            foreach (Layer armorLayer in Layer.AllLayers)
            {
                TargetArmorLayerDD.Items.Add(new ArmorLayerItem
                {
                    Name = armorLayer.Name,
                    ID = armorLayer
                });
            }
            TargetArmorLayerDD.DisplayMember = "Name";
            TargetArmorLayerDD.SelectedIndex = 0;

            TargetArmorLB.DisplayMember = "Name";

            UpdateGaugeInM();
            UpdatePelletCounts();
            UpdateReloadTime();
            UpdateFuzeCount();
            UpdatedShellSpeed();
            UpdateDetectionRange();
            UpdateShellHealth();
            UpdateMaxIncomingDps();
            UpdateAngleMultiplier();
            UpdateDamage();
            UpdatePen();
        }
        private void UpdateGaugeInM()
        {
            GaugeInM = (float)GaugeUD.Value / 1000f;
        }
        private void UpdatePelletCounts()
        {
            TotalPerSecUD.Value = Math.Max(TotalPerSecUD.Value, HardPerSecUD.Value);
            TotalPerSec = (float)TotalPerSecUD.Value;

            HardPerSec = (float)HardPerSecUD.Value;
            PayloadPerSec = TotalPerSec - HardPerSec;
            PayloadPerSecLabel.Text = "Payload pellets: " + PayloadPerSec.ToString("F0");
            UpdateReloadTime();
        }
        private void UpdateReloadTime()
        {
            float baseCapacity = 250 + 750 * (GaugeInM - 1f);
            MaxCapacity = baseCapacity * (1f + BoxCapacityFactor * (float)CompactorUD.Value);
            MaxCapacityLabel.Text = "Max packed: " + MaxCapacity.ToString("F0");

            PrepTime = 3f + 3f * (GaugeInM - 1f);
            PrepTimeLabel.Text = "Prep time (s): " + PrepTime.ToString("F2");

            MaxPackingTime = MaxCapacity / TotalPerSec;
            PackingTimeLabel.Text = "Packing time (s): " + MaxPackingTime.ToString("F2");

            ReloadTime = PrepTime + MaxPackingTime;
            ReloadTimeLabel.Text = "Reload time (s): " + ReloadTime.ToString("F2");

            UpdateShellHealth();
            UpdateDamage();
        }
        private void UpdateFuzeCount()
        {
            int fuzeCount = 0;

            if (LowAltFuzeCB.Checked)
            {
                fuzeCount++;
            }
            if (HighAltFuzeCB.Checked)
            {
                fuzeCount++;
            }
            if (TimeFromLaunchFuzeCB.Checked)
            {
                fuzeCount++;
            }
            if (InertialFuzeCB.Checked)
            {
                fuzeCount++;
            }
            if (PendepthFuzeCB.Checked)
            {
                fuzeCount++;
            }
            if (TimeFromImpactFuze.Checked)
            {
                fuzeCount++;
            }

            HealthMultiplier = 1f - 0.1f * fuzeCount;
            if (fuzeCount == 1)
            {
                FuzeCountLabel.Text = fuzeCount + " fuze: " + HealthMultiplier.ToString("P0") + " shell health";
            }
            else
            {
                FuzeCountLabel.Text = fuzeCount + " fuzes: " + HealthMultiplier.ToString("P0") + " shell health";
            }

            UpdateShellHealth();
        }

        private void UpdateDetectionRange()
        {
            DetectionRange = SuppressorBarrelCB.Checked ? 148 * GaugeInM : 396 * GaugeInM;
            DetectionRangeLabel.Text = "Detection range (m): " + DetectionRange.ToString("F0");
            UpdateMaxIncomingDps();
        }

        private void UpdatedShellSpeed()
        {
            ShellSpeed = SuppressorBarrelCB.Checked ? 240 : 300;
            ShellSpeedLabel.Text = "Shell speed (m/s): " + ShellSpeed.ToString("F0");
            UpdateMaxIncomingDps();
        }

        private void UpdateShellHealth()
        {
            ShellHealth = MaxPackingTime * (PayloadPerSec * HealthPerPayload + HardPerSec * HardenerHealthPerPayload) * HealthMultiplier;
            ShellHealthLabel.Text = "Shell health (20 AC): " + ShellHealth.ToString("F0");
            UpdateMaxIncomingDps();
        }
        private void UpdateMaxIncomingDps()
        {
            float maxIncomingDps = ShellHealth * ShellSpeed / DetectionRange;
            MaxDpsLabel.Text = "Max incoming DPS: " + maxIncomingDps.ToString("F0");
        }

        private void UpdateAngleMultiplier()
        {
            ImpactAngle = (float)ImpactAngleUD.Value;
            UpdateDamage();
        }

        private void UpdateDamage()
        {
            float impactReductionFactor = HollowPointCB.Checked ? 1f / MathF.Sqrt(1.6f) : 1f;
            RawKD = impactReductionFactor
                * MaxPackingTime
                * (KineticPerPayload * PayloadPerSec + HardenerKineticPerPayload * HardPerSec);
            if (HollowPointCB.Checked)
            {
                RawKDLabel.Text = "Thump: " + RawKD.ToString("F0");
            }
            else
            {
                RawKDLabel.Text = "KD: " + RawKD.ToString("F0");
            }
            AP = HardPerSec == 0 ? 0.1f : impactReductionFactor * 40 * HardPerSec / TotalPerSec;
            APLabel.Text = "AP: " + AP.ToString("F1");
            if (((PayloadTypeItem)PayloadTypeDD.SelectedValue).ID == PayloadType.Explosive)
            {
                float explosiveDamage = 3000 * MathF.Pow(ShellPowerPerPayload * PayloadPerSec * MaxPackingTime * 120f / 3000f, 0.9f);
                PayloadDamageLabel.Text = "Explosive damage: " + explosiveDamage.ToString("F0");
                float explosionRadius = MathF.Pow(explosiveDamage, 0.3f);
                PayloadSecondaryLabel.Visible = true;
                PayloadSecondaryLabel.Text = "Explosion radius (m): " + explosionRadius.ToString("F1");
            }
            else if (((PayloadTypeItem)PayloadTypeDD.SelectedValue).ID == PayloadType.Frag)
            {
                float fragPower = ShellPowerPerPayload * PayloadPerSec * MaxPackingTime;
                float fragCount = MathF.Floor(MathF.Pow(fragPower * 3000f, 0.25f));
                float damagePerFrag = fragCount == 0 ? 0 : fragPower / fragCount;
                PayloadDamageLabel.Text = "Frag count: " + fragCount.ToString("F0");
                PayloadSecondaryLabel.Visible = true;
                PayloadSecondaryLabel.Text = "Damage per frag: " + damagePerFrag.ToString("F0");
            }
            else if (((PayloadTypeItem)PayloadTypeDD.SelectedValue).ID == PayloadType.EMP)
            {
                float empPower = ShellPowerPerPayload * PayloadPerSec * MaxPackingTime * 75;
                PayloadDamageLabel.Text = "EMP Damage: " + empPower.ToString("F0");
                PayloadSecondaryLabel.Visible = false;
            }
            else if (((PayloadTypeItem)PayloadTypeDD.SelectedValue).ID == PayloadType.Incendiary)
            {
                // Assume default settings
                float intensityFraction = 0f;
                float oxidizerFraction = 0f;

                float incendiaryIntensity = 20f + intensityFraction * 20f;
                float incendiaryFactor = (1f + 0.2f * (1f - intensityFraction))
                    * PayloadPerSec
                    * MaxPackingTime
                    * 1210f;
                float incendiaryFuel = incendiaryFactor / incendiaryIntensity * (1f - oxidizerFraction);
                float incendiaryOxidizer = incendiaryFactor / 20f * oxidizerFraction;
                PayloadDamageLabel.Text = "Fire fuel: " + incendiaryFuel.ToString("F0");
                PayloadSecondaryLabel.Visible = true;
                PayloadSecondaryLabel.Text = "Intensity: " + incendiaryIntensity.ToString("F0");
            }
            
            UpdatePen();
        }

        private void UpdatePen()
        {
            TargetArmorScheme = new();
            foreach (ArmorLayerItem layerItem in TargetArmorLB.Items)
            {
                TargetArmorScheme.LayerList.Add(layerItem.ID);
            }
            TargetArmorScheme.CalculateLayerAC();
            if (HollowPointCB.Checked)
            {
                float requiredThump = TargetArmorScheme.GetRequiredThump(AP);
                KDToPenLabel.Text = "Thump req'd @ " + AP.ToString("F1") + " AP: " + requiredThump.ToString("F0");
                float excessThump = RawKD - requiredThump;
                ExcessKDLabel.Text = "Excess thump: " + excessThump.ToString("F0");
            }
            else
            {
                float requiredKD = TargetArmorScheme.GetRequiredKD(AP, ImpactAngle, false);
                KDToPenLabel.Text = "KD req'd @ " + AP.ToString("F1") + " AP: " + requiredKD.ToString("F0");
                float excessKD = RawKD - requiredKD;
                ExcessKDLabel.Text = "Excess KD: " + excessKD.ToString("F0");
            }
        }

        private void LowAltFuzeCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFuzeCount();
        }
        private void HighAltFuzeCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFuzeCount();
        }
        private void TimeFromLaunchFuzeCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFuzeCount();
        }
        private void InertialFuzeCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFuzeCount();
        }
        private void PendepthFuzeCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFuzeCount();
        }
        private void TimeFromImpactFuze_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFuzeCount();
        }

        private void GaugeUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateGaugeInM();
            UpdateReloadTime();
            UpdateDetectionRange();
        }

        private void SuppressorBarrelCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDetectionRange();
            UpdatedShellSpeed();
        }

        private void TotalPerSecUD_ValueChanged(object sender, EventArgs e)
        {
            UpdatePelletCounts();
        }
        private void HardPerSecUD_ValueChanged(object sender, EventArgs e)
        {
            UpdatePelletCounts();
        }

        private void CompactorUD_ValueChanged(object sender, EventArgs e)
        {
            UpdatePelletCounts();
        }

        private void HollowPointCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDamage();
        }

        private void PayloadTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDamage();
        }

        private void ImpactAngleUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateAngleMultiplier();
        }

        private void AddArmorLayerButton_Click(object sender, EventArgs e)
        {
            TargetArmorLB.Items.Add(TargetArmorLayerDD.SelectedItem);
            UpdatePen();
        }

        private void DelArmorLayerButton_Click(object sender, EventArgs e)
        {
            if (TargetArmorLB.Items.Count > 0)
            {
                TargetArmorLB.Items.Remove(TargetArmorLB.Items[^1]);
                UpdatePen();
            }
        }
    }
}