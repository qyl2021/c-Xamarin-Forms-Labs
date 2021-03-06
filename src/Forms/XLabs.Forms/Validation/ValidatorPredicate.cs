// ***********************************************************************
// Assembly         : XLabs.Forms
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="ValidatorPredicate.cs" company="XLabs Team">
//     Copyright (c) XLabs Team. All rights reserved.
// </copyright>
// <summary>
//       This project is licensed under the Apache 2.0 license
//       https://github.com/XLabs/Xamarin-Forms-Labs/blob/master/LICENSE
//       
//       XLabs is a open source project that aims to provide a powerfull and cross 
//       platform set of controls tailored to work with Xamarin Forms.
// </summary>
// ***********************************************************************
// 

using System;

namespace XLabs.Forms.Validation
{
	/// <summary>
	/// Class ValidatorPredicate.
	/// </summary>
	internal class ValidatorPredicate
	{
		#region Fields

		/// <summary>
		/// The _evaluator
		/// </summary>
		private readonly Func<Rule, string, bool> _evaluator;
		/// <summary>
		/// The _id
		/// </summary>
		private readonly Validators _id;

		#endregion

		#region Constructors and Destructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ValidatorPredicate"/> class.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="priority">The priority.</param>
		/// <param name="eval">The eval.</param>
		public ValidatorPredicate(Validators id, PredicatePriority priority, Func<Rule, string, bool> eval)
		{
			_id = id;
			_evaluator = eval;
			Priority = priority;
		}

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets the predicate.
		/// </summary>
		/// <value>The predicate.</value>
		public Func<Rule, string, bool> Predicate { get { return _evaluator; } }
		/// <summary>
		/// Gets the type of the validator.
		/// </summary>
		/// <value>The type of the validator.</value>
		public Validators ValidatorType { get { return _id; } }
		/// <summary>
		/// Gets the priority.
		/// </summary>
		/// <value>The priority.</value>
		public PredicatePriority Priority { get; private set; }
		#endregion

		#region Public Methods and Operators

		/// <summary>
		/// Determines whether the specified identifier is a.
		/// </summary>
		/// <param name="identifier">The identifier.</param>
		/// <returns><c>true</c> if the specified identifier is a; otherwise, <c>false</c>.</returns>
		public bool IsA(Validators identifier) { return (identifier & _id) == _id; }

		#endregion
	}
}