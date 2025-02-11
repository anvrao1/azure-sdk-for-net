// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The CommentFeedbackValue. </summary>
    internal partial class CommentFeedbackValue
    {
        /// <summary> Initializes a new instance of CommentFeedbackValue. </summary>
        /// <param name="commentValue"> the comment string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commentValue"/> is null. </exception>
        public CommentFeedbackValue(string commentValue)
        {
            Argument.AssertNotNull(commentValue, nameof(commentValue));

            CommentValue = commentValue;
        }

        /// <summary> the comment string. </summary>
        public string CommentValue { get; set; }
    }
}
