using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Eternals_WebBrowser
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private IContainer components;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button4_Click);
				if (this._Button4 != null)
				{
					this._Button4.Click -= eventHandler;
				}
				this._Button4 = value;
				if (this._Button4 != null)
				{
					this._Button4.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button5_Click);
				if (this._Button5 != null)
				{
					this._Button5.Click -= eventHandler;
				}
				this._Button5 = value;
				if (this._Button5 != null)
				{
					this._Button5.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button6_Click);
				if (this._Button6 != null)
				{
					this._Button6.Click -= eventHandler;
				}
				this._Button6 = value;
				if (this._Button6 != null)
				{
					this._Button6.Click += eventHandler;
				}
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		internal virtual WebBrowser WebBrowser1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WebBrowser1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser1 = value;
			}
		}

		[DebuggerNonUserCode]
		public Form1()
		{
			this.InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.GoBack();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.GoForward();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.Navigate(this.TextBox1.Text);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.GoHome();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.Refresh();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.Stop();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.Button1 = new Button();
			this.Button2 = new Button();
			this.Button3 = new Button();
			this.TextBox1 = new TextBox();
			this.Button4 = new Button();
			this.Button5 = new Button();
			this.Button6 = new Button();
			this.WebBrowser1 = new WebBrowser();
			this.SuspendLayout();
			Button button1 = this.Button1;
			Point point = new Point(410, 38);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			System.Drawing.Size size = new System.Drawing.Size(87, 30);
			button.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Back";
			this.Button1.UseVisualStyleBackColor = true;
			Button button2 = this.Button2;
			point = new Point(526, 38);
			button2.Location = point;
			this.Button2.Name = "Button2";
			Button button21 = this.Button2;
			size = new System.Drawing.Size(88, 30);
			button21.Size = size;
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Forward";
			this.Button2.UseVisualStyleBackColor = true;
			Button button3 = this.Button3;
			point = new Point(943, 12);
			button3.Location = point;
			this.Button3.Name = "Button3";
			Button button31 = this.Button3;
			size = new System.Drawing.Size(112, 20);
			button31.Size = size;
			this.Button3.TabIndex = 2;
			this.Button3.Text = "Go";
			this.Button3.UseVisualStyleBackColor = true;
			TextBox textBox1 = this.TextBox1;
			point = new Point(305, 12);
			textBox1.Location = point;
			this.TextBox1.Name = "TextBox1";
			TextBox textBox = this.TextBox1;
			size = new System.Drawing.Size(611, 20);
			textBox.Size = size;
			this.TextBox1.TabIndex = 3;
			Button button4 = this.Button4;
			point = new Point(12, 12);
			button4.Location = point;
			this.Button4.Name = "Button4";
			Button button41 = this.Button4;
			size = new System.Drawing.Size(75, 45);
			button41.Size = size;
			this.Button4.TabIndex = 4;
			this.Button4.Text = "Home";
			this.Button4.UseVisualStyleBackColor = true;
			Button button5 = this.Button5;
			point = new Point(93, 12);
			button5.Location = point;
			this.Button5.Name = "Button5";
			Button button51 = this.Button5;
			size = new System.Drawing.Size(75, 45);
			button51.Size = size;
			this.Button5.TabIndex = 5;
			this.Button5.Text = "Refresh";
			this.Button5.UseVisualStyleBackColor = true;
			Button button6 = this.Button6;
			point = new Point(174, 12);
			button6.Location = point;
			this.Button6.Name = "Button6";
			Button button61 = this.Button6;
			size = new System.Drawing.Size(75, 45);
			button61.Size = size;
			this.Button6.TabIndex = 6;
			this.Button6.Text = "Stop";
			this.Button6.UseVisualStyleBackColor = true;
			WebBrowser webBrowser1 = this.WebBrowser1;
			point = new Point(-3, 74);
			webBrowser1.Location = point;
			WebBrowser webBrowser = this.WebBrowser1;
			size = new System.Drawing.Size(20, 20);
			webBrowser.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			WebBrowser webBrowser11 = this.WebBrowser1;
			size = new System.Drawing.Size(1135, 638);
			webBrowser11.Size = size;
			this.WebBrowser1.TabIndex = 7;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(1132, 711);
			this.ClientSize = size;
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form1";
			this.Text = "Eternals WebBrowser";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}