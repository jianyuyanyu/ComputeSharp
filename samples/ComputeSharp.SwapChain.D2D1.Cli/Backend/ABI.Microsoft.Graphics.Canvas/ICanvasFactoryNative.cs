using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using TerraFX.Interop;

#pragma warning disable CS0649, IDE0055, IDE1006

namespace ABI.Microsoft.Graphics.Canvas;

/// <summary>
/// Raw bindings for the interop interface for the <see cref="CanvasDevice"/> activation factory.
/// </summary>
internal unsafe struct ICanvasFactoryNative : IUnknown.Interface
{
    public void** lpVtbl;

    /// <inheritdoc/>
    static Guid* INativeGuid.NativeGuid
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D, 0x44, 0x5C, 0x69,
                0xB3, 0x04,
                0xDD, 0x4E,
                0xBF, 0xD9,
                0x63,
                0xE5,
                0x1E,
                0x9F,
                0x72,
                0x02
            ];

            return (Guid*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICanvasFactoryNative*, Guid*, void**, int>)this.lpVtbl[0])((ICanvasFactoryNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICanvasFactoryNative*, uint>)this.lpVtbl[1])((ICanvasFactoryNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICanvasFactoryNative*, uint>)this.lpVtbl[2])((ICanvasFactoryNative*)Unsafe.AsPointer(ref this));
    }

    /// <summary>
    /// Gets or creates an <c>IInspectable</c> Win2D wrapper for a given native D2D resource.
    /// </summary>
    /// <param name="device">The input canvas device (as a marshalled <see cref="global::Microsoft.Graphics.Canvas.CanvasDevice"/>).</param>
    /// <param name="resource">The input native resource to create a wrapper for.</param>
    /// <param name="dpi">The realization DPIs for <paramref name="resource"/></param>
    /// <param name="wrapper">The resulting wrapper for <paramref name="resource"/>.</param>
    /// <returns>The <c>HRESULT</c> for the operation.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetOrCreate(IUnknown* device, IUnknown* resource, float dpi, void** wrapper)
    {
        return ((delegate* unmanaged[MemberFunction]<ICanvasFactoryNative*, IUnknown*, IUnknown*, float, void**, int>)this.lpVtbl[6])(
            (ICanvasFactoryNative*)Unsafe.AsPointer(ref this),
            device,
            resource,
            dpi,
            wrapper);
    }
}