//
// System.Drawing.PreviewPrintController.cs
//
// Author:
//   Dennis Hayes (dennish@Raytek.com)
//
// (C) 2002 Ximian, Inc
//

using System;

namespace System.Drawing.Printing
{
	public class PreviewPrintController : PrintController
	{
		private bool useantialias;

		public PreviewPrintController()
		{
			useantialias = false;
		}

		[MonoTODO]
		public override void OnEndPage(PrintDocument document, PrintPageEventArgs e){
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void OnStartPrint(PrintDocument document, PrintEventArgs e){
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override void OnEndPrint(PrintDocument document, PrintEventArgs e){
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e){
			throw new NotImplementedException ();
		}
		
		public bool UseAntiAlias {
			get{
				return useantialias;
			}
			set{
				useantialias = value;
			}
		}

		[MonoTODO]
		public PreviewPageInfo [] GetPreviewPageInfo(){
			throw new NotImplementedException ();
		}

	}
}
