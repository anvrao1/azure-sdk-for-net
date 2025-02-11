// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SAP HANA Linked Service. </summary>
    public partial class SapHanaLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of SapHanaLinkedService. </summary>
        public SapHanaLinkedService()
        {
            LinkedServiceType = "SapHana";
        }

        /// <summary> Initializes a new instance of SapHanaLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> SAP HANA ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="server"> Host name of the SAP HANA server. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the SAP HANA server. </param>
        /// <param name="userName"> Username to access the SAP HANA server. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to access the SAP HANA server. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SapHanaLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryElement<string> server, SapHanaAuthenticationType? authenticationType, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Server = server;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SapHana";
        }

        /// <summary> SAP HANA ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> Host name of the SAP HANA server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> The authentication type to be used to connect to the SAP HANA server. </summary>
        public SapHanaAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username to access the SAP HANA server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password to access the SAP HANA server. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
