using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace SuperAventureProject
{
    public partial class Form1 : Form
    {
        private Player _player;
        public Form1()
        {
            InitializeComponent();

            Location location = new Location(1,"Darklands", "Home to Elite Troops");
            _player = new Player();

            _player.MaximumHitPoints = 10;
            _player.CurrentHitPoints = 10;
            _player.ExpieriencePoints = 0;
            _player.Gold = 20;
            _player.Level = 1;

            lblGold.Text = _player.Gold.ToString();
            lblExpierience.Text = _player.ExpieriencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();

        }
    }
}
