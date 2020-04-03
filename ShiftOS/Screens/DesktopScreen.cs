using AlkalineThunder.Nucleus.Gui;
using AlkalineThunder.Nucleus.Screens;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftOS.Screens
{
    public sealed class DesktopScreen : Screen
    {
        private StackPanel _root = new StackPanel();
        private Border _desktopPanel = new Border();
        private Border _workspace = new Border();
        private StackPanel _panelStacker = new StackPanel();
        private Label _timeOfDay = new Label();
        private StackPanel _panelButtonList = new StackPanel();
        private Border _appsButton = new Border();

        protected override void OnInitialize()
        {
            // Set up the GUI hierarchy
            _root.Children.Add(_desktopPanel);
            _root.Children.Add(_workspace);
            _desktopPanel.Content = _panelStacker;
            _panelStacker.Children.Add(_appsButton);
            _panelStacker.Children.Add(_panelButtonList);
            _panelStacker.Children.Add(_timeOfDay);

            // Give the screen a GUI
            Content = _root;

            // Workspace and panel button list all take up entire space of their parents.
            _root.SetSizeMode(_workspace, SizeMode.Fill);
            _panelStacker.SetSizeMode(_panelButtonList, SizeMode.Fill);

            // Desktop panel stacker needs to stack horizontally, so do panel buttons.
            _panelStacker.Orientation = Orientation.Horizontal;
            _panelButtonList.Orientation = Orientation.Horizontal;

            // Time of day should be centered
            _timeOfDay.VerticalAlignment = VerticalAlignment.Middle;

            // Workspace should be transparent.
            _workspace.BorderType = AlkalineThunder.Nucleus.Rendering.BrushType.None;

            // FIXME: Should be gone when skinning is added again
            _desktopPanel.Color = Color.Gray;

            base.OnInitialize();
        }

        protected override void OnUpdate(GameTime gameTime)
        {
            // Set time of day text
            _timeOfDay.Text = DateTime.Now.ToShortTimeString();

            base.OnUpdate(gameTime);
        }
    }
}
