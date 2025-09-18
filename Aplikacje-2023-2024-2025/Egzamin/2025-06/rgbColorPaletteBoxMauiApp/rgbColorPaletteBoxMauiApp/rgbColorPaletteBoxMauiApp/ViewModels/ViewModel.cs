using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgbColorPaletteBoxMauiApp.ViewModels
{
    class ViewModel : BindableObject
    {
		private int previewColor;

		public int PreviewColor
        {
			get { return previewColor; }
			set { previewColor = value; }
		}

	}
}
