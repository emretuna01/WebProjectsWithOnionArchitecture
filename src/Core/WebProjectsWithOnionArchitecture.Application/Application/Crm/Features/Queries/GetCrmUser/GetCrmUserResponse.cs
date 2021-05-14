﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserResponse
    {

            [JsonProperty("@odata.etag")]
            public string OdataEtag { get; set; }
            public string homephone { get; set; }
            public int address2_addresstypecode { get; set; }
            public bool islicensed { get; set; }
            public int accessmode { get; set; }
            public string _new_muhasebesorumlusu_value { get; set; }
            public string systemuserid { get; set; }
            public bool issyncwithdirectory { get; set; }
            public int address2_shippingmethodcode { get; set; }
            public string title { get; set; }
            public string address1_telephone1 { get; set; }
            public string domainname { get; set; }
            public DateTime modifiedon { get; set; }
            public int preferredaddresscode { get; set; }
            public bool displayinserviceviews { get; set; }
            public bool defaultfilterspopulated { get; set; }
            public string _new_sekreteryasorumlusu_value { get; set; }
            public int address1_shippingmethodcode { get; set; }
            public int preferredemailcode { get; set; }
            public string lastname { get; set; }
            public string new_username { get; set; }
            public int? new_portalyetkidzeyi { get; set; }
            public int caltype { get; set; }
            public string _new_ksorumlusu_value { get; set; }
            public string _calendarid_value { get; set; }
            public string firstname { get; set; }
            public int userlicensetype { get; set; }
            public double? new_kalanbakiye { get; set; }
            public string _new_btsorumlusu_value { get; set; }
            public string yomifullname { get; set; }
            public string _businessunitid_value { get; set; }
            public int incomingemaildeliverymethod { get; set; }
            public string middlename { get; set; }
            public bool setupuser { get; set; }
            public string _new_takmyneticisi_value { get; set; }
            public int? timezoneruleversionnumber { get; set; }
            public string address1_addressid { get; set; }
            public double new_mazeretzni { get; set; }
            public DateTime createdon { get; set; }
            public string address1_stateorprovince { get; set; }
            public string organizationid { get; set; }
            public string _new_kurumsal_sorumlusu_value { get; set; }
            public string defaultodbfoldername { get; set; }
            public string jobtitle { get; set; }
            public string _defaultmailbox_value { get; set; }
            public string new_bordroadsoyad { get; set; }
            public int outgoingemaildeliverymethod { get; set; }
            public string versionnumber { get; set; }
            public string address1_line1 { get; set; }
            public string _new_lgilicoo_value { get; set; }
            public string _territoryid_value { get; set; }
            public bool isintegrationuser { get; set; }
            public int? utcconversiontimezonecode { get; set; }
            public int address1_addresstypecode { get; set; }
            public bool new_timesheet { get; set; }
            public string _modifiedby_value { get; set; }
            public DateTime? new_ise_giris_tarihi { get; set; }
            public string _createdby_value { get; set; }
            public string address1_city { get; set; }
            public int preferredphonecode { get; set; }
            public int? new_timesheetsre { get; set; }
            public string fullname { get; set; }
            public string _new_lgiligmy_value { get; set; }
            public DateTime? new_dogumgunu { get; set; }
            public int invitestatuscode { get; set; }
            public bool isdisabled { get; set; }
            public string address2_addressid { get; set; }
            public int emailrouteraccessapproval { get; set; }
            public string address1_postalcode { get; set; }
            public string internalemailaddress { get; set; }
            public string _parentsystemuserid_value { get; set; }
            public string new_mezuniyetokulu { get; set; }
            public bool isemailaddressapprovedbyo365admin { get; set; }
            public string _queueid_value { get; set; }
            public string _new_idari_islersorumlusu_value { get; set; }
            public string address1_composite { get; set; }
            public string ownerid { get; set; }
            public string nickname { get; set; }
            public string azureactivedirectorystringid { get; set; }
            public string address2_stateorprovince { get; set; }
            public string applicationiduri { get; set; }
            public string address1_county { get; set; }
            public string address2_country { get; set; }
            public string address2_postofficebox { get; set; }
            public string yammeruserid { get; set; }
            public int? new_gendercode { get; set; }
            public string new_language { get; set; }
            public string employeeid { get; set; }
            public int? new_kangrubu { get; set; }
            public string new_mezuniyetblm { get; set; }
            public string skills { get; set; }
            public string address2_composite { get; set; }
            public string entityimage { get; set; }
            public string windowsliveid { get; set; }
            public string address1_line3 { get; set; }
            public string disabledreason { get; set; }
            public string address2_utcoffset { get; set; }
            public string address1_line2 { get; set; }
            public string personalemailaddress { get; set; }
            public string address1_telephone2 { get; set; }
            public string _createdonbehalfby_value { get; set; }
            public string _new_gm2_value { get; set; }
            public string sharepointemailaddress { get; set; }
            public string yomifirstname { get; set; }
            public double? exchangerate { get; set; }
            public string yomimiddlename { get; set; }
            public string address2_line2 { get; set; }
            public string traversedpath { get; set; }
            public string _new_2onayc_value { get; set; }
            public string address1_country { get; set; }
            public string yomilastname { get; set; }
            public string address2_latitude { get; set; }
            public string address1_longitude { get; set; }
            public string address2_fax { get; set; }
            public string _new_gm1_value { get; set; }
            public string new_timesheettarih { get; set; }
            public string address1_latitude { get; set; }
            public string entityimage_timestamp { get; set; }
            public DateTime? new_isten_cikis_tarihi { get; set; }
            public string mobilephone { get; set; }
            public string photourl { get; set; }
            public string _siteid_value { get; set; }
            public string _transactioncurrencyid_value { get; set; }
            public string new_password { get; set; }
            public string new_tecrbesi { get; set; }
            public string passportlo { get; set; }
            public string _mobileofflineprofileid_value { get; set; }
            public string address1_name { get; set; }
            public string address2_telephone2 { get; set; }
            public string new_acildurumdaulalacakkii { get; set; }
            public string stageid { get; set; }
            public string address2_longitude { get; set; }
            public string salutation { get; set; }
            public string yammeremailaddress { get; set; }
            public string address2_city { get; set; }
            public string entityimageid { get; set; }
            public string address2_county { get; set; }
            public string address2_line1 { get; set; }
            public string address2_upszone { get; set; }
            public string address1_utcoffset { get; set; }
            public string _positionid_value { get; set; }
            public string passporthi { get; set; }
            public string address1_telephone3 { get; set; }
            public string _new_doumyeri_value { get; set; }
            public string address2_postalcode { get; set; }
            public string address2_telephone1 { get; set; }
            public string entityimage_url { get; set; }
            public string processid { get; set; }
            public string governmentid { get; set; }
            public string _modifiedonbehalfby_value { get; set; }
            public string new_jobtitleeng { get; set; }
            public string address2_line3 { get; set; }
            public string address2_name { get; set; }
            public string overriddencreatedon { get; set; }
            public string address1_upszone { get; set; }
            public string importsequencenumber { get; set; }
            public string mobilealertemail { get; set; }
            public string new_ceptelefonuzel { get; set; }
            public string address1_fax { get; set; }
            public string new_kullanici_rolu { get; set; }
            public string address2_telephone3 { get; set; }
            public string address1_postofficebox { get; set; }
            public string new_mezuniyetyl { get; set; }
            public double? new_bakiyefark { get; set; }
            public string new_ncekiyerleri { get; set; }
            public string applicationid { get; set; }
        

    }
}
