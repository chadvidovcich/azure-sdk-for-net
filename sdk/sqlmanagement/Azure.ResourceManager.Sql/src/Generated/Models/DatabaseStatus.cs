// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The status of the database. </summary>
    public readonly partial struct DatabaseStatus : IEquatable<DatabaseStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnlineValue = "Online";
        private const string RestoringValue = "Restoring";
        private const string RecoveryPendingValue = "RecoveryPending";
        private const string RecoveringValue = "Recovering";
        private const string SuspectValue = "Suspect";
        private const string OfflineValue = "Offline";
        private const string StandbyValue = "Standby";
        private const string ShutdownValue = "Shutdown";
        private const string EmergencyModeValue = "EmergencyMode";
        private const string AutoClosedValue = "AutoClosed";
        private const string CopyingValue = "Copying";
        private const string CreatingValue = "Creating";
        private const string InaccessibleValue = "Inaccessible";
        private const string OfflineSecondaryValue = "OfflineSecondary";
        private const string PausingValue = "Pausing";
        private const string PausedValue = "Paused";
        private const string ResumingValue = "Resuming";
        private const string ScalingValue = "Scaling";
        private const string OfflineChangingDwPerformanceTiersValue = "OfflineChangingDwPerformanceTiers";
        private const string OnlineChangingDwPerformanceTiersValue = "OnlineChangingDwPerformanceTiers";
        private const string DisabledValue = "Disabled";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string StartingValue = "Starting";

        /// <summary> Online. </summary>
        public static DatabaseStatus Online { get; } = new DatabaseStatus(OnlineValue);
        /// <summary> Restoring. </summary>
        public static DatabaseStatus Restoring { get; } = new DatabaseStatus(RestoringValue);
        /// <summary> RecoveryPending. </summary>
        public static DatabaseStatus RecoveryPending { get; } = new DatabaseStatus(RecoveryPendingValue);
        /// <summary> Recovering. </summary>
        public static DatabaseStatus Recovering { get; } = new DatabaseStatus(RecoveringValue);
        /// <summary> Suspect. </summary>
        public static DatabaseStatus Suspect { get; } = new DatabaseStatus(SuspectValue);
        /// <summary> Offline. </summary>
        public static DatabaseStatus Offline { get; } = new DatabaseStatus(OfflineValue);
        /// <summary> Standby. </summary>
        public static DatabaseStatus Standby { get; } = new DatabaseStatus(StandbyValue);
        /// <summary> Shutdown. </summary>
        public static DatabaseStatus Shutdown { get; } = new DatabaseStatus(ShutdownValue);
        /// <summary> EmergencyMode. </summary>
        public static DatabaseStatus EmergencyMode { get; } = new DatabaseStatus(EmergencyModeValue);
        /// <summary> AutoClosed. </summary>
        public static DatabaseStatus AutoClosed { get; } = new DatabaseStatus(AutoClosedValue);
        /// <summary> Copying. </summary>
        public static DatabaseStatus Copying { get; } = new DatabaseStatus(CopyingValue);
        /// <summary> Creating. </summary>
        public static DatabaseStatus Creating { get; } = new DatabaseStatus(CreatingValue);
        /// <summary> Inaccessible. </summary>
        public static DatabaseStatus Inaccessible { get; } = new DatabaseStatus(InaccessibleValue);
        /// <summary> OfflineSecondary. </summary>
        public static DatabaseStatus OfflineSecondary { get; } = new DatabaseStatus(OfflineSecondaryValue);
        /// <summary> Pausing. </summary>
        public static DatabaseStatus Pausing { get; } = new DatabaseStatus(PausingValue);
        /// <summary> Paused. </summary>
        public static DatabaseStatus Paused { get; } = new DatabaseStatus(PausedValue);
        /// <summary> Resuming. </summary>
        public static DatabaseStatus Resuming { get; } = new DatabaseStatus(ResumingValue);
        /// <summary> Scaling. </summary>
        public static DatabaseStatus Scaling { get; } = new DatabaseStatus(ScalingValue);
        /// <summary> OfflineChangingDwPerformanceTiers. </summary>
        public static DatabaseStatus OfflineChangingDwPerformanceTiers { get; } = new DatabaseStatus(OfflineChangingDwPerformanceTiersValue);
        /// <summary> OnlineChangingDwPerformanceTiers. </summary>
        public static DatabaseStatus OnlineChangingDwPerformanceTiers { get; } = new DatabaseStatus(OnlineChangingDwPerformanceTiersValue);
        /// <summary> Disabled. </summary>
        public static DatabaseStatus Disabled { get; } = new DatabaseStatus(DisabledValue);
        /// <summary> Stopping. </summary>
        public static DatabaseStatus Stopping { get; } = new DatabaseStatus(StoppingValue);
        /// <summary> Stopped. </summary>
        public static DatabaseStatus Stopped { get; } = new DatabaseStatus(StoppedValue);
        /// <summary> Starting. </summary>
        public static DatabaseStatus Starting { get; } = new DatabaseStatus(StartingValue);
        /// <summary> Determines if two <see cref="DatabaseStatus"/> values are the same. </summary>
        public static bool operator ==(DatabaseStatus left, DatabaseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseStatus"/> values are not the same. </summary>
        public static bool operator !=(DatabaseStatus left, DatabaseStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatabaseStatus"/>. </summary>
        public static implicit operator DatabaseStatus(string value) => new DatabaseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
