﻿namespace Testeroids
{
    using System.ComponentModel;

    using NUnit.Framework;

    /// <summary>
    ///   Base class for implementing the AAA pattern.
    /// </summary>
    public interface IContextSpecification
    {
        #region Public Properties

        /// <summary>
        ///   Gets a value indicating whether there are prerequisite tests running.
        /// </summary>
        bool ArePrerequisiteTestsRunning { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///   Sets up the test (calls <see cref="Testeroids.ContextSpecificationBase.EstablishContext"/> followed by <see cref="Testeroids.ContextSpecificationBase.InitializeSubjectUnderTest" />).
        /// </summary>
        [SetUp]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void BaseSetUp();

        #endregion
    }
}