// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DtmfResult. </summary>
    public partial class DtmfResult
    {
        /// <summary> Initializes a new instance of <see cref="DtmfResult"/>. </summary>
        internal DtmfResult()
        {
            Tones = new ChangeTrackingList<DtmfTone>();
        }

        /// <summary> Initializes a new instance of <see cref="DtmfResult"/>. </summary>
        /// <param name="tones"></param>
        internal DtmfResult(IReadOnlyList<DtmfTone> tones)
        {
            Tones = tones;
        }
    }
}
