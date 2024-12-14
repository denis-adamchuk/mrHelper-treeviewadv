using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Aga.Controls.Tree
{
	public class DrawColHeaderBgEventArgs : EventArgs
	{
		private	bool		handled		= false;
		private	Graphics	graphics	= null;
		private	Rectangle	bounds		= Rectangle.Empty;
		private	bool		pressed		= false;
		private	bool		hot			= false;

		public bool Handled
		{
			get { return this.handled; }
			set { this.handled = value; }
		}
		public Graphics Graphics
		{
			get { return this.graphics; }
		}
		public Rectangle Bounds
		{
			get { return this.bounds; }
		}
		public bool Pressed
		{
			get { return this.pressed; }
		}
		public bool Hot
		{
			get { return this.hot; }
		}

		public DrawColHeaderBgEventArgs(Graphics g, Rectangle bounds, bool pressed, bool hot)
		{
			this.graphics = g;
			this.bounds = bounds;
			this.pressed = pressed;
			this.hot = hot;
		}
	}

	public class DrawColHeaderTextEventArgs : EventArgs
	{
		private	bool		handled		= false;
		private	Graphics	graphics	= null;
		private	Rectangle	bounds		= Rectangle.Empty;
      private string text;
      private System.Windows.Forms.TextFormatFlags flags;

      public DrawColHeaderTextEventArgs(Graphics graphics,
			Rectangle bounds, string text, System.Windows.Forms.TextFormatFlags flags)
      {
         this.graphics = graphics;
         this.bounds = bounds;
         this.text = text;
         this.flags = flags;
      }

      public bool Handled
		{
			get { return this.handled; }
			set { this.handled = value; }
		}

		public Graphics Graphics
		{
			get { return this.graphics; }
		}

		public Rectangle Bounds
		{
			get { return this.bounds; }
		}

      public string Text 
      {
         get => text; 
      }

      public System.Windows.Forms.TextFormatFlags Flags
      {
         get => flags; 
      }
   }
}
