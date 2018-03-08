using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			// солнце
			graphics.FillEllipse(Brushes.Yellow, 310, 20, 70, 70);
            for (int x = 0; x <= 300; x = x + 100)
            {
                // рисуем дерево и траву
                DrawGrass(x, 270);
                DrawTree(x, 200);
            }

		}

		private void DrawGrass(int x, int y) {
			Image img = Image.FromFile("../../GrassBlock.png");
			graphics.DrawImage(img, x, y);
		}

		private void DrawTree(int x, int y) {
			Image img = Image.FromFile("../../TreeUgly.png");
			graphics.DrawImage(img, x, y);
		}
	}
}
