﻿// <auto-generated />
using System;
using DotNetRu.MeetupManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DotNetRu.MeetupManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181109170932_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Common.Person", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("CompanyName");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Company", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.FriendDraft", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("FriendDrafts");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.MeetupDraft", b =>
                {
                    b.Property<string>("CommunityId")
                        .HasMaxLength(36);

                    b.Property<string>("Id")
                        .HasMaxLength(36);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("VenueId");

                    b.HasKey("CommunityId", "Id");

                    b.HasIndex("VenueId");

                    b.ToTable("MeetupDrafts");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.SpeakerDraft", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("BlogsUrl");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ContactsUrl");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<string>("GitHubUrl");

                    b.Property<string>("LastName");

                    b.Property<string>("TwitterUrl");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("SpeakerDrafts");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.TalkDraft", b =>
                {
                    b.Property<string>("CommunityId")
                        .HasMaxLength(36);

                    b.Property<string>("Id")
                        .HasMaxLength(36);

                    b.Property<string>("Comments");

                    b.Property<string>("MeetupDraftCommunityId");

                    b.Property<string>("MeetupDraftId");

                    b.Property<string>("Title");

                    b.HasKey("CommunityId", "Id");

                    b.HasIndex("MeetupDraftCommunityId", "MeetupDraftId");

                    b.ToTable("TalkDrafts");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.TalkRehearsal", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Comment");

                    b.Property<string>("TalkDraftCommunityId");

                    b.Property<string>("TalkDraftId");

                    b.Property<DateTimeOffset>("Time");

                    b.HasKey("Id");

                    b.HasIndex("TalkDraftCommunityId", "TalkDraftId");

                    b.ToTable("TalkRehearsals");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.VenueDraft", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Address");

                    b.Property<string>("MapUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("VenueDrafts");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.EntityReference", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<bool>("IsDraft");

                    b.Property<string>("MeetupDraftCommunityId");

                    b.Property<string>("MeetupDraftId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("TalkDraftCommunityId");

                    b.Property<string>("TalkDraftId");

                    b.HasKey("Id");

                    b.HasIndex("MeetupDraftCommunityId", "MeetupDraftId");

                    b.HasIndex("TalkDraftCommunityId", "TalkDraftId");

                    b.ToTable("EntityReferences");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Friend", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Speaker", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("BlogsUrl");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ContactsUrl");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<string>("GitHubUrl");

                    b.Property<string>("LastName");

                    b.Property<string>("TwitterUrl");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Venue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.MeetupDraft", b =>
                {
                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.EntityReference", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.SpeakerDraft", b =>
                {
                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.TalkDraft", b =>
                {
                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.MeetupDraft")
                        .WithMany("Talks")
                        .HasForeignKey("MeetupDraftCommunityId", "MeetupDraftId");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.TalkRehearsal", b =>
                {
                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.TalkDraft")
                        .WithMany("Rehearsals")
                        .HasForeignKey("TalkDraftCommunityId", "TalkDraftId");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.EntityReference", b =>
                {
                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.MeetupDraft")
                        .WithMany("Friends")
                        .HasForeignKey("MeetupDraftCommunityId", "MeetupDraftId");

                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Drafts.TalkDraft")
                        .WithMany("Speakers")
                        .HasForeignKey("TalkDraftCommunityId", "TalkDraftId");
                });

            modelBuilder.Entity("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Speaker", b =>
                {
                    b.HasOne("DotNetRu.MeetupManagement.Infrastructure.EFCore.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}