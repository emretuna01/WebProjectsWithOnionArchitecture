﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProjectsWithOnionArchitecture.Persist.Persist.Crm.DbContext;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Migrations
{
    [DbContext(typeof(ApplicationCrmDbContext))]
    [Migration("20210512212100_Migration_5")]
    partial class Migration_5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmAccount", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Accountid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OdataEtag")
                        .HasColumnType("TEXT");

                    b.Property<int>("Statecode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Guid");

                    b.ToTable("CrmAccount");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmTask", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegardingObjectidSalesOrderOdataBind")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Scheduledend")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryOfTask")
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.ToTable("CrmTask");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmUser", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("OdataEtag")
                        .HasColumnType("TEXT");

                    b.Property<string>("_businessunitid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_calendarid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_createdby_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_createdonbehalfby_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_defaultmailbox_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_mobileofflineprofileid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_modifiedby_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_modifiedonbehalfby_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_2onayc_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_btsorumlusu_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_doumyeri_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_gm1_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_gm2_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_idari_islersorumlusu_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_ksorumlusu_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_kurumsal_sorumlusu_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_lgilicoo_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_lgiligmy_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_muhasebesorumlusu_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_sekreteryasorumlusu_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_new_takmyneticisi_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_parentsystemuserid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_positionid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_queueid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_siteid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_territoryid_value")
                        .HasColumnType("TEXT");

                    b.Property<string>("_transactioncurrencyid_value")
                        .HasColumnType("TEXT");

                    b.Property<int>("accessmode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("address1_addressid")
                        .HasColumnType("TEXT");

                    b.Property<int>("address1_addresstypecode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("address1_city")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_composite")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_country")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_county")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_fax")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_latitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_line1")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_line2")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_line3")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_longitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_postalcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_postofficebox")
                        .HasColumnType("TEXT");

                    b.Property<int>("address1_shippingmethodcode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("address1_stateorprovince")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_telephone1")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_telephone2")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_telephone3")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_upszone")
                        .HasColumnType("TEXT");

                    b.Property<string>("address1_utcoffset")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_addressid")
                        .HasColumnType("TEXT");

                    b.Property<int>("address2_addresstypecode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("address2_city")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_composite")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_country")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_county")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_fax")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_latitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_line1")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_line2")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_line3")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_longitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_postalcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_postofficebox")
                        .HasColumnType("TEXT");

                    b.Property<int>("address2_shippingmethodcode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("address2_stateorprovince")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_telephone1")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_telephone2")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_telephone3")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_upszone")
                        .HasColumnType("TEXT");

                    b.Property<string>("address2_utcoffset")
                        .HasColumnType("TEXT");

                    b.Property<string>("applicationid")
                        .HasColumnType("TEXT");

                    b.Property<string>("applicationiduri")
                        .HasColumnType("TEXT");

                    b.Property<string>("azureactivedirectorystringid")
                        .HasColumnType("TEXT");

                    b.Property<int>("caltype")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdon")
                        .HasColumnType("TEXT");

                    b.Property<bool>("defaultfilterspopulated")
                        .HasColumnType("INTEGER");

                    b.Property<string>("defaultodbfoldername")
                        .HasColumnType("TEXT");

                    b.Property<string>("disabledreason")
                        .HasColumnType("TEXT");

                    b.Property<bool>("displayinserviceviews")
                        .HasColumnType("INTEGER");

                    b.Property<string>("domainname")
                        .HasColumnType("TEXT");

                    b.Property<int>("emailrouteraccessapproval")
                        .HasColumnType("INTEGER");

                    b.Property<string>("employeeid")
                        .HasColumnType("TEXT");

                    b.Property<string>("entityimage")
                        .HasColumnType("TEXT");

                    b.Property<string>("entityimage_timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("entityimage_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("entityimageid")
                        .HasColumnType("TEXT");

                    b.Property<double?>("exchangerate")
                        .HasColumnType("REAL");

                    b.Property<string>("firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("fullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("governmentid")
                        .HasColumnType("TEXT");

                    b.Property<string>("homephone")
                        .HasColumnType("TEXT");

                    b.Property<string>("importsequencenumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("incomingemaildeliverymethod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("internalemailaddress")
                        .HasColumnType("TEXT");

                    b.Property<int>("invitestatuscode")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isdisabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isemailaddressapprovedbyo365admin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isintegrationuser")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("islicensed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("issyncwithdirectory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("jobtitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("middlename")
                        .HasColumnType("TEXT");

                    b.Property<string>("mobilealertemail")
                        .HasColumnType("TEXT");

                    b.Property<string>("mobilephone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("modifiedon")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_acildurumdaulalacakkii")
                        .HasColumnType("TEXT");

                    b.Property<double?>("new_bakiyefark")
                        .HasColumnType("REAL");

                    b.Property<string>("new_bordroadsoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_ceptelefonuzel")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("new_dogumgunu")
                        .HasColumnType("TEXT");

                    b.Property<int?>("new_gendercode")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("new_ise_giris_tarihi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("new_isten_cikis_tarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_jobtitleeng")
                        .HasColumnType("TEXT");

                    b.Property<double?>("new_kalanbakiye")
                        .HasColumnType("REAL");

                    b.Property<int?>("new_kangrubu")
                        .HasColumnType("INTEGER");

                    b.Property<string>("new_kullanici_rolu")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_language")
                        .HasColumnType("TEXT");

                    b.Property<double>("new_mazeretzni")
                        .HasColumnType("REAL");

                    b.Property<string>("new_mezuniyetblm")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_mezuniyetokulu")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_mezuniyetyl")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_ncekiyerleri")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_password")
                        .HasColumnType("TEXT");

                    b.Property<int?>("new_portalyetkidzeyi")
                        .HasColumnType("INTEGER");

                    b.Property<string>("new_tecrbesi")
                        .HasColumnType("TEXT");

                    b.Property<bool>("new_timesheet")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("new_timesheetsre")
                        .HasColumnType("INTEGER");

                    b.Property<string>("new_timesheettarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("new_username")
                        .HasColumnType("TEXT");

                    b.Property<string>("nickname")
                        .HasColumnType("TEXT");

                    b.Property<string>("organizationid")
                        .HasColumnType("TEXT");

                    b.Property<int>("outgoingemaildeliverymethod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("overriddencreatedon")
                        .HasColumnType("TEXT");

                    b.Property<string>("ownerid")
                        .HasColumnType("TEXT");

                    b.Property<string>("passporthi")
                        .HasColumnType("TEXT");

                    b.Property<string>("passportlo")
                        .HasColumnType("TEXT");

                    b.Property<string>("personalemailaddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("photourl")
                        .HasColumnType("TEXT");

                    b.Property<int>("preferredaddresscode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("preferredemailcode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("preferredphonecode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("processid")
                        .HasColumnType("TEXT");

                    b.Property<string>("salutation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("setupuser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sharepointemailaddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("skills")
                        .HasColumnType("TEXT");

                    b.Property<string>("stageid")
                        .HasColumnType("TEXT");

                    b.Property<string>("systemuserid")
                        .HasColumnType("TEXT");

                    b.Property<int?>("timezoneruleversionnumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("traversedpath")
                        .HasColumnType("TEXT");

                    b.Property<int>("userlicensetype")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("utcconversiontimezonecode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("versionnumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("windowsliveid")
                        .HasColumnType("TEXT");

                    b.Property<string>("yammeremailaddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("yammeruserid")
                        .HasColumnType("TEXT");

                    b.Property<string>("yomifirstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("yomifullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("yomilastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("yomimiddlename")
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.ToTable("CrmUser");
                });
#pragma warning restore 612, 618
        }
    }
}
