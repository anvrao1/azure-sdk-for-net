// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Define match variables. </summary>
    public partial class MatchVariable
    {
        /// <summary> Initializes a new instance of MatchVariable. </summary>
        /// <param name="variableName"> Match Variable. </param>
        public MatchVariable(WebApplicationFirewallMatchVariable variableName)
        {
            VariableName = variableName;
        }

        /// <summary> Initializes a new instance of MatchVariable. </summary>
        /// <param name="variableName"> Match Variable. </param>
        /// <param name="selector"> The selector of match variable. </param>
        internal MatchVariable(WebApplicationFirewallMatchVariable variableName, string selector)
        {
            VariableName = variableName;
            Selector = selector;
        }

        /// <summary> Match Variable. </summary>
        public WebApplicationFirewallMatchVariable VariableName { get; set; }
        /// <summary> The selector of match variable. </summary>
        public string Selector { get; set; }
    }
}
