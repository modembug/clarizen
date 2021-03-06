﻿namespace Ekin.Clarizen.Authentication.Result
{
    public class GetSessionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldValue[] CustomInfo { get; set; }

        /// <summary>
        /// A unique ID representing the current session
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// The unique ID of the current user. Can be used to retrieve additional information about the current user
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The unique ID of the current organization. Can be used to retrieve additional information about the current organization
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// Indicates which license the current user is assigned
        /// </summary>
        public string LicenseType { get; set; }
    }
}