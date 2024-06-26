// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogConsent. </summary>
    internal partial class DialogConsentInternal
    {
        /// <summary> Initializes a new instance of <see cref="DialogConsentInternal"/>. </summary>
        internal DialogConsentInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DialogConsentInternal"/>. </summary>
        /// <param name="userConsent"> UserConsent data from the Conversation Conductor. </param>
        /// <param name="operationContext"> Used by customers when calling answerCall action to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="dialogInputType"> Determines the type of the dialog. </param>
        /// <param name="dialogId"> Dialog ID. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal DialogConsentInternal(UserConsent userConsent, string operationContext, ResultInformation resultInformation, DialogInputType? dialogInputType, string dialogId, string callConnectionId, string serverCallId, string correlationId)
        {
            UserConsent = userConsent;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            DialogInputType = dialogInputType;
            DialogId = dialogId;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }

        /// <summary> UserConsent data from the Conversation Conductor. </summary>
        public UserConsent UserConsent { get; }
        /// <summary> Used by customers when calling answerCall action to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType? DialogInputType { get; }
        /// <summary> Dialog ID. </summary>
        public string DialogId { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
