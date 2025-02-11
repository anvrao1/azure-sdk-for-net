﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Rehydrates a <see cref="StorageResource"/> for resume.
    /// </summary>
    public abstract class StorageResourceProvider
    {
        /// <summary>
        /// Type ID. For DataMovement to query in selecting appropirate provider on resume.
        /// </summary>
        protected internal abstract string TypeId { get; }

        /// <summary>
        /// Gets a source resource from the given transfer properties.
        /// </summary>
        protected internal abstract Task<StorageResource> FromSourceAsync(DataTransferProperties properties, CancellationToken cancellationToken);

        /// <summary>
        /// Gets a source resource from the given transfer properties.
        /// </summary>
        protected internal abstract Task<StorageResource> FromDestinationAsync(DataTransferProperties properties, CancellationToken cancellationToken);
    }
}
