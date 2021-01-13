﻿using CloudFlare.Client.Enumerators;

namespace CloudFlare.Client.Api.Memberships
{
    public class MembershipFilter
    {
        /// <summary>
        /// Status of this membership
        /// </summary>
        public MembershipStatus? Status { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Field to order memberships by
        /// </summary>
        public MembershipOrder? MembershipOrder { get; set; }
    }
}