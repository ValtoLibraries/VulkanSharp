/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;
using System.Runtime.InteropServices;

namespace Vulkan.iOS
{
	unsafe public partial class IOSSurfaceCreateInfoMvk : MarshalledObject
	{
		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public IntPtr View {
			get { return m->View; }
			set { m->View = value; }
		}
		internal iOS.Interop.IOSSurfaceCreateInfoMvk* m {

			get {
				return (iOS.Interop.IOSSurfaceCreateInfoMvk*)native.Handle;
			}
		}

		public IOSSurfaceCreateInfoMvk ()
		{
			native = Vulkan.Interop.Structure.Allocate (typeof (iOS.Interop.IOSSurfaceCreateInfoMvk));
			Initialize ();
		}

		internal IOSSurfaceCreateInfoMvk (NativePointer pointer)
		{
			native = pointer;
			Initialize ();
		}


		internal void Initialize ()
		{
			m->SType = StructureType.IOSSurfaceCreateInfoMvk;
		}

	}

}
