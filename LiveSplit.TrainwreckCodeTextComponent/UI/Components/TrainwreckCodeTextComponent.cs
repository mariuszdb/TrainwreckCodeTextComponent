using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.TrainwreckCodeTextComponent.UI.Components;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.TrainwreckCodeTextComponent
{
    public class TrainwreckCodeTextComponent : IComponent
    {
        public TrainwreckCodeTextSettings Settings { get; set; }
        protected InfoTextComponent InternalComponent { get; set; }
        private LiveSplitState CurrentState { get; set; }
        private bool UpdateNeeded { get; set; }


        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float VerticalHeight => InternalComponent.VerticalHeight;
        public float MinimumHeight => InternalComponent.MinimumHeight;

        public float PaddingTop => InternalComponent.PaddingTop;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingRight => InternalComponent.PaddingRight;

        public IDictionary<string, Action> ContextMenuControls => null;

        public TrainwreckCodeTextComponent(LiveSplitState state)
        {
            Settings = new TrainwreckCodeTextSettings();
            InternalComponent = new InfoTextComponent("Trainwreck code", "Not loaded");
            CurrentState = state;
            state.OnStart += state_OnStart;
        }

        public string ComponentName => "TrainwreckCodeTextComponent";

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (!UpdateNeeded) return;
            InternalComponent.InformationValue = readJsonValueFor("numS.numbers[6].number", Settings.SaveFileLocation);
            InternalComponent.Update(invalidator, state, width, height, mode);
            UpdateNeeded = false;
        }

        public void Dispose()
        {
            CurrentState.OnStart -= state_OnStart;
        }

        void state_OnStart(object sender, EventArgs e)
        {
            UpdateNeeded = true;
        }

        private string readJsonValueFor(string jsonKey, string filePath)
        {
            string jsonText = File.ReadAllText(filePath);
            JObject obj = JObject.Parse(jsonText);
            return  (string) obj.SelectToken(jsonKey) ?? $"{jsonKey} not found in the file {filePath}";
        }
    }
}
