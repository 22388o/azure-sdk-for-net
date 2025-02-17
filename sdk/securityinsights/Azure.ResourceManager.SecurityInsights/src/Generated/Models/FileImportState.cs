// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The state of the file import. </summary>
    public readonly partial struct FileImportState : IEquatable<FileImportState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileImportState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileImportState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FatalErrorValue = "FatalError";
        private const string IngestedValue = "Ingested";
        private const string IngestedWithErrorsValue = "IngestedWithErrors";
        private const string InProgressValue = "InProgress";
        private const string InvalidValue = "Invalid";
        private const string WaitingForUploadValue = "WaitingForUpload";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary> A fatal error has occurred while ingesting the file. </summary>
        public static FileImportState FatalError { get; } = new FileImportState(FatalErrorValue);
        /// <summary> The file has been ingested. </summary>
        public static FileImportState Ingested { get; } = new FileImportState(IngestedValue);
        /// <summary> The file has been ingested with errors. </summary>
        public static FileImportState IngestedWithErrors { get; } = new FileImportState(IngestedWithErrorsValue);
        /// <summary> The file ingestion is in progress. </summary>
        public static FileImportState InProgress { get; } = new FileImportState(InProgressValue);
        /// <summary> The file is invalid. </summary>
        public static FileImportState Invalid { get; } = new FileImportState(InvalidValue);
        /// <summary> Waiting for the file to be uploaded. </summary>
        public static FileImportState WaitingForUpload { get; } = new FileImportState(WaitingForUploadValue);
        /// <summary> Unspecified state. </summary>
        public static FileImportState Unspecified { get; } = new FileImportState(UnspecifiedValue);
        /// <summary> Determines if two <see cref="FileImportState"/> values are the same. </summary>
        public static bool operator ==(FileImportState left, FileImportState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileImportState"/> values are not the same. </summary>
        public static bool operator !=(FileImportState left, FileImportState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileImportState"/>. </summary>
        public static implicit operator FileImportState(string value) => new FileImportState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileImportState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileImportState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
