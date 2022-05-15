﻿// <auto-generated />
using First_site_V2.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace First_site_V2.Storage.Migrations
{
    [DbContext(typeof(GaisContext))]
    [Migration("20220515192052_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("First_site_V2.Storage.Entities.FriendList", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Login");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("First_site_V2.Storage.Entities.Profile", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FriendListId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PNG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.HasIndex("FriendListId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("First_site_V2.Storage.Entities.Profile", b =>
                {
                    b.HasOne("First_site_V2.Storage.Entities.FriendList", null)
                        .WithMany("Friends")
                        .HasForeignKey("FriendListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("First_site_V2.Storage.Entities.FriendList", b =>
                {
                    b.Navigation("Friends");
                });
#pragma warning restore 612, 618
        }
    }
}
