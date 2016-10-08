﻿using System;
using System.Configuration;

namespace Conference.Common
{
    public class ConfigSettings
    {
        public static TimeSpan ReservationAutoExpiration = TimeSpan.FromMinutes(15);
        public static string ConferenceENodeConnectionString { get; set; }
        public static string ConferenceConnectionString { get; set; }
        public static string ConferenceTable { get; set; }
        public static string ConferenceSlugIndexTable { get; set; }
        public static string SeatTypeTable { get; set; }
        public static string ReservationItemsTable { get; set; }
        public static string OrderTable { get; set; }
        public static string OrderLineTable { get; set; }
        public static string OrderSeatAssignmentsTable { get; set; }
        public static string PaymentTable { get; set; }
        public static string PaymentItemTable { get; set; }
        public static int BrokerProducerPort { get; set; }
        public static int BrokerConsumerPort { get; set; }
        public static int BrokerAdminPort { get; set; }

        public static void Initialize()
        {
            if (ConfigurationManager.ConnectionStrings["enode"] != null)
            {
                ConferenceENodeConnectionString = ConfigurationManager.ConnectionStrings["enode"].ConnectionString;
            }
            if (ConfigurationManager.ConnectionStrings["conference"] != null)
            {
                ConferenceConnectionString = ConfigurationManager.ConnectionStrings["conference"].ConnectionString;
            }
            ConferenceTable = "Conferences";
            ConferenceSlugIndexTable = "ConferenceSlugs";
            SeatTypeTable = "ConferenceSeatTypes";
            ReservationItemsTable = "ReservationItems";
            OrderTable = "Orders";
            OrderLineTable = "OrderLines";
            OrderSeatAssignmentsTable = "OrderSeatAssignments";
            PaymentTable = "Payments";
            PaymentItemTable = "PaymentItems";

            BrokerProducerPort = 10000;
            BrokerConsumerPort = 10001;
            BrokerAdminPort = 10002;
        }
    }
}
