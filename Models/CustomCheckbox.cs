using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCurseWork.Models
{
	public class CustomCheckBox : CheckBox
	{
		public Image CheckedImage { get; set; }
		public Image UncheckedImage { get; set; }

		public CustomCheckBox()
		{
			this.Appearance = Appearance.Button; 
			this.FlatStyle = FlatStyle.Flat; 
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);

			if (this.Checked && this.CheckedImage != null)
			{
				pevent.Graphics.DrawImage(this.CheckedImage, new Point(0, 0));
			}
			else if (!this.Checked && this.UncheckedImage != null)
			{
				pevent.Graphics.DrawImage(this.UncheckedImage, new Point(0, 0));
			}
		}
	}
}
